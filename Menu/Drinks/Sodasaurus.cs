using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Sodasaurus : Drink
    {

        public double Price { get; set; }
        public uint Calories { get; set; }

        public bool Ice { get; set; }
        public Size size { get; set; }
        public List<string> Ingredients
        {
            get
            {
                return new List<string> { "Water", "Natural Flavors", "Cane Sugar" };
            }

        }
        private Flavors Flavor { get; set; }
        public Flavors flavor
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
            flavor = Flavors.Cola;
        }

        public override void holdIce()
        {
            Ice = false;
        }

        public void setFlavorToCola()
        {
            this.flavor = Flavors.Cola;
        }

        public void setFlavorToRootBeer()
        {
            this.flavor = Flavors.RootBeer;
        }
        public void setFlavorToCherry()
        {
            this.flavor = Flavors.Cherry;
        }
        public void setFlavorToVanilla()
        {
            this.flavor = Flavors.Vanilla;
        }
        public void setFlavorToChocolate()
        {
            this.flavor = Flavors.Chocolate;
        }
        public void setFlavorToLime()
        {
            this.flavor = Flavors.Lime;
        }
        public void setFlavorToOrange()
        {
            this.flavor = Flavors.Orange;
        }
        public void setFlavorToGrape()
        {
            this.flavor = Flavors.Grape;
        }

    }
}
