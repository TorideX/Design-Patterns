using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2AbstractFactory
{
    public abstract class Device
    {
        public abstract void DisplayTS();
    }

    public abstract class Case : Device
    {
    }
    public abstract class HDD : Device
    {
    }
    public abstract class CPU : Device
    {
        protected CPU()
        {
        }
    }
    public abstract class GPU : Device
    {

    }
    public abstract class MotherBoard : Device
    {

    }
    public abstract class RAM : Device
    {

    }


    public class CorsairCase : Case
    {
        public override void DisplayTS()
        {
            Console.WriteLine("Corsair GTX 550i");
        }
    }
    public class AerocoolCase : Case
    {
        public override void DisplayTS()
        {
            Console.WriteLine("Aerocool 2");
        }
    }

    public class IntelCPU : CPU
    {
        public override void DisplayTS()
        {
            Console.WriteLine("Intel 10900k");
        }
    }
    public class AmdCPU : CPU
    {
        public override void DisplayTS()
        {
            Console.WriteLine("AMD Ryzen 3700");
        }
    }

    public class AmdGPU : GPU
    {
        public override void DisplayTS()
        {
            Console.WriteLine("AMD VEGA 2");
        }
    }
    public class NvidiaGPU : GPU
    {
        public override void DisplayTS()
        {
            Console.WriteLine("RTX 2080ti");
        }
    }

    public class AsusMotherBoard : MotherBoard
    {
        public override void DisplayTS()
        {
            Console.WriteLine("ASUS MAXIMUS X");
        }
    }
    public class GigabyteMotherBoard : MotherBoard
    {
        public override void DisplayTS()
        {
            Console.WriteLine("Gigabyte BAZOOKA Z270");
        }
    }

    public class CorsairRAM : RAM
    {
        public override void DisplayTS()
        {
            Console.WriteLine("Tooz 4666");
        }
    }
    public class HyperxRAM : RAM
    {
        public override void DisplayTS()
        {
            Console.WriteLine("eXtreme 50000");
        }
    }

    public class WDHDD : HDD
    {
        public override void DisplayTS()
        {
            Console.WriteLine("WD Black 8tb");
        }
    }
    public class HuanoHDD : HDD
    {
        public override void DisplayTS()
        {
            Console.WriteLine("Huano 500gb");
        }
    }
}
