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
    public partial class DeleteProductView : Window
    {
        private ProductViewModel productModel;
        public DeleteProductView()
        {
            InitializeComponent();
            productModel = new ProductViewModel();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            this.Close();        
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            var productList = productModel.GetProducts();
            foreach (var item in productList)
            {
                ProductSelected.Items.Add(item);
            }

        }
        

        private void DeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            var product = (Product)ProductSelected.SelectedItem;
            productModel.DeleteProduct(product.Id);
            var completeMessage = MessageBox.Show("Product deleted succesfully");
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
