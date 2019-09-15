using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap
    {
        public double Price { get; set; }
        public uint Calories { get; set; }
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;

        public List<string> Ingredients
        {
            get
            {
                List<string> s = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (cheese) s.Add("Parmesan Cheese");
                if (dressing) s.Add("Ceasar Dressing");
                if (lettuce) s.Add("Romaine Lettuce");

                return s;
            }

        }
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }
        public void HoldLettuce() => this.lettuce = false;
        public void HoldCheese() => this.cheese = false;
        public void HoldDressing() => this.dressing = false;
    }
}