using Decorator.Pizza.Base;

namespace Decorator.Ingridients.Base
{
    public abstract class IngredientsDecorator : BasePizza
    {
        protected BasePizza BasePizza { get; }

        protected double CostOfIngridientPerSize { get; set; }
        protected string KindOfIngridient { get; set; }

        public IngredientsDecorator(BasePizza basePizza)
        {
            BasePizza = basePizza;

            CostOfIngridientPerSize = default(double);
            KindOfIngridient = string.Empty;
            Size = basePizza.Size;
        }

        protected abstract double GetCostOfIngridientPerSize();
    }
}
