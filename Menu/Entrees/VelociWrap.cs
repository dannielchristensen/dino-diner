using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap
    {
        public double price { get; set; }
        public uint calories { get; set; }
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;

        public List<string> ingredients
        {
            get
            {
                List<string> s = new List<string>() { "Flour Tortilla", "Chicken" };
                if (cheese) s.Add("Parmesan");
                if (dressing) s.Add("Ceasar Dressing");
                if (lettuce) s.Add("Romaine Lettuce");

                return s;
            }

        }

        public void holdLettuce() => this.lettuce = false;
        public void holdCheese() => this.cheese = false;
        public void holdDressing() => this.dressing = false;
    }
}