using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2AbstractFactory
{
    public abstract class Button : Control
    {
        public Button()
        {

        }
        public Button(string text)
        {
            base.Text = text;
        }

        public Button(string text, int x, int y)
        {
            base.Text = text;
            base.x = x;
            base.y = y;
        }
    }

    public class RedButton : Button
    {
        public RedButton() : base()
        {

        }
        public RedButton(string text) : base(text) {}
        public RedButton(string text, int x, int y) : base(text, x, y) 
        {
            base.Height = 5;
            base.Width = 10;
        }

        public override void Display()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            for (int j = 0; j < Height; j++)
            {
                for (int i = 0; i < Width; i++)
                {
                    Console.SetCursorPosition(base.x + i, base.y + j);
                    if (i == 0 && j == 0) Console.Write('┌');
                    else if (i == 0 && j == Height - 1) Console.Write('└');
                    else if (i == Width - 1 && j == 0) Console.Write('┐');
                    else if (i == Width - 1 && j == Height - 1) Console.Write('┘');
                    else if (i == 0 || i == Width - 1) Console.Write('│');
                    else if (j == 0 || j == Height - 1) Console.Write('─');
                    else if (i == 1 || i == Width - 2) Console.Write(' ');
                    else Console.Write(Text);
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;

        }
    }

    public class LightWayButton : Button
    {
        public LightWayButton() : base()
        {

        }
        public LightWayButton(string text) : base(text) {}

        public LightWayButton(string text, int x, int y) : base(text, x, y)
        {
            base.Height = 5;
            base.Width = 10;
        }

        public override void Display()
        {
            Console.BackgroundColor = ConsoleColor.White;
            for (int j = 0; j < Height; j++)
            {
                for (int i = 0; i < Width; i++)
                {
                    Console.SetCursorPosition(base.x + i, base.y + j);
                    if (i == 0 && j == 0) Console.Write('┌');
                    else if (i == 0 && j == Height - 1) Console.Write('|');
                    else if (i == Width - 1 && j == 0) Console.Write('|');
                    else if (i == Width - 1 && j == Height - 1) Console.Write('|');
                    else if (i == 0 || i == Width - 1) Console.Write('|');
                    else if (j == 0 || j == Height - 1) Console.Write('=');
                    else if (i == 0 || i == Width - 2) Console.Write(' ');
                    else Console.Write(Text);
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
