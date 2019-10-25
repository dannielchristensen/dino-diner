using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using DinoDiner.Menu;




namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
{
        /// <summary>
        /// Initializes OrderControl
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Nav service
        /// </summary>
        public NavigationService ns { get; set; }

        /// <summary>
        /// Navigates and stuff
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnSelectionChanged(object sender, EventArgs args)
        {
            if(OrderBox.SelectedItem is Sides side)
            {
                ns?.Navigate(new side(side));
            }
        }

        /// <summary>
        /// removes order item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnRemoveOrderItem(object sender, EventArgs args)
        {
            if(DataContext is Order order)
            {
                if (sender is FrameworkElement element)
                {
                    if(element.DataContext is IOrderItem item)
                    {
                        order.Items.Remove(item);
                    }
                }
            }
        }
       // inside OrderControl.xaml -> orderbox -> SelectionChanged="OnSelectionChanged"


    }
}

