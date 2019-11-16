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
    /// Interaction logic for TRexKingBurger.xaml
    /// </summary>
    public partial class TRexKingBurger : Page
    {
        public TRexKingBurger()
        {
            InitializeComponent();
        }
        public void ReturnToMain(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page1());
        }
        public void HoldPickle(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.TRexKingBurger Entree)
                {
                    Entree.HoldPickle();
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();

                }
            }
        }
        public void HoldMustard(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.TRexKingBurger Entree)
                {
                    Entree.HoldMustard();
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();

                }
            }
        }
        public void HoldKetchup(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.TRexKingBurger Entree)
                {
                    Entree.HoldKetchup();
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();

                }
            }
        }
        public void HoldMayo(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.TRexKingBurger Entree)
                {
                    Entree.HoldMayo();
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();

                }
            }
        }
        public void HoldLettuce(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.TRexKingBurger Entree)
                {
                    Entree.HoldLettuce();
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();

                }
            }
        }
        public void HoldOnion(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.TRexKingBurger Entree)
                {
                    Entree.HoldOnion();
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();

                }
            }
        }
        public void HoldTomato(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.TRexKingBurger Entree)
                {
                    Entree.HoldTomato();
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();

                }
            }
        }
        public void HoldBun(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.TRexKingBurger Entree)
                {
                    Entree.HoldBun();
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();

                }
            }
        }
    }
}
