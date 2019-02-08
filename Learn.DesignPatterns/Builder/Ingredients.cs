using System;
using System.Collections.Generic;
using System.Text;

namespace Learn.DesignPatterns.Builder
{
    public class Pepperoni : IIngredient
    {
        public string Name => nameof(Pepperoni);
    }

    public class Tomato : IIngredient
    {
        public string Name => nameof(Tomato);
    }

    public class Salt : IIngredient
    {
        public string Name => nameof(Salt);
    }

    public class Pepper : IIngredient
    {
        public string Name => nameof(Pepper);
    }

    public class Cheese : IIngredient
    {
        public string Name => nameof(Cheese);
    }
}
