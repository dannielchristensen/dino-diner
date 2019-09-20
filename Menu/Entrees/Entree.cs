/*  Entree.cs
 *  Author: Danniel Christensen
 */ 



using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Abstract class to be implemted by all entrees
    /// </summary>
    public abstract class Entree
    {
        /// <summary>
        /// Getter/setter for Ingredients
        /// </summary>
        public virtual List<string> Ingredients { get; }

        /// <summary>
        /// Getter/Setter for price
        /// </summary>
        public virtual double Price { get; set; }

        /// <summary>
        /// Getter/Setter for Calories
        /// </summary>
        public virtual uint Calories { get; set; }

    }
}
