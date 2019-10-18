/*  MeteorMacAndCheese.cs
 *  Author: Danniel Christensen
 */

using System.Collections.Generic;
using System.ComponentModel;


namespace DinoDiner.Menu
{
    /// <summary>
    /// The MeteorMacAndCheese objects extends the Side abstract class
    /// </summary>
    public class MeteorMacAndCheese : Sides, IMenuItem, IOrderItem, INotifyPropertyChanged
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
                        Calories = 420;
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Price");
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Price");
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Price");
                        break;
                }
            }
        }
        /// <summary>
        /// Description for MacNCheese
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }
        /// <summary>
        /// Special instructions for MacNCheese
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
        /// Constructor for MeteorMacAndCheese. Sets default Calories and Price to size small.
        /// </summary>
        public MeteorMacAndCheese()
        {
            base.Calories = 420;
            base.Price = 0.99;
            NotifyOfPropertyChanged("Calories");
            NotifyOfPropertyChanged("Price");

        }
        /// <summary>
        /// ToString for MacNCheese
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size.ToString() + " Meteor Mac And Cheese";
        }

        /// <summary>
        /// Creates the list Ingredients for MeteorMacAndCheese 
        /// Overrides Ingredients in side
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
               return new List<string> { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };

            }
        }
    }
}