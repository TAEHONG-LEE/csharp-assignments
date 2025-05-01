using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//예전에 정리했던 인터페이스 어떻게 사용하는지 참고
namespace ConsoleApp2
{
    interface IMovable
    {
        void Move();
    }

    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("차가 달린다");
        }
    }

    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("자전거가 굴러간다");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IMovable movable = new Car();
            IMovable movable1 = new Bicycle();
            movable.Move();
            movable1.Move();
        }
    }
}
