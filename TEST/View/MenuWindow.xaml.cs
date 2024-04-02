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

        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            ProductView win2 = new ProductView();
            win2.Show();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            ModifyProductView win2 = new ModifyProductView();
            win2.Show();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Stock_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
