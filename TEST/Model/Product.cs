using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST.Model
{
    class Product
    {
        public int Id { get; set; }
        public string ProductType { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product()
        {


        }

        public Product(int id, string name, decimal price, string productType)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.ProductType = productType;
        }
    }
}
