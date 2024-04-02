using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEST.Database;


namespace TEST.Services
{
    public class ProductService
    {
        private ConexionDB conexionDB;
        public ProductService()
        {
            // Instancia de la clase ConexionDB pasando la cadena de conexión como parámetro
            conexionDB = new ConexionDB();
        }

        public void CreateProduct(string name, decimal price, int typeId)
        {
            conexionDB.InsertProduct(typeId,name, price );
        }
        public void CreateProductType(string description)
        {
            conexionDB.InsertProductType(description);
        }
        public void EditProduct(int id,string name, decimal price, int typeId)
        {
            conexionDB.EditProduct(id,typeId, name, price);
        }
        public void DeleteProduct(int id)
        {
            conexionDB.DeleteProduct(id);
        }
        internal List<Product> GetProducts()
        {
            return conexionDB.GetProducts();
        }
        internal List<ProductType> GetProductTypes()
        {
            return conexionDB.GetProductTypes();
        }
    }
}
