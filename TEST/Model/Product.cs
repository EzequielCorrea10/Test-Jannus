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
        public int Id{ get; set; }
        public int ProductTypeId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product( string name, decimal price, int typeId )
        {
            this.Name = name;
            this.Price = price;
            this.ProductTypeId = typeId;

        }

        public Product(int id, string name, decimal price, int typeId)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.ProductTypeId = typeId;
        }
    }
}
