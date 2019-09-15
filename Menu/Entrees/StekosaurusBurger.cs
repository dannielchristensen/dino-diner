using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class StekosaurusBurger
    {
        public double price { get; set; }
        public uint calories { get; set; }

        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;

        public List<string> ingredients{
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

        public StekosaurusBurger()
        {
            this.price = 5.15;
            this.calories = 621;
        }
        public void holdBun() => this.bun = false;
        public void holdKetchup() => this.ketchup = false;
        public void holdPickle() => this.pickle = false;
        public void holdMustard() => this.mustard = false;



    }
}