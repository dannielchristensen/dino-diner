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

        //private List<IOrderItem> items = new List<IOrderItem>();
        //public IOrderItem[] Items { get { return items.ToArray(); } }
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
            NotifyOfPropertyChanged("Items");
            NotifyOfPropertyChanged("SubtotalCost");
            NotifyOfPropertyChanged("TotalCost");
            NotifyOfPropertyChanged("SalesTaxCost");
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

        
        public void Add(IOrderItem i)
        {
            Items.Add(i);
            NotifyOfPropertyChanged("Items");
            NotifyOfPropertyChanged("SubtotalCost");
            NotifyOfPropertyChanged("TotalCost");
            NotifyOfPropertyChanged("SalesTaxCost");
        }

        public bool Remove (IOrderItem i)
        {
            bool r = Items.Remove(i);
            if (r)
            {
                NotifyOfPropertyChanged("Items");
                NotifyOfPropertyChanged("SubtotalCost");
                NotifyOfPropertyChanged("TotalCost");
                NotifyOfPropertyChanged("SalesTaxCost");
            }
            return r;
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            NotifyOfPropertyChanged("SubtotalCost");
            NotifyOfPropertyChanged("TotalCost");
            NotifyOfPropertyChanged("SalesTaxCost");

        }
        
    }
}
