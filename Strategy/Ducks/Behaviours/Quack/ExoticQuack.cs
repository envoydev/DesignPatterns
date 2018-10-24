using Strategy.Ducks.Behaviours.Quack.Interface;
using System;

namespace Strategy.Ducks.Behaviours.Quack
{
    public class ExoticQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Meow! Meow!");
        }
    }
}
