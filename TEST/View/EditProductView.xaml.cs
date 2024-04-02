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
using TEST.Model;
using TEST.ViewModel;

namespace TEST
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class EditProductView : Window
    {
        private string newName;
        private decimal newPrice;
        private int newProductTypeId;
        private ProductViewModel productModel;

        public EditProductView()
        {
            InitializeComponent();
            productModel = new ProductViewModel();
        }
        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            newName = NewName.Text;
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
            newPrice = Convert.ToDecimal(NewPrice.Text, CultureInfo.InvariantCulture.NumberFormat);
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            var productType = (ProductType)ProductType.SelectedItem;
            productModel.AddProduct( newName, newPrice, newProductTypeId = productType.Id);
            MessageBox.Show("Product added succesfully");

        }

        private void Back(object sender, RoutedEventArgs e)
        {
            this.Close();        
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            var typeList = productModel.GetProductTypes();
            foreach (var item in typeList)
            {
                ProductType.Items.Add(item);
            }
            var productList = productModel.GetProducts();

            foreach (var item in typeList)
            {
                Products.Items.Add(item);
            }

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
