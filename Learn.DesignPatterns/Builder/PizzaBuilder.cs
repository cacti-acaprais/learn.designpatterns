using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Learn.DesignPatterns.Builder
{
    public class PizzaBuilder
    {
        IIngredient[] _ingredients;

        public PizzaBuilder()
            : this(new IIngredient[0])
        {

        }

        private PizzaBuilder(IEnumerable<IIngredient> ingredients)
        {
            _ingredients = ingredients.ToArray();
        }

        public PizzaBuilder AddTomato()
            => new PizzaBuilder(_ingredients.Concat(new[] {
                new Tomato()
            }));

        public PizzaBuilder AddPepperoni()
            => new PizzaBuilder(_ingredients.Concat(new[] {
                new Pepperoni()
            }));

        public PizzaBuilder AddPepper()
            => new PizzaBuilder(_ingredients.Concat(new[] {
                new Pepper()
            }));

        public Pizza Create()
            => new Pizza(_ingredients);
    }
}
