using AbstractFactory.Car.ModelFactory.Base;

namespace AbstractFactory.Car.Base
{
    public interface ICar
    {
        void Build(IModelFactory modelFactory);
    }
}