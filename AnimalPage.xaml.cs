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
    /// Interaction logic for AnimalPage.xaml
    /// </summary>
    public partial class AnimalPage : Page
    {
        List<Animal> aLst = new List<Animal>();
        public AnimalPage()
        {
            InitializeComponent();
            BuildAnimalList();
        }
        public void BuildAnimalList()
        {
            Animal a1 = new Animal() { Birth = DateTime.Now, Name = "Cat", Weight = 12 };
            Animal a2 = new Animal() { Birth = new DateTime(2011,2,5), Name = "Dog", Weight = 36 };
            Animal a3 = new Animal() { Birth = new DateTime(2011, 4, 6), Name = "Horse", Weight = 120 };
            aLst.Add(a1);
            aLst.Add(a2);
            aLst.Add(a3);
            lv.ItemsSource = aLst;
        }

        private void EditIVD_Click(object sender, RoutedEventArgs e)
        {
            sp.Visibility = Visibility.Visible;
            animalBirth.DisplayDate = ((Animal)(lv.SelectedItem)).Birth;
            animalName.Text = ((Animal)(lv.SelectedItem)).Name;
            animalWeight.Text = ((Animal)(lv.SelectedItem)).Weight.ToString();
        }

        private void RemoveIVD_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
