using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2AbstractFactory
{
    public abstract class CheckBox : Control
    {
        public bool IsChecked { get; set; }
        public CheckBox(string text)
        {
            base.Text = text;
        }

        public CheckBox(string text, int x, int y)
        {
            base.Text = text;
            base.x = x;
            base.y = y;
        }
    }

    public class RedCheckBox : CheckBox
    {
        public RedCheckBox(string text) : base(text) {}

        public RedCheckBox(string text, int x, int y) : base(text, x, y) {}

        public override void Display()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(base.x, base.y);
            Console.Write("┌┐");
            Console.SetCursorPosition(base.x, base.y + 1);
            Console.Write("└┘");
            Console.SetCursorPosition(base.x + 3, base.y + 1);
            Console.Write(base.Text);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }

    public class LightWayCheckBox : CheckBox
    {
        public LightWayCheckBox(string text) : base(text) {}

        public LightWayCheckBox(string text, int x, int y) : base(text, x, y) {}

        public override void Display()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.SetCursorPosition(base.x, base.y);
            Console.Write("--");
            Console.SetCursorPosition(base.x, base.y + 1);
            Console.Write("--");
            Console.SetCursorPosition(base.x + 3, base.y + 1);
            Console.Write(base.Text);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
