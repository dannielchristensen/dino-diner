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
    /// Interaction logic for DinoNuggets.xaml
    /// </summary>
    public partial class DinoNuggets : Page
    {
        public DinoNuggets()
        {
            InitializeComponent();
        }

        public void ReturnToMain(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page1());
        }
        public void AddNug(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoDiner.Menu.DinoNuggets Entree)
                {
                    Entree.AddNugget();
                    CollectionViewSource.GetDefaultView(order.Items).Refresh();

                }
            }
        }
    }
}
