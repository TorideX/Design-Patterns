using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14State
{
    class PlayerPis
    {
        int countOfAttack = 3;

        public void Attack(object target)
        {
            if(countOfAttack <= 0)
            {
                Console.WriteLine("Clap bang");
            }
            else
            {
                Console.WriteLine("Swish");
            }
            countOfAttack--;
        }
    }

    public class Player
    {
        IAttackState attackState;


        public Player()
        {
            attackState = new SwordState();
        }
        public void SetState(IAttackState newState)
        {
            attackState = newState;
        }

        public void Attack(object target)
        {
            attackState?.Attack(this, target);
        }
    }

    public interface IAttackState
    {
        void Attack(Player player, object target);
    }
    public class FistsState : IAttackState
    {
        public void Attack(Player player, object target)
        {
            Console.WriteLine("Bang bang");
        }
    }

    public class SwordState : IAttackState
    {
        int countOfAttack = 3;
        public void Attack(Player player, object target)
        {
            if (countOfAttack <= 0)
                player.SetState(new FistsState());
            else
                Console.WriteLine("Swish");
            
            countOfAttack--;
        }
    }
}
