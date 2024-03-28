using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEST.Model;

namespace TEST.Services
{
    public class ProductService
    {
        public void CreateProduct(string name, float price, int typeId)
        {
            var product = new Product(name, price, typeId);

        }

    }
}
