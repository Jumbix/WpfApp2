﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;

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
            SqlConnection connection = new SqlConnection(@"SERVER=localhost;DATABASE=Carx_db;Integrated Security = true;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            connection.Open();
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT MarcaMasina, ModelMasina, Kilometraj, Pret, AnFab, Combustibil FROM dbo.Masina";
            dt.Load(cmd.ExecuteReader());
            connection.Close();
            OfferGrid.DataContext = dt;
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
            //"select = from Carx_db", connection

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            string car = carName.SelectedItem.ToString();
            string model = carModel.SelectedItem.ToString();
            int miles = int.Parse((mileage.SelectedItem as ComboBoxItem).Content.ToString());
            int price1 = int.Parse(priceRange1.Text.ToString());
            int price2 = int.Parse(priceRange2.Text.ToString());
            int year = int.Parse((anItem.SelectedItem as ComboBoxItem).Content.ToString());
            string gas = (runsOn.SelectedItem as ComboBoxItem).Content.ToString();

            SqlConnection connection = new SqlConnection(@"SERVER=localhost;DATABASE=Carx_db;Integrated Security = true;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            connection.Open();
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT MarcaMasina, ModelMasina, Kilometraj, Pret, AnFab, Combustibil FROM dbo.Masina WHERE MarcaMasina = car AND ModelMasina = 'model' AND Combustibil = 'gas' AND AnFab > 'year' AND Pret BETWEEN 'price1' AND 'price2' AND Kilometraj < 'milage'; ";
            var reader = cmd.ExecuteReader();
            string carb = (string)reader["MarcaMasina"];
            string modelb = (string)reader[model];
            string gasb = (string)reader[gas];
            int milesb = (int)reader[miles];
            int preice1b = (int)reader[price1];
            int price2b = (int)reader[price2];
            int yearb = (int)reader[year];
            dt.Load(reader);
            dt.Select(car);
            dt.Select(model);
            connection.Close();

            //List<Car> cars = new List<Car>();

            //cars.Add(new Car() { CarName = car, CarModel = model, Milage = rnd.Next(miles), Price = rnd.Next(price1, price2), Year = year, Gas = gas });
            //cars.Add(new Car() { CarName = car, CarModel = model, Milage = rnd.Next(miles), Price = rnd.Next(price1, price2), Year = year, Gas = gas });
            //cars.Add(new Car() { CarName = car, CarModel = model, Milage = rnd.Next(miles), Price = rnd.Next(price1, price2), Year = year, Gas = gas });
            //cars.Add(new Car() { CarName = car, CarModel = model, Milage = rnd.Next(miles), Price = rnd.Next(price1, price2), Year = year, Gas = gas });
            //cars.Add(new Car() { CarName = car, CarModel = model, Milage = rnd.Next(miles), Price = rnd.Next(price1, price2), Year = year, Gas = gas });

            //OfferGrid.ItemsSource = cars;
        }

        //public class Car
        //{
        //    public string CarName { get; set; }
        //    public string CarModel { get; set; }
        //    public string Gas { get;set; }
        //    public int Milage { get; set; }
        //    public int Price { get; set; }
        //    public int Year { get; set; }
        //}

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
