using AbstractFactory.Car.Carcases;
using AbstractFactory.Car.Carcases.Base;
using AbstractFactory.Car.Engines;
using AbstractFactory.Car.Engines.Base;
using AbstractFactory.Car.ModelFactory.Base;

namespace AbstractFactory.Car.ModelFactory
{
    public class PassatFactory : IModelFactory
    {
        public IBody CreateBody()
        {
            return new HatchbackBody();
        }

        public IEngine CreateEngine()
        {
            return new InlineEngine();
        }
    }
}
