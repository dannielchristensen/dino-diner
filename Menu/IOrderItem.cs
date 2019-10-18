using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IOrderItem
    {
        double Price { get; set;  }
        string Description { get; }

        string[] Special { get;  }
    }
}
