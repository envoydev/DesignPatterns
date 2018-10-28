using Decorator.Ingridients.Base;
using Decorator.Pizza.Base;

namespace Decorator.Ingridients
{
    class TomatoIngredient : IngredientsDecorator
    {
        public TomatoIngredient(BasePizza basePizza) : base(basePizza)
        {
            KindOfIngridient = "tomato";
            CostOfIngridientPerSize = 0.13;
            Size = BasePizza.Size;

            Description = string.Join(" + ", BasePizza.Discribe(), KindOfIngridient);
        }

        public override double Price()
        {
            return BasePizza.Price() + GetCostOfIngridientPerSize();
        }

        protected override double GetCostOfIngridientPerSize()
        {
            return CostOfIngridientPerSize * Size;
        }
    }
}
