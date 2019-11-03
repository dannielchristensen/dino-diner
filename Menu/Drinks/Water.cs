using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Water : Drink, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Calories for Water
        /// </summary>
        public override uint Calories { get; set; }
        /// <summary>
        /// Price for water
        /// </summary>
        public override double Price { get; set; }
        /// <summary>
        /// Size of Water
        /// </summary>
        private Size size {get; set;}
        /// <summary>
        /// Is there lemon
        /// </summary>
        public bool Lemon { get; set; }
        /// <summary>
        /// Is there ice, default true
        /// </summary>

        public override bool Ice { get; set; } = true;
        /// <summary>
        /// Gets list of Ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> l = new List<string> { "Water"};
                if (Lemon) l.Add("Lemon");
                return l;
            }

        }
        /// <summary>
        /// Description for water
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }
        /// <summary>
        /// Special instructions for water
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
        /// Size of water
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
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Price");


            }
        }
        /// <summary>
        /// Constructor for water
        /// </summary>
        public Water()
        {
            Price = .1;
            Calories = 0;
            Size = Size.Small;
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Calories");
            NotifyOfPropertyChanged("Size");
        }
        /// <summary>
        /// ToString for water
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size.ToString() + " Water";
        }
        /// <summary>
        /// Adds lemon to water
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            NotifyOfPropertyChanged("Special");
            //NotifyOfPropertyChanged("Ingredients"); errors out? says it needs to be set but thats not how ours is set up

        }
        /// <summary>
        /// Removes ice
        /// </summary>
        public override void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChanged("Special");
        }
        public override void AddIce()
        {
            Ice = true;
            NotifyOfPropertyChanged("Special");
        }
        public void HoldLemon()
        {
            Lemon = false;
            NotifyOfPropertyChanged("Special");

        }

    }
}
