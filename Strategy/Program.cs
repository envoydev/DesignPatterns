using Strategy.Ducks;
using Strategy.Ducks.Base;
using System;
using System.Collections.Generic;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //The main idea of Strategy pattern is to use algoritms of one behaviour in composition of base class

            List<BaseDuck> ducks = new List<BaseDuck>();
            ducks.Add(new ExoticDuck());
            ducks.Add(new SimpleDuck());
            ducks.Add(new GreenDuck());
            ducks.Add(new WoodenDuck());
            ducks.Add(new RubberDuck());

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.Swim();
                duck.Quack();
                duck.Fly();

                Console.WriteLine();
            }
        }
    }
}
