using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class JurassicJava : Drink, IMenuItem, IOrderItem
    {
        public override uint Calories { get; set; }
        public override double Price { get; set; }

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
                if (Ice)
                    l.Add("Add Ice");
                if (RoomForCream)
                    l.Add("Leave room for Cream");
                if (Decaf)
                    l.Add("Make Decaf");

                return l;

            }
        }
        private Size size { get; set; }

        public bool RoomForCream = false;

        public bool Ice = false;

        public bool Decaf = false;
        public override List<string> Ingredients
        {
            get
            {
                return new List<string> { "Water", "Coffee" };
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
                switch (value)
                {
                    default:
                    case Size.Small:
                        Price = .59;
                        Calories = 2;
                        break;
                    case Size.Medium:
                        Price = .99;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        break;
                }

                size = value;
            }
        }

        public JurassicJava()
        {
            Price = .59;
            Calories = 2;
            Size = Size.Small;

        }

        public override string ToString()
        {
            if (Decaf)
            {
                return size.ToString() + " Decaf Jurassic Java";
            }
            else
            {
                return size.ToString() + " Jurassic Java";
            }
        }

        public void AddIce()
        {
            Ice = true;
        }

        public override void HoldIce()
        {
            Ice = false;
        }
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }

        public void MakeDecaf()
        {
            Decaf = true;
        }
    }
}
