using Decorator.Ingridients.Base;
using Decorator.Pizza.Base;

namespace Decorator.Ingridients
{
    class TomatoIngredient : IngredientsDecorator
    {
        private readonly BasePizza _basePizza;

        public TomatoIngredient(BasePizza basePizza)
        {
            _basePizza = basePizza;

            KindOfIngridient = "tomato";
            CostOfIngridientPerSize = 0.15;
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
