using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17Memento
{
    public class Hero
    {
        private int patrons = 10;
        private int lives = 6;
        private object target = new object();

        public void Shoot()
        {
            if (patrons > 0)
            {
                patrons--;
                Console.WriteLine("Shoot, patrons have " + patrons);
            }
            else
                Console.WriteLine("Not enought for shoot");
        }

        public HeroMemento SaveState()
        {
            Console.WriteLine("Save a game... patron: " + patrons + " , lives: " + lives);
            return new HeroMemento(patrons, lives); //, target
        }

        public void Restore(HeroMemento memento)
        {
            this.patrons = memento.Patrons;
            this.lives = memento.Lives;
        }
    }

    public class HeroMemento
    {
        public int Patrons { get; private set; }
        public int Lives { get; private set; }

        public HeroMemento(int patron, int lives)
        {
            Patrons = patron;
            Lives = lives;
        }
    }
}
