using AbstractFactory.Car.Carcases.Base;

namespace AbstractFactory.Car.Carcases
{
    public class HatchbackBody : IBody
    {
        public int AmountDors { get; } = 5;

        public string Type()
        {
            return $"Hatchback with {AmountDors} dors";
        }
    }
}
