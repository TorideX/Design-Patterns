using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ChainOfResponsibility
{
    class Program
    {
        static Handler chain;
        static void Main(string[] args)
        {
            chain = new SpamHandler(new FansHandler(new SocialHandler(null)));

            Console.WriteLine("Enter your email text");
            string text = Console.ReadLine();

            MessageType messageType = chain.HandleRequest(text);
            Console.WriteLine("Your text is - " + messageType.ToString());
        }
    }
}
