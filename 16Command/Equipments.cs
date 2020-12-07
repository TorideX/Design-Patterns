using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16Command
{
    public class SmartLight
    {
        public void On()
        {
            Console.WriteLine("Light On");
        }
        public void Off()
        {
            Console.WriteLine("Light Off");
        }
    }

    public class SmartConditioner
    {
        private int temperature = 0;

        public void Start()
        {
            temperature = 27;
            Console.WriteLine("Start too heat room " + temperature + " c");
        }

        public void Stop()
        {
            temperature = 0;
            Console.WriteLine("Stop working");
        }

        public void SetTemp(int temp)
        {
            temperature = temp;
            Console.WriteLine("The new temp is " + temperature + " c");
        }
    }
}
