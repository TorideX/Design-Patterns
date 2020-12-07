using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ApiSenderProxy proxy = new ApiSenderProxy();
            BusService busService = new BusService(proxy);
            busService.SendRequest("Salam");
            busService.SendRequest("Aloha");
            busService.SendRequest("Privet");
            busService.SendRequest("Hola");
            busService.SendRequest("Bon jour");
            busService.SendRequest("Zdorovenki buli");

            Console.WriteLine(proxy.numberOfQueries);
        }
    }
}
