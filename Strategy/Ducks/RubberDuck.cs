using Strategy.Ducks.Base;
using Strategy.Ducks.Behaviours.Fly;
using System;

namespace Strategy.Ducks
{
    public class RubberDuck : BaseDuck
    {
        public RubberDuck()
        {
            flyBehavior = new NoFly();
        }

        public override void Display()
        {
            Console.WriteLine("Hi! I`m a rubber duck!");
        }
    }
}
