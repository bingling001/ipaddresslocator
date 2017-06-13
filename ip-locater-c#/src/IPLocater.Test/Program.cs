using System;
using System.IO;

namespace IPLocater.Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "../../../../../data/ip-locater.dat");
            var locater = new CoderBusy.IPLocater(path);
            var ip = "10.10.10.10";
            var result = locater.QueryLocation(ip);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}