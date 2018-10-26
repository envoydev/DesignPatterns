using Decorator.Pizza.Base;

namespace Decorator.Ingridients.Base
{
    public abstract class IngredientsDecorator : BasePizza
    {
        protected double CostOfIngridientPerSize { get; set; }
        protected string KindOfIngridient { get; set; }

        public IngredientsDecorator()
        {
            CostOfIngridientPerSize = default(double);
            KindOfIngridient = string.Empty;
        }

        protected abstract double GetCostOfIngridientPerSize();
    }
}
