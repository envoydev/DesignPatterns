using AbstractFactory.Car.Carcases.Base;

namespace AbstractFactory.Car.Carcases
{
    public class CoupeBody : IBody
    {
        public int AmountDors { get; } = 2;

        public string Type()
        {
            return $"Coupe with {AmountDors} dors";
        }
    }
}
