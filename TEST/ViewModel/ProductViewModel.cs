using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TEST.Model;
using TEST.Services;

namespace TEST.ViewModel
{
    class ProductViewModel 
    {
        private ProductService productService;

        public ProductViewModel()
        {
            productService = new ProductService();
        }
        public void AddProduct(string name, float price, int producTypeId)
        {
            productService.CreateProduct(name, price, producTypeId);
        }

        public void DeleteProduct(string name, float price, int producTypeId)
        {
            productService.CreateProduct(name, price, producTypeId);
        }
        public Product[] GetProducts()
        {
            productService.GetProducts();
        }
        public void GetProductTypes()
        {
            productService.GetProductTypes();
        }
    }
}
