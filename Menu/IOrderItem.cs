using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IOrderItem
    {
        /// <summary>
        /// Price of IOrderItem
        /// </summary>
        double Price { get; set;  }
        /// <summary>
        /// Description of IOrderItem
        /// </summary>
        string Description { get; }
        /// <summary>
        /// Special instructions for IOrderItem
        /// </summary>
        string[] Special { get;  }
    }
}
