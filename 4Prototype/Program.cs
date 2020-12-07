using _2AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Alex", "Zeinalov", "zei@nalov.academy", 25);
            Person p2 = p1.Clone();

            Console.WriteLine(p2.Name + ' ' + p2.Surname);
            Person p2 = new Person();

            p2.Age = p1.Age;
            p2.Mail = p1.Mail;
            p2.Name = p1.Name;
            p2.Surname = p1.Surname;
            p2.Address = p1.Address;
            p2.ReturnBankAccount(true);
        }
    }
}
