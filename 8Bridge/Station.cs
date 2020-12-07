using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Bridge
{
    class Driver
    {
        IMoveable implementation;
        public decimal localSpeed { get; set; }

        public Driver(IMoveable i)
        {
            implementation = i;
        }
        
        public void Drive()
        {
            implementation.Drive();
        }

        public void Stop()
        {
            implementation.Stop();
        }
    }
}
