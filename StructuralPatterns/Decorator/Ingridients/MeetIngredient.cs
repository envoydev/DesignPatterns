using Decorator.Ingridients.Base;
using Decorator.Pizza.Base;

namespace Decorator.Ingridients
{
    class MeetIngredient : IngredientsDecorator
    {
        public MeetIngredient(BasePizza basePizza) : base(basePizza)
        {
            KindOfIngridient = "meet";
            CostOfIngridientPerSize = 0.3;
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
