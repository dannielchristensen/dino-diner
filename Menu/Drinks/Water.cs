using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water
    {
        public uint Calories { get; set; }
        public double Price { get; set; }
        private Size size {get; set;}
        public bool Lemon { get; set; }

        public bool Ice = true;
        public List<string> Ingredients
        {
            get
            {
                List<string> l = new List<string> { "Water"};
                if (Lemon) l.Add("Lemon");
                return l;
            }

        }
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
               

                size = value;
            }
        }
        public Water()
        {
            Price = .1;
            Calories = 0;
            Size = Size.Small;
        }

        public void AddLemon()
        {
            Lemon = true;
        }
        public void HoldIce()
        {
            Ice = false;
        }

    }
}
