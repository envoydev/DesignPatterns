using AbstractFactory.Car.Engines.Base;

namespace AbstractFactory.Car.Engines
{
    public class InlineEngine : IEngine
    {
        public int Сylinders { get; } = 4;

        public string Type()
        {
            return $"Inline with {Сylinders} cylinders";
        }
    }
}
