using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SelfHostFilestream
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:9000/";
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                HttpClient client = new HttpClient();
                client.GetStreamAsync(baseAddress + "/").Result.CopyTo(Console.OpenStandardOutput());
            }
            Console.ReadLine(); 
        }
    }
}
