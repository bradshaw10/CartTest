using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CartTest
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Product> products = new ObservableCollection<Product>();
        public ObservableCollection<Product> Products { get { return products; } }
        public MainPage()
        {
            InitializeComponent();
            ProductView.ItemsSource = products;

            // ObservableCollection allows items to be added after ItemsSource
            // is set and the UI will react to changes
            products.Add(new Product { Name = "Rob Finnerty", Price = 10 });
            products.Add(new Product { Name = "Bill Wrestler", Price = 10 });
            products.Add(new Product { Name = "Dr. Geri-Beth Hooper", Price = 10 });
            products.Add(new Product { Name = "Dr. Keith Joyce-Purdy", Price = 10 });
            products.Add(new Product { Name = "Sheri Spruce", Price = 10 });
            products.Add(new Product { Name = "Burt Indybrick", Price = 10 });

            UpdateTotal();
        }
    

        private void Button_Clicked(object sender, EventArgs e)
        {
            products.Add(new Product { Name = "Shaggy", Price = 10 });

            UpdateTotal();
        }

        public void UpdateTotal()
        {
            double Total = 0;
            foreach (var price in products)
            {
                Total += price.Price;
            };

            CartTotal.Text = Total.ToString();
        }
    }   
}
