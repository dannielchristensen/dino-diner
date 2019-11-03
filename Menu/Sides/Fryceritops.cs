/*  Fryceritops.cs
 *  Author: Danniel Christensen
 */

using System.Collections.Generic;
using System.ComponentModel;


namespace DinoDiner.Menu
{
    /// <summary>
    /// The Fryceritops objects extends the Side abstract class
    /// </summary>
    public class Fryceritops: Sides, IMenuItem, IOrderItem, INotifyPropertyChanged
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
                switch (size)
                {
                    default:
                    case Size.Small:
                        Price = 0.99;
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        

                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                }
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Size");

            }
        }
        /// <summary>
        /// Description of Fryceritops
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }
        /// <summary>
        /// Special for Fryceritops
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
        /// Constructor for Fryceritops. Sets default Calories and Price to size small.
        /// </summary>
        public Fryceritops()
        {
            base.Calories = 222;
            base.Price = 0.99;

        }
        

        /// <summary>
        /// ToString for Fryceritops
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size.ToString() + " Fryceritops";
        }
        /// <summary>
        /// Creates the list Ingredients for Fryceritops 
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