using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2AbstractFactory
{

    class Configurator
    {
        public Configurator(ComputerFactory computerFactory)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new LightWayUIFactory();

            Button button = factory.CreateButton("some", 4,5);
            button.Display();
            CheckBox checkBox = factory.CreateCheckBox("da?", 15,15);
            checkBox.Display();
            Console.ReadLine();
        }
    }
}
