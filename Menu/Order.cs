using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    public class Order
    {
        public ObservableCollection<IOrderItem> Items { get; set; }
        public double SubtotalCost
        {

            get
            {
                double total = 0;
                foreach(IOrderItem item in Items)
                {
                    if(item.Price >0)
                         total += item.Price;
                }
                if (total < 0)
                {
                    return 0;
                }
                return total;
            }
        }

        public double SalesTaxRate
        {
            get
            {
                return this.SalesTaxRate;
            }
            private set
            {
                this.SalesTaxRate = value;
            }
        }

        public double SalesTaxCost
        {
            get
            {
                return SalesTaxRate * SubtotalCost;
            }
        }

        double TotalCost
        {
            get
            {
                return SalesTaxCost + SubtotalCost;
            }
        }
    }
}
