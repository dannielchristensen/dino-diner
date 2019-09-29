using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava
    {
        public uint Calories { get; set; }
        public double Price { get; set; }

        private Size size { get; set; }

        public bool RoomForCream = false;

        public bool Ice = false;

        public bool decaf = false;
        public List<string> Ingredients
        {
            get
            {
                return new List<string> { "Water", "Coffee" };
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

        public JurrasicJava()
        {
            Price = .59;
            Calories = 2;
            Size = Size.Small;

        }

        public void AddIce()
        {
            Ice = true;
        }

        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }

        public void MakeDecaf()
        {
            decaf = true;
        }
    }
}
