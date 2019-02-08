using Learn.DesignPatterns.Builder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Learn.DesignPatterns.Test
{
    [TestClass]
    public class BuilderTest
    {
        [TestMethod]
        public void BuildTest()
        {
            PizzaBuilder pizzaBuilder = new PizzaBuilder();
            Pizza pizza = pizzaBuilder
                .AddTomato()
                .AddPepper()
                .AddPepperoni()
                .Create();

            Assert.IsTrue(pizza.Ingredients.Any(ingredient => ingredient.Name == nameof(Tomato)));
            Assert.IsTrue(pizza.Ingredients.Any(ingredient => ingredient.Name == nameof(Pepper)));
            Assert.IsTrue(pizza.Ingredients.Any(ingredient => ingredient.Name == nameof(Pepperoni)));
        }
    }
}
