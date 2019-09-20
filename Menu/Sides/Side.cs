/*  Entree.cs
*  Author: Nathan Bean
*  Modified by: Danniel Christensen
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Creates the enum to go through the sizes of sides
    /// </summary>
    public enum Size
    {
        /// <summary>
        /// Size small for a side
        /// </summary>
        Small,
        /// <summary>
        /// Size medium for a side
        /// </summary>
        Medium,
        /// <summary>
        /// Size large for a side
        /// </summary>
        Large
    }

    public abstract class Side
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public virtual double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public virtual uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

    }
}
