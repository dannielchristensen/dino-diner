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

        public event PropertyChangedEventHandler PropertyChanged;

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

        public abstract string Description { get; }

        public abstract List<string> Special { get; }
    }
}
