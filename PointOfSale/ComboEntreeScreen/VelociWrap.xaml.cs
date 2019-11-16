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
    /// Interaction logic for VelociWrap.xaml
    /// </summary>
    public partial class VelociWrap : Page
    {
        public VelociWrap()
        {
            InitializeComponent();
        }

        public void ReturnToMain(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("CustomizeCombo.xaml", UriKind.Relative));
        }
        public void HoldDressing(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.CretaceousCombo Combo)
                {
                    DinoDiner.Menu.VelociWrap b = (DinoDiner.Menu.VelociWrap)Combo.Entree;
                    b.HoldDressing();
                    Combo.Entree = b;
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();
                }
            }
        }
        public void HoldCheese(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.CretaceousCombo Combo)
                {
                    DinoDiner.Menu.VelociWrap b = (DinoDiner.Menu.VelociWrap)Combo.Entree;
                    b.HoldCheese();
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
                    DinoDiner.Menu.VelociWrap b = (DinoDiner.Menu.VelociWrap)Combo.Entree;
                    b.HoldLettuce();
                    Combo.Entree = b;
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();
                }
            }
        }
    }
}
