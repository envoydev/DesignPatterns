using AbstractFactory.Car.Base;
using AbstractFactory.Car.ModelFactory.Base;
using System;

namespace AbstractFactory.Car
{
    public class CarBuilder : ICar
    {
        public void Build(IModelFactory modelFactory)
        {
            var body = modelFactory.CreateBody();
            var engine = modelFactory.CreateEngine();

            Console.WriteLine(body.Type());
            Console.WriteLine(engine.Type());
        }
    }
}
