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

namespace PointOfSale.ComboEntreeScreen
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
            this.NavigationService.Navigate(new Uri("CustomizeCombo.xaml", UriKind.Relative));
        }
        public void HoldPickle(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.CretaceousCombo Combo)
                {
                    DinoDiner.Menu.TRexKingBurger b = (DinoDiner.Menu.TRexKingBurger)Combo.Entree;
                    b.HoldPickle();
                    Combo.Entree = b;
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();
                }
            }
        }
        public void HoldMustard(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.CretaceousCombo Combo)
                {
                    DinoDiner.Menu.TRexKingBurger b = (DinoDiner.Menu.TRexKingBurger)Combo.Entree;
                    b.HoldMustard();
                    Combo.Entree = b;
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();
                }
            }
        }
        public void HoldKetchup(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.CretaceousCombo Combo)
                {
                    DinoDiner.Menu.TRexKingBurger b = (DinoDiner.Menu.TRexKingBurger)Combo.Entree;
                    b.HoldKetchup();
                    Combo.Entree = b;
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();
                }
            }
        }
        public void HoldMayo(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.CretaceousCombo Combo)
                {
                    DinoDiner.Menu.TRexKingBurger b = (DinoDiner.Menu.TRexKingBurger)Combo.Entree;
                    b.HoldMayo();
                    Combo.Entree = b;
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();
                }
            }
        }
        public void HoldLettuce(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.CretaceousCombo Combo)
                {
                    DinoDiner.Menu.TRexKingBurger b = (DinoDiner.Menu.TRexKingBurger)Combo.Entree;
                    b.HoldLettuce();
                    Combo.Entree = b;
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();
                }
            }
        }
        public void HoldOnion(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.CretaceousCombo Combo)
                {
                    DinoDiner.Menu.TRexKingBurger b = (DinoDiner.Menu.TRexKingBurger)Combo.Entree;
                    b.HoldOnion();
                    Combo.Entree = b;
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();
                }
            }
        }
        public void HoldTomato(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.CretaceousCombo Combo)
                {
                    DinoDiner.Menu.TRexKingBurger b = (DinoDiner.Menu.TRexKingBurger)Combo.Entree;
                    b.HoldTomato();
                    Combo.Entree = b;
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();
                }
            }
        }
        public void HoldBun(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.CretaceousCombo Combo)
                {
                    DinoDiner.Menu.TRexKingBurger b = (DinoDiner.Menu.TRexKingBurger)Combo.Entree;
                    b.HoldBun();
                    Combo.Entree = b;
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();
                }
            }
        }
    }
}
