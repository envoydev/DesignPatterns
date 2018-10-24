using Strategy.Ducks.Behaviours.Fly.Interface;
using System;

namespace Strategy.Ducks.Behaviours.Fly
{
    public class SimpleFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I`m flying!");
        }
    }
}
