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
            var ip = "202.102.227.68";
            var result = locater.Query(ip);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}