using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst
    {
        
        private bool bun = true;
        private bool peppers = true;
        private bool mustard = true;
        
        public double price { get; set; }
        public uint calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> i = new List<string>() { "brautwurst" };
                if (bun) i.Add("Whole=Wheat bun");
                if (peppers) i.Add("Peppers");
                if (mustard) i.Add("Mustard");
                return i;
            }
        }

        public Brontowurst()
        {
            this.price = 5.36;
            this.calories = 498;
        }

        public void holdBun() => this.bun = false;
        public void holdPeppers() => this.peppers = false;
        public void holdMustard() => this.mustard = false;

    }
}