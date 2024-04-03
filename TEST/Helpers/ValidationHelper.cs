using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST.Helpers
{
    public static class ValidationHelper
    {
        public static bool IsValidName(string name)
        {
            if(name != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsValidPrice(decimal? price)
        {
            if (price != null && price != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsValidId(int? id)
        {
            if (id != null && id != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
