using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14State
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            player.Attack(null);
            player.Attack(null);
            player.Attack(null);
            Console.WriteLine("--------------");
            player.Attack(null);
            player.Attack(null);
            player.Attack(null);
            player.Attack(null);
        }
    }
}
