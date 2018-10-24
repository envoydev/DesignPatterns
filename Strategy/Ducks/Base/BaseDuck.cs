using Strategy.Ducks.Behaviours.Fly;
using Strategy.Ducks.Behaviours.Fly.Interface;
using Strategy.Ducks.Behaviours.Quack;
using Strategy.Ducks.Behaviours.Quack.Interface;
using System;

namespace Strategy.Ducks.Base
{
    public abstract class BaseDuck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public BaseDuck()
        {
            flyBehavior = new SimpleFly();
            quackBehavior = new SimpleQuack();
        }

        public virtual void Quack()
        {
            quackBehavior.Quack();
        }

        public virtual void Fly()
        {
            flyBehavior.Fly();
        }

        public virtual void Swim()
        {
            Console.WriteLine("I`m swimming");
        }

        public abstract void Display();
    }
}
