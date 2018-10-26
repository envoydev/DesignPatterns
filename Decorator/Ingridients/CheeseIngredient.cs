using Decorator.Ingridients.Base;
using Decorator.Pizza.Base;

namespace Decorator.Ingridients
{
    class CheeseIngredient : IngredientsDecorator
    {
        private readonly BasePizza _basePizza;

        public CheeseIngredient(BasePizza basePizza)
        {
            _basePizza = basePizza;

            KindOfIngridient = "cheese";
            CostOfIngridientPerSize = 0.3;
            Size = _basePizza.Size;

            Description = string.Join(" + ", _basePizza.Discribe(), KindOfIngridient);
        }

        public override double Price()
        {
            return _basePizza.Price() + GetCostOfIngridientPerSize();
        }

        protected override double GetCostOfIngridientPerSize()
        {
            return CostOfIngridientPerSize * Size;
        }
    }
}
