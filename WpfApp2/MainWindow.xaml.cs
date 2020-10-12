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
            List<string> t = new List<string>();
            t.Add("Audi");
            t.Add("BMW");
            t.Add("Chevrolette");
            t.Add("Dacia");
            t.Add("Ford");
            t.Add("Mercedes-Benz");
            t.Add("Mazda");
            t.Add("Opel");
            t.Add("Renault");
            t.Add("Skoda");
            t.Add("Toyota");
            t.Add("Volskwagen");
            carName.ItemsSource = t;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var car = carName.SelectedItem.ToString();
            var model = carModel.SelectedItem.ToString();
            var miles = mileage.SelectedItem.ToString();
            var price1 = priceRange1.Text;
            var price2 = priceRange2.Text;
            var year = anItem.SelectedItem.ToString();
            var gas = runsOn.SelectedItem.ToString();

            var x = new DataGridCell();
        }

        private void CarName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (carName.SelectedItem.ToString() == "Audi")
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
            if (carName.SelectedItem.ToString() == "BMW")
            {
                List<string> t = new List<string>();
                t.Add("Seria1");
                t.Add("Seria2");
                t.Add("Seria3");
                t.Add("Seria4");
                t.Add("Seria5");
                carModel.ItemsSource = t;
            }
            if (carName.SelectedItem.ToString() == "Chevrolette")
            {
                List<string> t = new List<string>();
                t.Add("Camaro");
                t.Add("Dahoa");
                t.Add("Corvette");
                carModel.ItemsSource = t;
            }
            if (carName.SelectedItem.ToString() == "Dacia")
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
            if (carName.SelectedItem.ToString() == "Ford")
            {
                List<string> t = new List<string>();
                t.Add("Fiesta");
                t.Add("Focus");
                t.Add("Mustang");
                carModel.ItemsSource = t;
            }
            if (carName.SelectedItem.ToString() == "Mercedes-Benz")
            {
                List<string> t = new List<string>();
                t.Add("A Class");
                t.Add("B Class");
                t.Add("C class");
                t.Add("D class");
                carModel.ItemsSource = t;
            }
            if (carName.SelectedItem.ToString() == "Mazda")
            {
                List<string> t = new List<string>();
                t.Add("CX-3");
                t.Add("CX-5");
                t.Add("CX-9");
                t.Add("RX-6");
                t.Add("RX-7");
                t.Add("RX-8");
                carModel.ItemsSource = t;
            }
            if (carName.SelectedItem.ToString() == "Opel")
            {
                List<string> t = new List<string>();
                t.Add("Astra");
                t.Add("Astra H");
                t.Add("Tigra");
                carModel.ItemsSource = t;
            }
            if (carName.SelectedItem.ToString() == "Renault")
            {
                List<string> t = new List<string>();
                t.Add("Megan");
                t.Add("207");
                t.Add("307");
                carModel.ItemsSource = t;
            }
            if (carName.SelectedItem.ToString() == "Skoda")
            {
                List<string> t = new List<string>();
                t.Add("Fabia");
                t.Add("Octavia");
                t.Add("Superb");
                carModel.ItemsSource = t;
            }
            if (carName.SelectedItem.ToString() == "Toyota")
            {
                List<string> t = new List<string>();
                t.Add("Auris");
                t.Add("Corolla");
                t.Add("Yaris");
                carModel.ItemsSource = t;
            }
            if (carName.SelectedItem.ToString() == "Volskwagen")
            {
                List<string> t = new List<string>();
                t.Add("Golf");
                t.Add("Jetta");
                t.Add("Touareg");
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

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void priceRange1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void priceRange2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }


}
