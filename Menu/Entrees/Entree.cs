/*  Entree.cs
 *  Author: Danniel Christensen
 */ 



using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace DinoDiner.Menu
{
    
    /// <summary>
    /// Abstract class to be implemted by all entrees
    /// </summary>
    public abstract class Entree : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Getter/setter for Ingredients
        /// </summary>
        public virtual List<string> Ingredients { get; }

        /// <summary>
        /// Property changed handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Method to invoke property changed
        /// </summary>
        /// <param name="propertyName">Name of property being changed</param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// Getter/Setter for price
        /// </summary>
        public virtual double Price { get; set; }

        /// <summary>
        /// Getter/Setter for Calories
        /// </summary>
        public virtual uint Calories { get; set; }
        /// <summary>
        /// Virtual get method for description
        /// </summary>
        public abstract string Description { get; }
        /// <summary>
        /// virtual get method for special
        /// </summary>
        public abstract string[] Special { get; }
    }
}
