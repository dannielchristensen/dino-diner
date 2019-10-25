using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;


namespace DinoDiner.Menu
{
    public class Order: INotifyPropertyChanged
    {
        public ObservableCollection<IOrderItem> Items { get; } = new ObservableCollection<IOrderItem>();

        public double SubtotalCost
        {

            get
            {
                double total = 0;
                foreach (IOrderItem item in Items)
                {
                    if (item.Price > 0)
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
                return this.taxRate;
            }
            private set
            {
                this.taxRate = value;
            }
        }
        private double taxRate{ get; set;}
        public double SalesTaxCost
        {
            get
            {
                return SalesTaxRate * SubtotalCost;
            }
        }

        public double TotalCost
        {
            get
            {
                return SalesTaxCost + SubtotalCost;
            }
        }

        public Order()
        {
            SalesTaxRate = .05;
            this.Items.CollectionChanged += this.OnCollectionChanged;
        }
        public void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            NotifyOfPropertyChanged("SubtotalCost");
        }

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
    }
}
