/* SideSelection.xaml.cs
*   Author: Danniel Christensen
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;
using System.ComponentModel;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for side.xaml
    /// </summary>
    public partial class side : Page
    {
        /// <summary>
        /// Creates side screen
        /// </summary>
        public side()
        {
            InitializeComponent();
        }

        /// <summary>
        /// New constructor for Side to work
        /// </summary>
        /// <param name="side"></param>
        public side(Sides side)
        {
            InitializeComponent();
            DataContext = side;

        }

      

        
        /// <summary>
        /// adds fries items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AddFryceritops(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                Sides side = new Fryceritops();
                order.Items.Add(side);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
            
        }

        /// <summary>
        /// adds triceritots to items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AddTriceritots(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                Sides side = new Triceritots();
                order.Items.Add(side);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }

        }

        /// <summary>
        /// Adds mac n cheese to items list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AddMeteorMacAndCheese(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                Sides side = new MeteorMacAndCheese();
                order.Items.Add(side);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }

        }

        /// <summary>
        /// Adds Mezzorella sticks to items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AddMezzorellaSticks(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                Sides side = new MezzorellaSticks();
                order.Items.Add(side);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }

        }

        /// <summary>
        /// Sets size to large for selected object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MakeLarge(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                if(CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.Sides side)
                {
                    SetSize(DinoDiner.Menu.Size.Large);
                }
            }
        }

        /// <summary>
        /// Sets size to medium for selected object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MakeMedium(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.Sides side)
                {
                    SetSize(DinoDiner.Menu.Size.Medium);

                }
            }
        }

        /// <summary>
        /// Sets size to small for selected object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MakeSmall(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.Sides side)
                {
                    SetSize(DinoDiner.Menu.Size.Small);

                }
            }
        }

        

        /// <summary>
        /// helper function to set size to selected value
        /// </summary>
        /// <param name="size"></param>
        private void SetSize(DinoDiner.Menu.Size size)
        {
            if(DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sides side)
                {
                    side.Size = size;
                    //OrderBox.Items
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();
                    order.OnCollectionChanged(null, null);


                }
            }
        }
        /// <summary>
        /// Click event for done button. returns to main
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ReturnToMain(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page1());
        }
    }
}
