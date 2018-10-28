using Decorator.Ingridients;
using Decorator.Pizza;
using Decorator.Pizza.Base;
using System;

namespace Decorator
{
    class Program
    {
        //The main idea of decorator pattern is that you create wrappers that add your base class new features

        static void Main(string[] args)
        {
            //Bases of pizza
            MakePizza(new SmallPizza());
            MakePizza(new MediumPizza());
            MakePizza(new BigPizza());

            //Add small pizza with Tomato and Cheese ingredients
            MakePizza(new TomatoIngredient(new CheeseIngredient(new SmallPizza())));
            //Add medium pizza with Tomato and Cheese ingredients
            MakePizza(new TomatoIngredient(new CheeseIngredient(new MediumPizza())));
            //Add big with Meet ingredient
            MakePizza(new MeetIngredient(new BigPizza()));

        }

        static void MakePizza(BasePizza pizza)
        {
            Console.WriteLine(pizza.Discribe());
            Console.WriteLine(pizza.Price());
            Console.WriteLine("-------------------");
        }
    }
}
