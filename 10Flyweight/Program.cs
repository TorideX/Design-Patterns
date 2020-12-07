using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Flyweight
{
    interface k
    {
        void kek();
    }

    static class kk : k
    {

    }
    class Model
    {
        private byte[] data = new byte[10100101];
    }
    class Texture
    {
        private byte[] data = new byte[5050505];
    }

    class LegionerContext
    {
        private LegionerFlyweight _legionerFlyweight;
        public LegionerContext(LegionerFlyweight legionerFlyweight)
        {
            _legionerFlyweight = legionerFlyweight;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Speed { get; set; }
        public int HP { get; set; }

        public void Render()
        {
            _legionerFlyweight.Render(this);
        }

        public void Run()
        {
            _legionerFlyweight.Run(this);
        }
        public void Attack()
        {
            _legionerFlyweight.Attack(this);
        }
    }

    class LegionerFlyweight
    {
        private Model model;
        private Texture texture;

        public void Render(LegionerContext legioner)
        {

        }
        public void Run (LegionerContext legioner)
        {

        }

        public void Attack(LegionerContext legioner)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            LegionerFlyweight legionerFlyweight = new LegionerFlyweight();

            var l1 = new LegionerContext(legionerFlyweight);
            var l2 = new LegionerContext(legionerFlyweight);
            var l3 = new LegionerContext(legionerFlyweight);
            var l4 = new LegionerContext(legionerFlyweight);

            l4.Run();
            l4.Render();
        }
    }
}
