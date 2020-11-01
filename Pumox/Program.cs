using Microsoft.Owin.Hosting;
using System;
using System.Net.Http;

namespace OwinSelfhost
{
    public class Program
    {
        static void Main()
        {
            string baseAddress = "http://localhost:49277/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                // Create HttpClient and make a request
                HttpClient client = new HttpClient();

                //var response = client.GetAsync(baseAddress + "company/search").Result;

                //Console.WriteLine(response);
                //Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                Console.WriteLine("Running...");
                Console.ReadLine();
            }
        }
    }
}