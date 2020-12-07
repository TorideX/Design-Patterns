using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2AbstractFactory
{
    public abstract class Control
    {
        public int x { get; set; }
        public int y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Text { get; set; }
        public string Tooltip { get; set; }

        public abstract void Display();
    }
}
