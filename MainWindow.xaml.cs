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

namespace SimpleNavigation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PrevPage(object sender, RoutedEventArgs e)
        {
            if (this.exampleFrame.NavigationService.CanGoBack)
                this.exampleFrame.NavigationService.GoBack();
        }

        private void NextPage(object sender, RoutedEventArgs e)
        {

            if (this.exampleFrame.NavigationService.CanGoForward)
                this.exampleFrame.NavigationService.GoForward();
        }

        private void Page4Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Page4());
        }

        private void Page5Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Page5());
        }
        
    }
}
