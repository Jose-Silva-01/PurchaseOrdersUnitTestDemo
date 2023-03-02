using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurchaseOrders
{
    public class Order
    {
        public DateTime Date { get; set; }

        public Customer Customer { get; set; }

        public List<Product> Products { get; set; }

        public Order()
        {
            Products = new List<Product>();
            Customer = new Customer();
        }

        public Order(Customer customer, List<Product> products) : this()
        {
            this.Customer = customer;
            this.Products = products;
        }

        public decimal GetOrderSubTotal()
        {
            return 0;
        }

        public bool IsValid()
        {
            if(Customer.IsValid() == false)
                return false;

            if (Products.Count < 1)
                return false;

            return true;    
        }

    }
}
