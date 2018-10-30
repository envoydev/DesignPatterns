namespace AbstractFactory.Car.Carcases.Base
{
    public interface IBody
    {
        int AmountDors { get; }
        string Type();
    }
}
