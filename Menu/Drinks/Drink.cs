/*  Entree.cs
*  Author: Nathan Bean
*  Modified by: Danniel Christensen
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Creates the enum to go through the sizes of sides
    /// </summary>
    public enum Size
    {
        /// <summary>
        /// Size small for a drink
        /// </summary>
        Small,
        /// <summary>
        /// Size medium for a drink
        /// </summary>
        Medium,
        /// <summary>
        /// Size large for a drink
        /// </summary>
        Large
    }

    /// <summary>
    /// Abstract class for all members that are drinks
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// List of ingredients for the drink
        /// </summary>
        public virtual List<string> Ingredients {get;}
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public virtual double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public virtual uint Calories { get; set; }


        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }
        /// <summary>
        /// sets Ice bool to false
        /// </summary>
        public abstract void holdIce();
    }
}
