/*  MeteorMacAndCheese.cs
 *  Author: Danniel Christensen
 */

using System.Collections.Generic;


namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// The MeteorMacAndCheese objects extends the Side abstract class
    /// </summary>
    public class MeteorMacAndCheese : Side
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
                        Calories = 420;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        break;
                }
            }
        }
        /// <summary>
        /// Constructor for MeteorMacAndCheese. Sets default Calories and Price to size small.
        /// </summary>
        public MeteorMacAndCheese()
        {
            base.Calories = 420;
            base.Price = 0.99;


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