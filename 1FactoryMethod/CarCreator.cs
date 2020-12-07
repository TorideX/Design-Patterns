using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1FactoryMethod
{
    public abstract class CarCreator
    {
        public abstract Car CreateCar();
    }

    public class ToyotaCreator : CarCreator
    {
        public override Car CreateCar()
        {
            return new ToyotaCar();
        }
    }

    public class HyundaiCreator : CarCreator
    {
        public override Car CreateCar()
        {
            return new HyundaiCar();
        }
    }
}
