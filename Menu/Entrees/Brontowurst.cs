using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst
    {
        
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;
        
        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> i = new List<string>() { "brautwurst" };
                if (bun) i.Add("Whole=Wheat bun");
                if (peppers) i.Add("Peppers");
                if (onions) i.Add("Mustard");
                return i;
            }
        }

        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        public void HoldBun() => this.bun = false;
        public void HoldPeppers() => this.peppers = false;
        public void HoldOnion() => this.onions = false;

    }
}