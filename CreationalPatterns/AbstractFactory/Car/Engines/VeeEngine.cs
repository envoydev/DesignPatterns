using AbstractFactory.Car.Engines.Base;

namespace AbstractFactory.Car.Engines
{
    public class VeeEngine : IEngine
    {
        public int Сylinders { get; } = 16;

        public string Type()
        {
            return $"Vee with {Сylinders} cylinders";
        }
    }
}
