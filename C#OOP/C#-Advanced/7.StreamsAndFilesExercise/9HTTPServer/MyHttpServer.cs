namespace _9HTTPServer
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Threading;

    public class MyHttpServer : HttpServer
    {
        public MyHttpServer(int port)
            : base(port)
        {
        }

        public override void HandleGetRequest(HttpProcessor p)
        {
            if (p.HttpUrl.Equals("/"))
            {
                p.WriteSuccess();
                p.OutputStream.WriteLine($"<html><head><title>Home Page</title></head><body><h1>Welcome to our test page.</h1><h4>You can check the server information <a href=\"/info\">here</a></h4><h5>Congratulations for creating your first web app :) </h5></body></html>");
            }
            else if (p.HttpUrl.Equals("/info"))
            {

                p.WriteSuccess();
                p.OutputStream.WriteLine($"<html><head><title>Info Page</title></head><body><h2>Current Time: {DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss", CultureInfo.InvariantCulture)}</h2><h2>Logical Processors: {Environment.ProcessorCount}<h2></body></html>");
            }
            else
            {
                p.WriteSuccess();
                p.OutputStream.WriteLine("<html><head><title>Error Page</title></head><body><h2 style=\"color:red\">Error! Try going to the <a href=\"/\">home page</a></h2></body></html>"); 
            }
        }

        public override void HandlePostRequest(HttpProcessor p, StreamReader inputData)
        {
            Console.WriteLine("POST request: {0}", p.HttpUrl);
            string data = inputData.ReadToEnd();

            p.WriteSuccess();
            p.OutputStream.WriteLine("<html><body><h1>test server</h1>");
            p.OutputStream.WriteLine("<a href=/test>return</a><p>");
            p.OutputStream.WriteLine("postbody: <pre>{0}</pre>", data);
        }
    }
}