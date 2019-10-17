using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Sodasaurus : Drink,  IMenuItem, IOrderItem
    {

        public double Price { get; set; }
        public uint Calories { get; set; }

        public bool Ice { get; set; }
        public Size size { get; set; }
        public List<string> Ingredients
        {
            get
            {
                return new List<string> { "Water", "Natural SodasaurusFlavor", "Cane Sugar" };
            }

        }
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

                return l;

            }
        }
        private SodasaurusFlavor flavor { get; set; }
        public SodasaurusFlavor Flavor
        {
            get { return Flavor; }
            set { Flavor = value; }
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
                switch (size)
                {
                    default:
                    case Size.Small:
                        Price = 1.5;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.5;
                        Calories = 208;
                        break;
                }
            }
        }
        public Sodasaurus()
        {
            Price = 1.5;
            Calories = 112;
            Ice = true;
            size = Size.Small;
            flavor = SodasaurusFlavor.Cola;
        }

        public override string ToString()
        {
            return size.ToString() + " " + flavor.ToString() + " Sodasaurus";
        }

        public override void HoldIce()
        {
            Ice = false;
        }

        public void setFlavorToCola()
        {
            this.Flavor = SodasaurusFlavor.Cola;
        }

        public void setFlavorToRootBeer()
        {
            this.Flavor = SodasaurusFlavor.RootBeer;
        }
        public void setFlavorToCherry()
        {
            this.Flavor = SodasaurusFlavor.Cherry;
        }
        public void setFlavorToVanilla()
        {
            this.Flavor = SodasaurusFlavor.Vanilla;
        }
        public void setFlavorToChocolate()
        {
            this.Flavor = SodasaurusFlavor.Chocolate;
        }
        public void setFlavorToLime()
        {
            this.Flavor = SodasaurusFlavor.Lime;
        }
        public void setFlavorToOrange()
        {
            this.Flavor = SodasaurusFlavor.Orange;
        }
        public void setFlavorToGrape()
        {
            this.Flavor = SodasaurusFlavor.Grape;
        }

    }
}
