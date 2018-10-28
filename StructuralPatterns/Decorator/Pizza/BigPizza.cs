using Decorator.Pizza.Base;

namespace Decorator.Pizza
{
    public class BigPizza : BasePizza
    {
        public BigPizza()
        {
            Description = "Big Base";
            Size = 120;
        }

        public override double Price()
        {
            return Size * CostPerSize;
        }
    }
}
