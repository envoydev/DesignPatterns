using Strategy.Ducks.Base;
using System;

namespace Strategy.Ducks
{
    public class GreenDuck : BaseDuck
    {
        public override void Display()
        {
            Console.WriteLine("Hi! I`m an green duck");
        }
    }
}
