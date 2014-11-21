using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseUrl = "http://*:5000";
            using (WebApp.Start<Startup>(baseUrl))
            {
                Console.WriteLine("Press Enter to quit.");
                Console.ReadKey();

            }
        }
    }
}
