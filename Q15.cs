//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp2
//{
//    abstract class Character
//    {
//        public abstract void Attack();
//    }

//    class Knight : Character
//    {
//        public override void Attack()
//        {
//            Console.WriteLine("검으로 공격!");
//        }
//    }

//    class Archer : Character
//    {
//        public override void Attack()
//        {
//            Console.WriteLine("화살을 쏜다!");
//        }
//    }

//    class Mage : Character
//    {
//        public override void Attack()
//        {
//            Console.WriteLine("마법 공격!");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Character knight = new Knight();
//            Character archer = new Archer();
//            Character mage = new Mage();
//            knight.Attack();
//            archer.Attack();
//            mage.Attack();

//        }
//    }
//}
