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
    /// Abstract class for all members that are drinks
    /// </summary>
    public abstract class Drink : IMenuItem, IOrderItem, INotifyPropertyChanged
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
        /// Field for Property Changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Method to call/notify property changed
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public virtual uint Calories { get; set; }


        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }
        public virtual string Description { get; }
        public virtual string[] Special { get; }

        /// <summary>
        /// sets Ice bool to false
        /// </summary>
        public abstract void HoldIce();
    }
}
