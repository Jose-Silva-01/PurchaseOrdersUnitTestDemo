using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrders
{
    public static class ProductValidation
    {
        // We are writing it once and using it twice, 
        public static bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;
            else
                return true;
        }

        public static bool IsValidPrice(decimal price)
        {
            if (price <= 0)
                return false;
            else
                return true;
        }
    }
}
