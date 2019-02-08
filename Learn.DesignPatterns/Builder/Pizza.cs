using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Learn.DesignPatterns.Builder
{
    public class Pizza
    {
        public IIngredient[] Ingredients { get; }

        public Pizza(IEnumerable<IIngredient> ingredients)
        {
            Ingredients = ingredients?.ToArray() ?? throw new ArgumentNullException(nameof(ingredients));
        }
    }
}
