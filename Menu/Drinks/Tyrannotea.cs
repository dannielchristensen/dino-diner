using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Tyrannotea : Drink, IMenuItem, IOrderItem
    {
        public double Price { get; set; }
        public uint Calories { get; set; }

        public bool Ice { get; set; }
        private Size size { get; set; }

        public bool Lemon { get; set; }

        public bool Sweet { get; set; }
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }

        public List<string> Special
        {
            get
            {
                List<string> l = new List<string>();
                if (!Ice)
                    l.Add("Hold Ice");
                if (Lemon)
                    l.Add("Add Lemon");
                return l;

            }
        }
        public List<string> Ingredients
        {
            get
            {
                List<string> l = new List<string> { "Water", "Tea" };
                if(Lemon) l.Add("Lemon");
                if (Sweet) l.Add("Cane Sugar");
                return l;
            }

        }
        
        public Size Size
        {
            get {
                return size;
            }
            set
            {
                switch (value)
                {
                    default:
                    case Size.Small:
                        Price = .99;
                        Calories = 8;
                        if (Sweet) Calories = 16;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        if (Sweet) Calories = 32;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        if (Sweet) Calories = 64;
                        break;
                }

                size = value;
            }
        }
        public Tyrannotea()
        {
            Lemon = false;
            Sweet = false;
            Ice = false;
            size = Size.Small;
            Price = .99;
            Calories = 8;
            
        }

        public override string ToString()
        {
            if (Sweet)
            {
                return size.ToString() + " Sweet Tyrannotea";
            }
            else
            {
                return size.ToString() + " Tyrannotea";
            }
        }
        public override void HoldIce()
        {
            Ice = false;
        }

        public void MakeSweet()
        {
            Sweet = true;
            Calories *= 2;
        }
        public void MakeUnSweet()
        {
            Sweet = false;
            Calories /= 2;
        }

        public void AddLemon()
        {
            Lemon = true;
        }

        
    }
}
