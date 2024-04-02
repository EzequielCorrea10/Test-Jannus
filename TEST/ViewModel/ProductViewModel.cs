using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TEST.Database;
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
        public void AddProduct(string name, decimal price, int producTypeId)
        {
            productService.CreateProduct(name, price, producTypeId);
        }
        public void AddProductType(string description)
        {
            productService.CreateProductType(description);
        }
        public void EditProduct(int id,string name, decimal price, int producTypeId)
        {
            productService.EditProduct(id,name, price, producTypeId);
        }
        public void DeleteProduct(int id)
        {
            productService.DeleteProduct(id);
        }
        public List<Product> GetProducts()
        {
           return  productService.GetProducts();
        }
        internal List<ProductType> GetProductTypes()
        {
          return  productService.GetProductTypes();
        }
    }
}
