using System;
using Nancy.Hosting.Self;


namespace NancyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new NancyHost(new Uri("http://localhost:8080"));
            host.Start();
            Console.ReadLine();
        }
    }
}
