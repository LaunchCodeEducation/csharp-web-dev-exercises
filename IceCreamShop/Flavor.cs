using System;

namespace IceCreamShop
{
    public class Flavor : Ingredient
    {
        public Flavor(string name, double cost, List<string> allergens) : base(name, cost, allergens)
        {
        }
    }
}

