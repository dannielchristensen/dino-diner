using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger
    {
        public double price { get; set; }
        public uint calories { get; set; }
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool mayo = true;

        public List<string> ingredients
        {
            get
            {
                List<string> s = new List<string>() { "3 Steakburger Patties" };
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
            this.price = 8.45;
            this.calories = 728;
        }
        public void holdBun() => this.bun = false;
        public void holdKetchup() => this.ketchup = false;
        public void holdPickle() => this.pickle = false;
        public void holdMustard() => this.mustard = false;
        public void holdLettuce() => this.lettuce = false;
        public void holdMayo() => this.mayo = false;
        public void holdOnion() => this.onion = false;
        public void holdTomato() => this.tomato = false;
    }

}