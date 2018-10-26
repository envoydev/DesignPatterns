using Decorator.Pizza.Base;

namespace Decorator.Pizza
{
    public class SmallPizza : BasePizza
    {
        public SmallPizza()
        {
            Description = "Small base";
            Size = 30;
        }

        public override double Price()
        {
            return Size * CostPerSize;
        }
    }
}
