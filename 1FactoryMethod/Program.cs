using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarCreator carCreator = new HyundaiCreator();
            CarCreator carCreator = new ToyotaCreator();
            Car newCar = carCreator.CreateCar();
            newCar.PrintInfoInDisplay();
        }
    }
}
