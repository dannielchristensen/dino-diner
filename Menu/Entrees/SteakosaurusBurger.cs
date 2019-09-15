using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class SteakosaurusBurger
    {
        public double Price { get; set; }
        public uint Calories { get; set; }

        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;

        public List<string> Ingredients
        {
            get
            {
                List<string> s = new List<string>() { "Steakburger Pattie" };
                if (bun) s.Add("Whole Wheat Bun");
                if (pickle) s.Add("Pickle");
                if (ketchup) s.Add("Ketchup");
                if (mustard) s.Add("Mustard");
                return s;
            }

        }

        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }
        public void HoldBun() => this.bun = false;
        public void HoldKetchup() => this.ketchup = false;
        public void HoldPickle() => this.pickle = false;
        public void HoldMustard() => this.mustard = false;



    }
}