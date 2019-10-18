/*  Triceritots.cs
*  Author: Danniel Christensen
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The Fryceritops objects extends the Side abstract class
    /// </summary>
    public class Triceritots: Sides, IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Creates Size object to hold size of object
        /// </summary>
        private Size size;

        /// <summary>
        /// Allws access to size via getter and setter
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
                        Price = 0.99;
                        Calories = 352;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        break;
                }
            }
        }
        /// <summary>
        /// Description for Triceritots
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }
        /// <summary>
        /// Special for Triceritots
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> l = new List<string>();
                return l.ToArray();
            }
        }
        /// <summary>
        /// Constructor for Triceritots. Sets default Calories and Price to size small.
        /// </summary>
        public Triceritots()
        {
            base.Calories = 352;
            base.Price = 0.99;
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Calories");

        }
        /// <summary>
        /// ToString for Triceritots
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size.ToString() + " Triceritots";
        }

        /// <summary>
        /// Creates the list Ingredients for Triceritots 
        /// Overrides Ingredients in side
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string> { "Potato", "Salt", "Vegetable Oil" };

            }
        }
    }
}
