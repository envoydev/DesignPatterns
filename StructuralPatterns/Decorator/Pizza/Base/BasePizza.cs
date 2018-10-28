namespace Decorator.Pizza.Base
{
    public abstract class BasePizza
    {
        protected double CostPerSize { get; }
        protected string Description { get; set; }
        public int Size { get; protected set; }

        public BasePizza()
        {
            CostPerSize = 1.0;
            Description = string.Empty;
            Size = default(int);
        }

        public string Discribe()
        {
            return Description;
        }

        public abstract double Price();
    }
}
