using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Sides;
using DinoDiner.Menu.Entrees;

namespace DinoDiner.Menu
{
    public class CretaceousCombo
    {
        /// <summary>
        /// Gets and sets teh entree
        /// </summary>
        public Entree Entree { get; set; }
        /// <summary>
        /// gets and sets the side
        /// </summary>
        public Side Side { get; set; }
        /// <summary>
        /// gets and sets the drink
        /// </summary>
        public Drink Drink { get; set; }
    }
}
