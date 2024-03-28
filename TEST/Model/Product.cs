using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST.Model
{
    class Product
    {
        public int Id { get; set; }
        public int ProductTypeId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public Product(string name, float price, int typeId )
        {
            this.Name = name;
            this.Price = price;
            this.ProductTypeId = typeId;

        }
    }
}
