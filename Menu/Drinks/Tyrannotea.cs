using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Tyrannotea : Drink, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Field for price
        /// </summary>
        public override double Price { get; set; }
        /// <summary>
        /// Field for calories
        /// </summary>
        public override uint Calories { get; set; }
        /// <summary>
        /// Field for size
        /// </summary>
        private Size size { get; set; }
        /// <summary>
        /// Field for Ice
        /// </summary>
        public override bool Ice { get; set; } = true;
        /// <summary>
        /// Field for Lemon
        /// </summary>
        public bool Lemon { get; set; }
        /// <summary>
        /// Field for sweet
        /// </summary>
        public bool Sweet { get; set; }
        /// <summary>
        /// Provides description fo Tyrannotea
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }
        /// <summary>
        /// Provides special instructions for Tyrannotea
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> l = new List<string>();
                if (!Ice)
                    l.Add("Hold Ice");
                if (Lemon)
                    l.Add("Add Lemon");
                return l.ToArray();

            }
        }
        /// <summary>
        /// Ingredients for Tyrannotea
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> l = new List<string> { "Water", "Tea" };
                if(Lemon) l.Add("Lemon");
                if (Sweet) l.Add("Cane Sugar");
                return l;
            }

        }
        /// <summary>
        /// Size of tyrannotea
        /// </summary>
        public override Size Size
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
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Description");
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        if (Sweet) Calories = 32;
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Description");
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        if (Sweet) Calories = 64;
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Description");
                        break;
                }

                size = value;
                NotifyOfPropertyChanged("Size");
            }
        }
        /// <summary>
        /// Tyrannotea constructor
        /// </summary>
        public Tyrannotea()
        {
            Lemon = false;
            Sweet = false;
            Ice = true;
            size = Size.Small;
            Price = .99;
            Calories = 8;
            
        }
        /// <summary>
        /// Tostring for Tyrannotea
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Holds Ice
        /// </summary>
        public override void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Makes tea sweet, also multiplies calories by 2
        /// </summary>
        public void MakeSweet()
        {
            Sweet = true;
            Calories *= 2;
            NotifyOfPropertyChanged("Calories");
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Description");



        }
        /// <summary>
        /// makes tea unsweet
        /// </summary>
        public void MakeUnSweet()
        {
            Sweet = false;
            Calories /= 2;
            NotifyOfPropertyChanged("Calories");
           // NotifyOfPropertyChanged("Ingredients"); errors out due to way it is set up
            NotifyOfPropertyChanged("Description");

        }
        /// <summary>
        /// Adds Lemon
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Ingredients");

        }
        public void HoldLemon()
        {
            Lemon = false;
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Ingredients");

        }
        public override void AddIce()
        {
            Ice = true;
            NotifyOfPropertyChanged("Special");

        }
    }
}
