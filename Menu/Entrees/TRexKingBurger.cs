using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger
    {
        public double Price { get; set; }
        public uint Calories { get; set; }
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool mayo = true;

        public List<string> Ingredients
        {
            get
            {
                List<string> s = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (bun) s.Add("Whole Wheat Bun");
                if (pickle) s.Add("Pickle");
                if (ketchup) s.Add("Ketchup");
                if (mustard) s.Add("Mustard");
                if (onion) s.Add("Onion");
                if (mayo) s.Add("Mayo");
                if (lettuce) s.Add("Lettuce");
                if (tomato) s.Add("Tomato");

                return s;
            }

        }

        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }
        public void HoldBun() => this.bun = false;
        public void HoldKetchup() => this.ketchup = false;
        public void HoldPickle() => this.pickle = false;
        public void HoldMustard() => this.mustard = false;
        public void HoldLettuce() => this.lettuce = false;
        public void HoldMayo() => this.mayo = false;
        public void HoldOnion() => this.onion = false;
        public void HoldTomato() => this.tomato = false;
    }

}