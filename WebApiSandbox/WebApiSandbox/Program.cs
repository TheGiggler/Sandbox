using WebApiSandbox;
using CollectionJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http.SelfHost;

namespace WebApiSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new HttpSelfHostConfiguration(new Uri("http://localhost:1313"));

            WebApiConfig.Register(config);

            var host = new HttpSelfHostServer(config);

            host.OpenAsync().Wait();
            Console.WriteLine("Post a User to http://localhost:1313/api/Users");
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();

            host.CloseAsync().Wait();
        }
    }
}
