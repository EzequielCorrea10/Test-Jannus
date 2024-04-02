using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Objects;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TEST.ViewModel;

namespace TEST
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class ProductView : Window
    {
        private string name;
        private float price;
        private int productTypeId;
        private ProductViewModel productModel;

        public ProductView()
        {
            InitializeComponent();
            var productModel = new ProductViewModel();
        }
        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            name = Name.Text;
        }
        private void Price_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            // Permitir solo dígitos, punto decimal y un solo signo negativo al principio
            if (!char.IsDigit(e.Text, e.Text.Length - 1) && e.Text != "."  ||
                (e.Text == "." && ((TextBox)sender).Text.Contains(".")))
            {
                e.Handled = true; // Cancelar la entrada
            }

        }

        private void Price_TextChanged(object sender, TextChangedEventArgs e)
        {
            price = float.Parse( Price.Text, CultureInfo.InvariantCulture.NumberFormat);
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            productModel.AddProduct( name, price, productTypeId = 1 );
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            this.Close();        
        }

        private void ListView_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var userList = productModel.GetProducts();

        }


    }
}
