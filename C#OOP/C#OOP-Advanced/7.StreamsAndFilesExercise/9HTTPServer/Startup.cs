namespace _9HTTPServer
{
    using System;
    using System.Globalization;
    using System.Threading;

    class Startup
    {
        public static int Main(String[] args)
        {         
            HttpServer httpServer;
            if (args.GetLength(0) > 0)
            {
                httpServer = new MyHttpServer(Convert.ToInt16(args[0]));
            }
            else
            {
                httpServer = new MyHttpServer(8080);
            }
            Thread thread = new Thread(httpServer.listen);
            thread.Start();

            return 0;
        }
    }
}