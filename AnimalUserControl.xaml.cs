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
    /// Interaction logic for AnimalUserControl.xaml
    /// </summary>
    public partial class AnimalUserControl : UserControl
    {
        
        // Define the event that will notify Page1
        public event Action<Animal> DeleteClicked;

        public AnimalUserControl(Animal a)
        {
            InitializeComponent();
            this.DataContext = a;  // Set the DataContext to the animal
            tb.Text = a.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Just notify that delete was clicked for this animal
            DeleteClicked?.Invoke((Animal)this.DataContext);
        }
    
    }
}
