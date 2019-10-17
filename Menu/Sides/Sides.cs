/*  Entree.cs
*  Author: Nathan Bean
*  Modified by: Danniel Christensen
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Creates the enum to go through the sizes of sides
    /// </summary>


    public abstract class Sides : IMenuItem, IOrderItem
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

        public virtual string Description
        {
            get;
        }

        public virtual List<string> Special { get; }
    }
}
