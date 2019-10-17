using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Water : Drink, IMenuItem, IOrderItem
    {
        public override uint Calories { get; set; }
        public override double Price { get; set; }
        private Size size {get; set;}
        public bool Lemon { get; set; }

        public bool Ice = true;
        public override List<string> Ingredients
        {
            get
            {
                List<string> l = new List<string> { "Water"};
                if (Lemon) l.Add("Lemon");
                return l;
            }

        }
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        public override List<string> Special
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
        public override Size Size
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

        public override string ToString()
        {
            return size.ToString() + " Water";
        }

        public void AddLemon()
        {
            Lemon = true;
        }
        public override void HoldIce()
        {
            Ice = false;
        }

    }
}
