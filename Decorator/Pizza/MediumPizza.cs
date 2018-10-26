using Decorator.Pizza.Base;

namespace Decorator.Pizza
{
    public class MediumPizza : BasePizza
    {
        public MediumPizza()
        {
            Description = "Medium base";
            Size = 60;
        }

        public override double Price()
        {
            return Size * CostPerSize;
        }
    }
}
