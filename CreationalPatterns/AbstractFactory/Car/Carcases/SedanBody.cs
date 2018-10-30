using AbstractFactory.Car.Carcases.Base;

namespace AbstractFactory.Car.Carcases
{
    public class SedanBody : IBody
    {
        public int AmountDors { get; } = 4;

        public string Type()
        {
            return $"Sedan with {AmountDors} dors";
        }
    }
}
