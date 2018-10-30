using AbstractFactory.Car;
using AbstractFactory.Car.ModelFactory;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            CarBuilder car = new CarBuilder();
            car.Build(new PassatFactory());

            Console.WriteLine("-------------");

            car.Build(new GTIFactory());

            Console.WriteLine("-------------");

            car.Build(new AmeoFactory());
        }
    }
}
