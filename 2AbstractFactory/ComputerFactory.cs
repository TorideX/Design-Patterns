using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2AbstractFactory
{
    public abstract class ComputerFactory
    {
        public abstract HDD CreateHDD();
        public abstract CPU CreateCPU();
        public abstract GPU CreateGPU();
        public abstract Case CreateCase();
        public abstract MotherBoard CreateMotherBoard();
        public abstract RAM CreateRAM();
    }

    public class OfficeComputerFactory : ComputerFactory
    {
        public override Case CreateCase()
        {
            return new AerocoolCase();
        }

        public override CPU CreateCPU()
        {
            return new AmdCPU();
        }

        public override GPU CreateGPU()
        {
            return new AmdGPU();
        }

        public override HDD CreateHDD()
        {
            return new HuanoHDD();
        }

        public override MotherBoard CreateMotherBoard()
        {
            return new AsusMotherBoard();
        }

        public override RAM CreateRAM()
        {
            return new HyperxRAM();
        }
    }

    public class GameComputerFactory : ComputerFactory
    {
        public override Case CreateCase()
        {
            return new CorsairCase();
        }

        public override CPU CreateCPU()
        {
            return new IntelCPU();
        }

        public override GPU CreateGPU()
        {
            return new NvidiaGPU();
        }

        public override HDD CreateHDD()
        {
            return new WDHDD();
        }

        public override MotherBoard CreateMotherBoard()
        {
            return new GigabyteMotherBoard();
        }

        public override RAM CreateRAM()
        {
            return new CorsairRAM();
        }
    }
}
