using Decorator.Ingridients.Base;
using Decorator.Pizza.Base;

namespace Decorator.Ingridients
{
    class CheeseIngredient : IngredientsDecorator
    {
        public CheeseIngredient(BasePizza basePizza) : base(basePizza)
        {
            KindOfIngridient = "cheese";
            CostOfIngridientPerSize = 0.2;

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
