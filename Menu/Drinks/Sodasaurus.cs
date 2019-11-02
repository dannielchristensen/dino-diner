using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class sodasaurus
    /// </summary>
    public class Sodasaurus : Drink,  IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Price of Soda
        /// </summary>
        public override double Price { get; set; }
        /// <summary>
        /// Calories of Soda
        /// </summary>
        public override uint Calories { get; set; }
        /// <summary>
        /// Ice in Soda?
        /// </summary>
        public override bool Ice { get; set; } = true;
        /// <summary>
        /// Size of Soda
        /// </summary>
        public Size size { get; set; }
        /// <summary>
        /// Ingreidents of Soda
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string> { "Water", "Natural SodasaurusFlavor", "Cane Sugar" };
            }

        }
        /// <summary>
        /// Description for Soda
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }
        /// <summary>
        /// Special Instructions for Soda
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> l = new List<string>();
                if (!Ice)
                    l.Add("Hold Ice");

                return l.ToArray();

            }
        }
        /// <summary>
        /// private backing for soda
        /// </summary>
        private SodasaurusFlavor flavor { get; set; }
        /// <summary>
        /// flavor of soda
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value;
                NotifyOfPropertyChanged("Flavor");

            }
        }
        /// <summary>
        /// Size of soda
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                NotifyOfPropertyChanged("Size");

                switch (size)
                {
                    default:
                    case Size.Small:
                        Price = 1.5;
                        Calories = 112;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Description");

                        break;
                    case Size.Medium:
                        Price = 2;
                        Calories = 156;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Description");
                        break;
                    case Size.Large:
                        Price = 2.5;
                        Calories = 208;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Description");
                        break;
                }
            }
        }
        /// <summary>
        /// Constructor for soda 
        /// </summary>
        public Sodasaurus()
        {
            Price = 1.5;
            Calories = 112;
            Ice = true;
            size = Size.Small;
            flavor = SodasaurusFlavor.Cola;

        }
        /// <summary>
        /// Tostring for Soda
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size.ToString() + " " + flavor.ToString() + " Sodasaurus";
        }
        /// <summary>
        /// Holds ice for soda
        /// </summary>
        public override void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChanged("Special");

        }
        /// <summary>
        /// sets flavor to cola
        /// </summary>
        public void setFlavorToCola()
        {
            this.Flavor = SodasaurusFlavor.Cola;
            NotifyOfPropertyChanged("Flavor");

        }
        /// <summary>
        /// sets flavor to root beer
        /// </summary>
        public void setFlavorToRootBeer()
        {
            this.Flavor = SodasaurusFlavor.RootBeer;
            NotifyOfPropertyChanged("Flavor");

        }
        /// <summary>
        /// sets flavor to cherry
        /// </summary>
        public void setFlavorToCherry()
        {
            this.Flavor = SodasaurusFlavor.Cherry;
            NotifyOfPropertyChanged("Flavor");

        }
        /// <summary>
        /// sets flavor to vanilla
        /// </summary>
        public void setFlavorToVanilla()
        {
            this.Flavor = SodasaurusFlavor.Vanilla;
            NotifyOfPropertyChanged("Flavor");

        }
        /// <summary>
        /// sets flavor to chocolate
        /// </summary>
        public void setFlavorToChocolate()
        {
            this.Flavor = SodasaurusFlavor.Chocolate;
            NotifyOfPropertyChanged("Flavor");

        }
        /// <summary>
        /// sets flavor to lime
        /// </summary>
        public void setFlavorToLime()
        {
            this.Flavor = SodasaurusFlavor.Lime;
            NotifyOfPropertyChanged("Flavor");

        }
        /// <summary>
        /// sets flavor to orange
        /// </summary>
        public void setFlavorToOrange()
        {
            this.Flavor = SodasaurusFlavor.Orange;
            NotifyOfPropertyChanged("Flavor");

        }
        /// <summary>
        /// Sets flavor to grape
        /// </summary>
        public void setFlavorToGrape()
        {
            this.Flavor = SodasaurusFlavor.Grape;

            NotifyOfPropertyChanged("Flavor");

        }

        public override void AddIce()
        {
            Ice = true;
            NotifyOfPropertyChanged("Special");

        }

    }
}
