using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CarName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((carName.SelectedItem as ComboBoxItem).Content.ToString() == "Audi")
            {
                List<string> t = new List<string>();
                t.Add("A1");
                t.Add("A2");
                t.Add("A3");
                t.Add("A4");
                t.Add("A5");
                t.Add("A6");
                carModel.ItemsSource = t;
            }
            if ((carName.SelectedItem as ComboBoxItem).Content.ToString() == "BMW")
            {
                List<string> t = new List<string>();
                t.Add("Seria1");
                t.Add("Seria2");
                t.Add("Seria3");
                t.Add("Seria4");
                t.Add("Seria5");
                carModel.ItemsSource = t;
            }
            if ((carName.SelectedItem as ComboBoxItem).Content.ToString() == "Chevrolette")
            {
                List<string> t = new List<string>();
                t.Add("Camaro");
                t.Add("Dahoa");
                t.Add("Corvette");
                carModel.ItemsSource = t;
            }
            if ((carName.SelectedItem as ComboBoxItem).Content.ToString() == "Dacia")
            {
                List<string> t = new List<string>();
                t.Add("1900");
                t.Add("Logan");
                t.Add("Nova");
                t.Add("GIFonu");
                t.Add("Duster");
                t.Add("Papuc");
                t.Add("Stepway");
                carModel.ItemsSource = t;
            }
            if ((carName.SelectedItem as ComboBoxItem).Content.ToString() == "Ford")
            {
                List<string> t = new List<string>();
                t.Add("Fiesta");
                t.Add("Focus");
                t.Add("Mustang");
                carModel.ItemsSource = t;
            }
            if ((carName.SelectedItem as ComboBoxItem).Content.ToString() == "Mercedes-Benz")
            {
                List<string> t = new List<string>();
                t.Add("Camaro");
                t.Add("Cabriolette");
                t.Add("Corvette");
                carModel.ItemsSource = t;
            }
        }

            private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 1950; i <= 2020; i++)
            {
                var t = new ComboBoxItem();
                t.Content = i;
                anItem.Items.Add(t);
            }
        }

        private void CarModel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AnItem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void PriceRange_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }


}
