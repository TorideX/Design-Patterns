using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Strategy
{
    class PlayerPis
    {
        public void Attack (WeaponPis weapon, object target)
        {
            switch (weapon)
            {
                case WeaponPis.Fists:
                    Console.WriteLine("Clap bang");
                    break;
                case WeaponPis.Sword:
                    Console.WriteLine("Swish");
                    break;
                case WeaponPis.Bow:
                    Console.WriteLine("Oh");
                    break;
            }
        }

        public void Move (WalkTypePis walk, object location)
        {
            switch (walk)
            {
                case WalkTypePis.Run:
                    Console.WriteLine("Runnin\'");
                    break;
                case WalkTypePis.NormalWalk:
                    Console.WriteLine("Chap chap");
                    break;
                case WalkTypePis.Slide:
                    Console.WriteLine("Wiiiiiiihha");
                    break;
            }
        }
    }

    public enum WeaponPis
    {
        Fists,
        Sword,
        Bow
    }

    public enum WalkTypePis
    {
        NormalWalk,
        Run,
        Slide
    }

    public interface IAttackStrategy
    {
        void Attack(object target);
    }

    public interface IWalkStrategy
    {
        void Walk(object target);
    }

    class RunStrategy : IWalkStrategy
    {
        public void Walk(object target)
        {
            Console.WriteLine("Chap chap");
        }
    }

    public class BowStategy : IAttackStrategy
    {
        public void Attack(object target)
        {
            Console.WriteLine("Oh");
        }
    }

    public class SwordStategy : IAttackStrategy
    {
        public void Attack(object target)
        {
            Console.WriteLine("Swish");
        }
    }

    public class Player
    {
        public IAttackStrategy AttackStrategy { get; set; }
        public IWalkStrategy WalkStrategy { get; set; }

        public void Attack(object target)
        {
            AttackStrategy?.Attack(target);
        }

        public void Walk(object location)
        {
            WalkStrategy?.Walk(location);
        }

        //KISS - Keep It Simple, Stupid
    }
}