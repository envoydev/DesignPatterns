using AbstractFactory.Car.Engines.Base;

namespace AbstractFactory.Car.Engines
{
    public class WEngine : IEngine
    {
        public int Сylinders { get; } = 8;

        public string Type()
        {
            return $"W with {Сylinders} cylinders";
        }
    }
}
