namespace AbstractFactory.Car.Engines.Base
{
    public interface IEngine
    {
        int Сylinders { get; }
        string Type();
    }
}
