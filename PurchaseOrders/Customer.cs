using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrders
{
    public class Customer
    {
        public Address Address { get; private set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public decimal Price { get; set; }

        public bool IsValid()
        {
            if(Address == null || Address.IsValid() == false)
            {
                return false;
            }

            return true;
        }

        public void SetAddress(string street, string city, string province, string postalCode)
        {
            Address = new Address() { Street = street, City = city, Province = province, PostalCode = postalCode };
        }
    }
}
