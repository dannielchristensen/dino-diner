/*  Entree.cs
*  Author: Nathan Bean
*  Modified by: Danniel Christensen
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Creates the enum to go through the sizes of sides
    /// </summary>


    public abstract class Sides : IMenuItem, IOrderItem, INotifyPropertyChanged
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
        /// Handler for Changing properties
        /// </summary>

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// method to notify that property has changed
        /// </summary>
        /// <param name="propertyName">Name of changed property</param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Virtual get method for description
        /// </summary>
        public virtual string Description
        {
            get;
        }
        /// <summary>
        /// virtual get method for special
        /// </summary>
        public virtual string[] Special { get; }
    }
}
