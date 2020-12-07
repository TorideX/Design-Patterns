using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            StockExchange s = new StockExchange();
            Bank bank = new Bank(s, "PashaBank");
            Broker b1 = new Broker(s, "123456789");
            Broker b2 = new Broker(s, "Qardash");

            Console.ReadLine();
            s.UpdateRate();

            b2.StopBuying();

            Console.ReadLine();
            s.UpdateRate();

            Console.ReadLine();
        }
    }
}
