using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Bridge
{
    interface IMoveable
    {
        void Drive();
        void Stop();
    }

    class Car : IMoveable
    {
        public void Drive()
        {
            Console.WriteLine("Beep Beep");
        }

        public void Stop()
        {
            Console.WriteLine("This is the police YPX");
        }
    }

    class Truck : IMoveable
    {
        public void Drive()
        {
            Console.WriteLine("Choo choo");
        }

        public void Stop()
        {
            Console.WriteLine("Da");
        }
    }
}
