using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace TEST
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {

        private void StockRep_Click(object sender, RoutedEventArgs e)
        {
            ReportViewer win2 = new ReportViewer();
            win2.Show();
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            ProductView win2 = new ProductView();
            win2.Show();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            EditProductView win2 = new EditProductView();
            win2.Show();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            DeleteProductView win2 = new DeleteProductView();
            win2.Show();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void AddType_Click(object sender, RoutedEventArgs e)
        {
            ProductTypeView win2 = new ProductTypeView();
            win2.Show();
        }
    }
}
