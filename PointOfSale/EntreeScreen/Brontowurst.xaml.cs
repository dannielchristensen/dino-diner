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

namespace PointOfSale.EntreeScreen
{
    /// <summary>
    /// Interaction logic for Brontowurst.xaml
    /// </summary>
    public partial class Brontowurst : Page
    {
        public Brontowurst()
        {
            InitializeComponent();
        }

        public void ReturnToMain(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page1());
        }
        public void HoldPeppers(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.Brontowurst Entree)
                {
                    Entree.HoldPeppers();
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();

                }
            }
        }
        public void HoldOnions(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.Brontowurst Entree)
                {
                    Entree.HoldOnion();
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();

                }
            }
        }
        public void HoldBun(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.Brontowurst Entree)
                {
                    Entree.HoldBun();
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();

                }
            }
        }

    }
}
