using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Bridge
{

    class Program
    {
        static void Main(string[] args)
        {
            Driver d = new Driver(new Truck());
            d.Drive();
            d.Stop();
        }
    }
}
