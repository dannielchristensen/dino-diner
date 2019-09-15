using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class PterodactylWings
    {
        public double price { get; set; }
        public uint calories { get; set; }
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }

        public PterodactylWings()
        {
            this.price = 7.21;
            this.calories = 318;
        }
    }
}