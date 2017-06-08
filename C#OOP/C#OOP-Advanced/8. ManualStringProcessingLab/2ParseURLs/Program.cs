namespace _2ParseURLs
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string url = Console.ReadLine();

            if (!url.Contains("://"))
            {

                Console.WriteLine("Invalid URL");
                Environment.Exit(0);


            }


            string protocol = url.Substring(0, url.IndexOf("://"));
            url = url.Substring(protocol.Length + 3, url.Length - protocol.Length - 3);

            if (url.Contains("://") || !url.Contains("/"))
            {
                Console.WriteLine("Invalid URL");
                Environment.Exit(0);
            }

            var index = url.IndexOf("/");
            if (index == -1)
            {
                Console.WriteLine("Invalid URL");
            }
            string server = url.Substring(0, index);

            url = url.Substring(server.Length + 1, url.Length - server.Length - 1);

            string resources = url;


            Console.WriteLine($"Protocol = {protocol}");
            Console.WriteLine($"Server = {server}");
            Console.WriteLine($"Resources = {resources}");
        }
    }
}