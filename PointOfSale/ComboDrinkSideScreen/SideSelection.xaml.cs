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


namespace PointOfSale.ComboDrinkSideScreen
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
           

            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.CretaceousCombo Combo)
                {
                    Fryceritops f = new Fryceritops();
                    f.Size = Combo.Size;
                    Combo.Side = f;
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();



                }
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
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.CretaceousCombo Combo)
                {
                    Triceritots f = new Triceritots();
                    f.Size = Combo.Size;
                    Combo.Side = f;
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();



                }
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
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.CretaceousCombo Combo)
                {
                    MeteorMacAndCheese f = new MeteorMacAndCheese();
                    f.Size = Combo.Size;
                    Combo.Side = f;
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();



                }
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
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.CretaceousCombo Combo)
                {
                    MezzorellaSticks f = new MezzorellaSticks();
                    f.Size = Combo.Size;
                    Combo.Side = f;
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();



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
            this.NavigationService.Navigate(new Uri("CustomizeCombo.xaml", UriKind.Relative));
        }
    }
}
