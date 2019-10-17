/*  VelociWrap.cs
 *  Author: Danniel Christensen
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The VelociWrap objects extends the Entree abstract class
    /// </summary>
    public class VelociWrap : Entree, IMenuItem, IOrderItem
    {
        /// <summary>
        /// Allws access to Price via getter and setter
        /// </summary>
        public override double Price { get; set; }

        /// <summary>
        /// Allws access to Calories via getter and setter
        /// </summary>
        public override uint Calories { get; set; }

        /// <summary>
        /// Initializes the bool dressing to true to show that there is a dressing in a normal order
        /// </summary>
        private bool dressing = true;

        /// <summary>
        /// Initializes the lettuce dressing to true to show that there is a lettuce in a normal order
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// Initializes the bool cheese to true to show that there is a cheese in a normal order
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// List containing the ingredients of the VelociWrap using bools
        /// </summary>

        public override List<string> Ingredients
        {
            get
            {
                List<string> s = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (cheese) s.Add("Parmesan Cheese");
                if (dressing) s.Add("Ceasar Dressing");
                if (lettuce) s.Add("Romaine Lettuce");

                return s;
            }

        }
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        public override List<string> Special
        {
            get
            {
                List<string> l = new List<string>();
                if (!cheese)
                    l.Add("Hold Cheese");
                if (!dressing)
                    l.Add("Hold Dressing");
                if (!lettuce)
                    l.Add("Hold Lettuce");

                return l;

            }
        }
        /// <summary>
        /// Initializes the value of a VelociWrap and its price/calories to small
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        public override string ToString()
        {
            return "Veloci-Wrap";
        }

        /// <summary>
        /// Sets lettuce to false to show that there is no lettuce
        /// </summary>
        public void HoldLettuce() => this.lettuce = false;

        /// <summary>
        /// Sets cheese to false to show that there is no cheese
        /// </summary>
        public void HoldCheese() => this.cheese = false;

        /// <summary>
        /// Sets dressing to false to show that there is no dressing
        /// </summary>
        public void HoldDressing() => this.dressing = false;
    }
}