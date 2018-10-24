using Strategy.Ducks.Base;
using Strategy.Ducks.Behaviours.Quack;
using System;

namespace Strategy.Ducks
{
    public class ExoticDuck : BaseDuck
    {
        public ExoticDuck()
        {
            quackBehavior = new ExoticQuack();
        }

        public override void Display()
        {
            Console.WriteLine("Hi! I`m an exotic duck");
        }
    }
}
