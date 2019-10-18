﻿using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class representing a combo meal
    /// </summary>
    public class CretaceousCombo : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Private backing var for size
        /// </summary>
        private Size size;
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
        /// Gets and sets the entree
        /// </summary>
        public Entree Entree
        {
            get
            {
                return Entree;
            }
            set
            {
                Entree = value;
                NotifyOfPropertyChanged("Entree");
            }

        }

        /// <summary>
        /// Gets and sets the side
        /// </summary>
        public Sides Side
        {
            get
            {
                return Side;
            }
            set
            {
                Side = value;
                NotifyOfPropertyChanged("Side");
            }
        } 

        /// <summary>
        /// Gets and sets the drink
        /// </summary>
        public Drink Drink
        {
            get
            {
                return Drink;
            }
            set
            {
                Drink = value;
                NotifyOfPropertyChanged("Drink");
            }
               
        } 

        /// <summary>
        /// Gets the price of the combo
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
            set
            {

            }
        }

        /// <summary>
        /// Gets the calories of the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        /// <summary>
        /// Gets or sets the size of the combo
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Size");

            }
        }

        /// <summary>
        /// Gets the list of ingredients for the combo
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }
        /// <summary>
        /// Description of Combo
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }
        /// <summary>
        /// Special instructions for combo
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> l = new List<string>();
                l.AddRange(Entree.Special);
                l.AddRange(Side.Special);
                l.Add(Side.Description);
                l.AddRange(Drink.Special);
                l.Add(Drink.Description);

                return l.ToArray();
            }
        }


        /// <summary>
        /// Constructs a new combo with the specified entree
        /// </summary>
        /// <param name="entree">The entree to use</param>
        public CretaceousCombo(Entree entree)
        {
            this.Entree = entree;
            this.Side = new Fryceritops();
            this.Drink = new Sodasaurus();
        }

        /// <summary>
        /// ToString for Combo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Entree.ToString() + " Combo";
        }
    }
}
