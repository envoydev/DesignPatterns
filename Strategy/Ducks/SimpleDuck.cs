using Strategy.Ducks.Base;
using System;

namespace Strategy.Ducks
{
    public class SimpleDuck : BaseDuck
    {
        public override void Display()
        {
            Console.WriteLine("Hi! I`m an simple duck");
        }
    }
}
