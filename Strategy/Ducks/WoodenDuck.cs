using Strategy.Ducks.Base;
using Strategy.Ducks.Behaviours.Fly;
using Strategy.Ducks.Behaviours.Quack;
using System;

namespace Strategy.Ducks
{
    public class WoodenDuck : BaseDuck
    {
        public WoodenDuck()
        {
            flyBehavior = new NoFly();
            quackBehavior = new NoQuack();
        }

        public override void Display()
        {
            Console.WriteLine("Hi! I`m a wooden duck!");
        }
    }
}
