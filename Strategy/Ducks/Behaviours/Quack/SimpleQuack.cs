using Strategy.Ducks.Behaviours.Quack.Interface;
using System;

namespace Strategy.Ducks.Behaviours.Quack
{
    public class SimpleQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack! Quack!");
        }
    }
}
