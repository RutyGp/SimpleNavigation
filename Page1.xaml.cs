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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
       public  List<AnimalUserControl> aUC;
       public  List<Animal> aList;
       public Page1()
        {
            InitializeComponent();
           
            aList = new List<Animal>();
            aList.Add(new Animal() { Birth = new DateTime(2005, 6, 9), Weight = 88, Name = "Kuku1" });
            aList.Add(new Animal() { Birth = new DateTime(2005, 1, 6), Weight = 12, Name = "Tuto2" });
            aList.Add(new Animal() { Birth = new DateTime(2014, 8, 2), Weight = 7, Name = "Momo3" });
            aList.Add(new Animal() { Birth = new DateTime(2005, 1, 6), Weight = 66, Name = "Suso4" });
            aList.Add(new Animal() { Birth = new DateTime(2014, 8, 2), Weight = 7, Name = "Quqo5" });
            aList.Add(new Animal() { Birth = new DateTime(2005, 1, 6), Weight = 8, Name = "Zuzo6" });
            aList.Add(new Animal() { Birth = new DateTime(2019, 8, 2), Weight = 9, Name = "Yoyo7" });

            aUC = new List<AnimalUserControl>();
            foreach (Animal a in aList)
            {
                AnimalUserControl control = new AnimalUserControl(a);
                // Subscribe to the delete event
                control.DeleteClicked += HandleAnimalDelete;
                aUC.Add(control);
            }
            lb.ItemsSource = aUC;
        }

        private void HandleAnimalDelete(Animal animalToDelete)
        {
           // Find and remove the control for this animal

            var itemToRemove = aList.FindIndex(x => x == animalToDelete);
            if (itemToRemove > -1)
            {
                aUC.RemoveAt(itemToRemove);
                aList.RemoveAt(itemToRemove);
                lb.Items.Refresh();
            }
            
        }

       

        private void Page2Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Page2());
        }

        private void Page3Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Page3());
        }

        private void AnimalPage(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new AnimalPage());
        }
    }
}
