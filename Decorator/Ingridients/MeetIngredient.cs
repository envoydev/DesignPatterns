using Decorator.Ingridients.Base;
using Decorator.Pizza.Base;

namespace Decorator.Ingridients
{
    class MeetIngredient : IngredientsDecorator
    {
        private readonly BasePizza _basePizza;

        public MeetIngredient(BasePizza basePizza)
        {
            _basePizza = basePizza;

            KindOfIngridient = "meet";
            CostOfIngridientPerSize = 0.8;
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
