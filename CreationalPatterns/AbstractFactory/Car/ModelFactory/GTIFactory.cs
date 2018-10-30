using AbstractFactory.Car.Carcases;
using AbstractFactory.Car.Carcases.Base;
using AbstractFactory.Car.Engines;
using AbstractFactory.Car.Engines.Base;
using AbstractFactory.Car.ModelFactory.Base;

namespace AbstractFactory.Car.ModelFactory
{
    public class GTIFactory : IModelFactory
    {
        public IBody CreateBody()
        {
            return new CoupeBody();
        }

        public IEngine CreateEngine()
        {
            return new VeeEngine();
        }
    }
}
