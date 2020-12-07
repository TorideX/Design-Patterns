using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero();
            hero.Shoot();
            HeroMemento hm = hero.SaveState();
            Console.WriteLine(hm.Lives + " lives and " + hm.Patrons + " patrons");

            Hero newHero = new Hero();
            newHero.Restore(hm);
            newHero.Shoot();
        }
    }
}
