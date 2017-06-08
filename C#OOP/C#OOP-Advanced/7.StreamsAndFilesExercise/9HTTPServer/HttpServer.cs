namespace _9HTTPServer
{
    using System.IO;
    using System.Net.Sockets;
    using System.Threading;

    public abstract class HttpServer
    {
        readonly bool is_active = true;
        TcpListener _listener;

        protected int Port;

        protected HttpServer(int port)
        {
            this.Port = port;
        }

        public void listen()
        {
            this._listener = new TcpListener(this.Port);
            this._listener.Start();
            while (this.is_active)
            {
                TcpClient s = this._listener.AcceptTcpClient();
                HttpProcessor processor = new HttpProcessor(s, this);
                Thread thread = new Thread(new ThreadStart(processor.Process));
                thread.Start();
                Thread.Sleep(1);
            }
        }

        public abstract void HandleGetRequest(HttpProcessor p);
        public abstract void HandlePostRequest(HttpProcessor p, StreamReader inputData);
    }
}