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
using TEST.Database;
using TEST.Helpers;
using TEST.ViewModel;

namespace TEST
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class EditProductView : Window
    {
        private int id;
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
            foreach (var item in productList)
            {
                ProductSelected.Items.Add(item);
            }

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }


        private void EditProduct_Click(object sender, RoutedEventArgs e)
        {
            if (ProductSelected.SelectedItem == null)
            {
                MessageBox.Show("Invalid Product entered. Please enter a valid Product.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!ValidationHelper.IsValidName(newName))
            {
                NewName.Style = (Style)FindResource("InvalidTextBoxStyle");
                MessageBox.Show("Invalid name entered. Please enter a valid name.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (!ValidationHelper.IsValidPrice(newPrice))
            {
                NewPrice.Style = (Style)FindResource("InvalidTextBoxStyle");
                MessageBox.Show("Invalid price entered. Please enter a valid price.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (ProductType.SelectedItem == null)
            {
                MessageBox.Show("Invalid productTypeId entered. Please enter a valid productTypeId.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            var productType = (Model.ProductType)ProductType.SelectedItem;
            var product = (Model.Product)ProductSelected.SelectedItem;
            productModel.EditProduct(id = product.Id,newName, newPrice, newProductTypeId = productType.Id);
            MessageBox.Show("Product edited succesfully");

        }
    }
}
