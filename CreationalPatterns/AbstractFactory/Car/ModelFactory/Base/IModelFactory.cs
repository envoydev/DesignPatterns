using AbstractFactory.Car.Carcases.Base;
using AbstractFactory.Car.Engines.Base;

namespace AbstractFactory.Car.ModelFactory.Base
{
    public interface IModelFactory
    {
        IBody CreateBody();
        IEngine CreateEngine();
    }
}
