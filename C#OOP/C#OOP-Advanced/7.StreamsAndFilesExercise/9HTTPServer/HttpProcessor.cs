namespace _9HTTPServer
{
    using System;
    using System.Collections;
    using System.IO;
    using System.Net.Sockets;
    using System.Threading;

    public class HttpProcessor
    {
        private const int BUF_SIZE = 4096;


        private static readonly int MAX_POST_SIZE = 10 * 1024 * 1024; // 10MB

        private Stream _inputStream;
        public HttpServer HtppServer;
        public Hashtable HttpHeaders = new Hashtable();

        public String HttpMethod;
        public String HttpProtocolVersionstring;
        public String HttpUrl;
        public StreamWriter OutputStream;
        public TcpClient Socket;

        public HttpProcessor(TcpClient tcpClient, HttpServer htppServer)
        {
            this.Socket = tcpClient;
            this.HtppServer = htppServer;
        }


        private string StreamReadLine(Stream inputStream)
        {
            string data = "";
            while (true)
            {
                var nextChar = inputStream.ReadByte();
                if (nextChar == '\n')
                {
                    break;
                }
                switch (nextChar)
                {
                    case '\r':
                        continue;
                    case -1:
                        Thread.Sleep(1);
                        continue;
                }
                
                data += Convert.ToChar(nextChar);
            }

            return data;
        }

        public void Process()
        {
            // we can't use a StreamReader for input, because it buffers up extra data on us inside it's
            // "processed" view of the world, and we want the data raw after the headers
            this._inputStream = new BufferedStream(this.Socket.GetStream());

            // we probably shouldn't be using a streamwriter for all output from handlers either
            this.OutputStream = new StreamWriter(new BufferedStream(this.Socket.GetStream()));
            try
            {
                this.parseRequest();
                this.ReadHeaders();
                if (this.HttpMethod.Equals("GET"))
                {
                    this.HandleGetRequest();
                }
                else if (this.HttpMethod.Equals("POST"))
                {
                    this.HandlePostRequest();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.ToString());
                this.WriteFailure();
            }
            this.OutputStream.Flush();
            // bs.Flush(); // flush any remaining output
            this._inputStream = null;
            this.OutputStream = null; // bs = null;            
            this.Socket.Close();
        }

        public void parseRequest()
        {
            String request = this.StreamReadLine(this._inputStream);
            string[] tokens = request.Split(' ');
            if (tokens.Length != 3)
            {
                throw new Exception("invalid http request line");
            }
            this.HttpMethod = tokens[0].ToUpper();
            this.HttpUrl = tokens[1];
            this.HttpProtocolVersionstring = tokens[2];

            Console.WriteLine("starting: " + request);
        }

        public void ReadHeaders()
        {
            Console.WriteLine("readHeaders()");
            String line;
            while ((line = this.StreamReadLine(this._inputStream)) != null)
            {
                if (line.Equals(""))
                {
                    Console.WriteLine("got headers");
                    return;
                }

                int separator = line.IndexOf(':');
                if (separator == -1)
                {
                    throw new Exception("invalid http header line: " + line);
                }
                String name = line.Substring(0, separator);
                int pos = separator + 1;
                while ((pos < line.Length) && (line[pos] == ' '))
                {
                    pos++; // strip any spaces
                }

                string value = line.Substring(pos, line.Length - pos);
                Console.WriteLine("header: {0}:{1}", name, value);
                this.HttpHeaders[name] = value;
            }
        }

        public void HandleGetRequest()
        {
            this.HtppServer.HandleGetRequest(this);
        }

        public void HandlePostRequest()
        {
            // this post data processing just reads everything into a memory stream.
            // this is fine for smallish things, but for large stuff we should really
            // hand an input stream to the request processor. However, the input stream 
            // we hand him needs to let him see the "end of the stream" at this content 
            // length, because otherwise he won't know when he's seen it all! 

            Console.WriteLine("get post data start");
            MemoryStream ms = new MemoryStream();
            if (this.HttpHeaders.ContainsKey("Content-Length"))
            {
                var content_len = Convert.ToInt32(this.HttpHeaders["Content-Length"]);
                if (content_len > MAX_POST_SIZE)
                {
                    throw new Exception(
                        $"POST Content-Length({content_len}) too big for this simple server");
                }
                byte[] buf = new byte[BUF_SIZE];
                int to_read = content_len;
                while (to_read > 0)
                {
                    Console.WriteLine("starting Read, to_read={0}", to_read);

                    int numread = this._inputStream.Read(buf, 0, Math.Min(BUF_SIZE, to_read));
                    Console.WriteLine("read finished, numread={0}", numread);
                    if (numread == 0)
                    {
                        if (to_read == 0)
                        {
                            break;
                        }
                        else
                        {
                            throw new Exception("client disconnected during post");
                        }
                    }
                    to_read -= numread;
                    ms.Write(buf, 0, numread);
                }
                ms.Seek(0, SeekOrigin.Begin);
            }
            Console.WriteLine("get post data end");
            this.HtppServer.HandlePostRequest(this, new StreamReader(ms));
        }

        public void WriteSuccess(string contentType = "text/html")
        {
            this.OutputStream.WriteLine("HTTP/1.0 200 OK");
            this.OutputStream.WriteLine("Content-Type: " + contentType);
            this.OutputStream.WriteLine("Connection: close");
            this.OutputStream.WriteLine("");
        }

        public void WriteFailure()
        {
            this.OutputStream.WriteLine("HTTP/1.0 404 File not found");
            this.OutputStream.WriteLine("Connection: close");
            this.OutputStream.WriteLine("");
        }
    }
}