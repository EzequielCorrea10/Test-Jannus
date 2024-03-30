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
        private ConexionDB conexionDB;
        public ProductService()
        {
            // Instancia de la clase ConexionDB pasando la cadena de conexión como parámetro
            conexionDB = new ConexionDB();
        }



    }
}
