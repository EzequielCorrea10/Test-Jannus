using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Objects;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace TEST
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class ProductView : Window
    {
        public ProductView()
        {
            InitializeComponent();
        }
        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            this.Close();        
        }

        private void ListView_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
