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
            if (carName.SelectedItem.ToString() == "Audi")
            {
                List<string> t = new List<string>();
                t.Add("A1");
                t.Add("A2");
                carModel.ItemsSource = t;
                //t.source = "A1";
                //carModel.Items.Add(t);
                //t.Content = "A2";
                //carModel.Items.Add(t);
                //t.Content = "A3";
                //carModel.Items.Add(t);
                //t.Content = "A4";
                //carModel.Items.Add(t);
                //t.Content = "A5";
                //carModel.Items.Add(t);
                //t.Content = "A6";
                //carModel.Items.Add(t);
                //t.Content = "A7";
                //carModel.Items.Add(t);
                //t.Content = "A8";
                //carModel.Items.Add(t);
            }
            if (carName.SelectedItem.ToString() == "BMW")
            {
                var t = new ComboBoxItem();
                t.Content = "Seria1";
                carModel.Items.Add(t);
                t.Content = "Seria2";
                carModel.Items.Add(t);
                t.Content = "Seria3";
                carModel.Items.Add(t);
                t.Content = "Seria4";
                carModel.Items.Add(t);
                t.Content = "Seria5";
                carModel.Items.Add(t);
            }
            if (carName.SelectedItem.ToString() == "Chevrolette")
            {
                var t = new ComboBoxItem();
                t.Content = "Camaro";
                carModel.Items.Add(t);
                t.Content = "Dahoa";
                carModel.Items.Add(t);
                t.Content = "Corvette";
                carModel.Items.Add(t);
            }
            if (carName.SelectedItem.ToString() == "Dacia")
            {
                var t = new ComboBoxItem();
                t.Content = "1900";
                carModel.Items.Add(t);
                t.Content = "Logan";
                carModel.Items.Add(t);
                t.Content = "Nova";
                carModel.Items.Add(t);
                t.Content = "GIFonu";
                carModel.Items.Add(t);
                t.Content = "Duster";
                carModel.Items.Add(t);
                t.Content = "Papuc";
                carModel.Items.Add(t);
                t.Content = "Stepway";
                carModel.Items.Add(t);
            }
            if (carName.SelectedItem.ToString() == "Ford")
            {
                var t = new ComboBoxItem();
                t.Content = "Fiesta";
                carModel.Items.Add(t);
                t.Content = "Focus";
                carModel.Items.Add(t);
                t.Content = "Mustang";
                carModel.Items.Add(t);
            }
            if (carName.SelectedItem.ToString() == "Mercedes-Benz")
            {
                var t = new ComboBoxItem();
                t.Content = "Camaro";
                carModel.Items.Add(t);
                t.Content = "Cabriolette";
                carModel.Items.Add(t);
                t.Content = "Corvette";
                carModel.Items.Add(t);
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
    }


}
