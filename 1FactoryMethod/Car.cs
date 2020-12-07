using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1FactoryMethod
{
    public abstract class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public decimal Speed { get; set; }

        public abstract void PrintInfoInDisplay();
    }

    public class ToyotaCar : Car
    {
        public override void PrintInfoInDisplay()
        {
            Console.WriteLine("|----------------------------------------------------|");
            Console.WriteLine("|                                                    |"); 
            Console.WriteLine("|                                                    |");
            Console.WriteLine("|                     Amma toyota                    |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("|----------------------------------------------------|");
        }
    }
    public class HyundaiCar : Car
    {
        public override void PrintInfoInDisplay()
        {
            Console.WriteLine("|----------------------------------------------------|");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("|                     (^///^)(^///^)                 |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("|----------------------------------------------------|");
        }
    }
}
