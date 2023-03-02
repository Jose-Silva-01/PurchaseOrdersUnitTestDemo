using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrders
{
    public class Product
    {
        private string name;
        private decimal price;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (ProductValidation.IsValidName(value) == false)
                {
                    throw new Exception("Invalid name, can't be blank");
                }

                name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (ProductValidation.IsValidPrice(value) == false)
                    throw new Exception("Invalid Price");
                price = value;
            }
        }

        public bool IsValid()
        {
            // Since the ProductValidation is a static class we don't need to instantiate it
            // we can call it directly as bellow
            if (ProductValidation.IsValidName(Name) == false)
                return false;

            if (ProductValidation.IsValidPrice(Price) == false)
                return false;

            return true;
        }
    }
}
