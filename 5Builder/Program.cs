using _2AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //CorrectButton cb = new CorrectButton(0,0,0,0, null, ConsoleColor.Red, ConsoleColor.Gray);

            ButtonBuilder builder =
                new RedButtonBuilder().WithHeight(5).WithWidth(10).WithX(0).WithY(5);
            //builder.WithHeight(5);
            //builder.WithWidth(10);
            //builder.WithX(0);s
            //builder.WithY(5);
            Button btn = new RedButtonBuilder()
                .WithHeight(5)
                .WithWidth(10)
                .WithX(0)
                .WithY(5)
                .BuildButton();

            btn.Display();

            ButtonBuilder anotherBuilder = new RedButtonBuilder();
            //anotherBuilder.WithX(0);
            //anotherBuilder.WithY(0);
            //anotherBuilder.WithHeight(15);
            //anotherBuilder.WithWidth(1);
            //anotherBuilder.WithText("Salam!");

            Button anoterBtn = anotherBuilder.BuildButton();
            anoterBtn.Display();

            Director director = new Director(new RedButtonBuilder());
        }
    }
}
