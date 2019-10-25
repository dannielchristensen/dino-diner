using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class Jurassic Java
    /// </summary>
    public class JurassicJava : Drink, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Calories for Java
        /// </summary>
        public override uint Calories { get; set; }
        /// <summary>
        /// Price for Java
        /// </summary>
        public override double Price { get; set; }
        /// <summary>
        /// Description of java
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }
        /// <summary>
        /// Special instructions for java
        /// </summary>
        public override string[] Special
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

                return l.ToArray();

            }
        }
        /// <summary>
        /// Private backing variable for size
        /// </summary>
        private Size size { get; set; }
        /// <summary>
        /// Should have have room for cream
        /// </summary>
        public bool RoomForCream = false;
        /// <summary>
        /// Ice in java?
        /// </summary>
        public override bool Ice { get; set; } = false;
        /// <summary>
        /// Should java be decaf
        /// </summary>
        public bool Decaf = false;
        /// <summary>
        /// Creates a list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string> { "Water", "Coffee" };
            }
        }
        /// <summary>
        /// Size of java
        /// </summary>
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
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");

                        break;
                    case Size.Medium:
                        Price = .99;
                        Calories = 4;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        break;
                }

                size = value;
                NotifyOfPropertyChanged("Size");


            }
        }
        /// <summary>
        /// JurassicJava constructor
        /// </summary>
        public JurassicJava()
        {
            Price = .59;
            Calories = 2;
            Size = Size.Small;
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Calories");
            NotifyOfPropertyChanged("Size");

        }
        /// <summary>
        /// ToString for Java
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Adds Ice
        /// </summary>
        public override void AddIce()
        {
            Ice = true;
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Holds ice for Java
        /// </summary>
        public override void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChanged("Special");

        }
        /// <summary>
        /// Room for cream boolean
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;

            NotifyOfPropertyChanged("Special");

        }
        /// <summary>
        /// Makes java decaf
        /// </summary>
        public void MakeDecaf()
        {
            Decaf = true;
            NotifyOfPropertyChanged("Special");

        }
        public void MakeUndecaf()
        {
            Decaf = false;
            NotifyOfPropertyChanged("Special");

        }


    }
}
