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
using System.Windows.Shapes;
using DinoDiner.Menu;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Order order = this.DataContext as Order;
            
        }

        private void PassOnDataContext()
        {
            Page page = Frame.Content as Page;
            if (page != null)
            {
                page.DataContext = Frame.DataContext;
            }
        }

        public void OnLoadCompleted(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            PassOnDataContext();
        }
        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            PassOnDataContext();
        }
    }
}
