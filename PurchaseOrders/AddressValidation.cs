using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrders
{
    public static class AddressValidation
    {
        // It's interesting to have a method for each one because even if they are the same in this
        // code, we could make it more fancy and put different types of validation for each property

        // It's not a bad idea to have a class designed to only do the validations, it keeps the 
        // code organized and easier to read.
        public static bool IsStreetValid(string street)
        {
            if (string.IsNullOrWhiteSpace(street))
                return false;
            else
                return true;
        }

        public static bool IsCityValid(string city)
        {
            if (string.IsNullOrWhiteSpace(city))
                return false;
            else
                return true;
        }

        public static bool IsProvinceValid(string province)
        {
            if (string.IsNullOrWhiteSpace(province))
                return false;
            else
                return true;
        }

        public static bool IsPostalCodeValid(string postalCode)
        {
            if (string.IsNullOrWhiteSpace(postalCode)) //|| postalCode.Trim().Length > 6) // Just a fancy example, maybe not the best but anyway...
                return false;
            else
                return true;
        }
    }
}
