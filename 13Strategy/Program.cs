using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //PlayerPis player = new PlayerPis();
            //player.Attack(WeaponPis.Bow, player);

            Player player = new Player();

            player.AttackStrategy = new SwordStategy();
            player.Attack(null);

            player.AttackStrategy = new BowStategy();
            player.Attack(null);

            player.WalkStrategy = new RunStrategy();
        }
    }
}
