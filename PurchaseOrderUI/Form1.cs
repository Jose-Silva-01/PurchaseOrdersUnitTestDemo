using PurchaseOrders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PurchaseOrderUI
{
    public partial class frmPurchaseOrder : Form
    {
        private List<Product> products;
        private Order order;

        public frmPurchaseOrder()
        {
            InitializeComponent();
            products = new List<Product>();
            order = new Order();
        }

        private void frmPurchaseOrder_Load(object sender, EventArgs e)
        {
            LoadDefaultProducts();
            BindProducts();
        }

        private void BindProducts()
        {
            lstProducts.DataSource = null;
            lstProducts.DataSource = products;
            lstProducts.DisplayMember = "Name";
            lstProducts.ValueMember = "Price";
        }

        private void BindOrder()
        {
            lstOrder.DataSource = null;
            lstOrder.DataSource = order.Products;
            lstOrder.DisplayMember = "Name";
            lstOrder.ValueMember = "Price";
        }

        private void LoadDefaultProducts()
        {
            products.Clear();
            products.Add(new Product() { Name = "Can", Price = 2 });
            products.Add(new Product() { Name = "Tea", Price = 1 });
            products.Add(new Product() { Name = "Sandwitch", Price = 4 });
            products.Add(new Product() { Name = "Soup", Price = 3 });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product selectedProduct = GetSelectedProduct();

            if(selectedProduct != null)
            {
                order.Products.Add(selectedProduct);
                BindOrder();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Product selectedItem = GetSelectedOrderItem();

            if(selectedItem != null)
            {
                order.Products.Remove(selectedItem);
                BindOrder();
            }
        }

        private Product GetSelectedProduct()
        {
            // We need this (Product) to "convert" the selected item to what we want
            if(lstProducts.SelectedItem != null)
            {
                Product product = (Product)this.lstProducts.SelectedItem;
                return product;
            }
            
            return null;
            
        }

        private Product GetSelectedOrderItem()
        {
            if(lstOrder.SelectedItem != null)
            {
                Product product = (Product)this.lstOrder.SelectedItem;
                return product;
            }

            return null;
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            string message = null;

            try
            {
                order.Customer.Name = txtName.Text;
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }

            errorProvider1.SetError(txtName, message);
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string message = null;

            try
            {
                order.Customer.Email = txtEmail.Text;
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }

            errorProvider1.SetError(txtEmail, message);
        }
    

        private void Phone_Validating(object sender, CancelEventArgs e)
        {
            string message = null;

            try
            {
                order.Customer.PhoneNumber = txtPhone.Text;
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }

            errorProvider1.SetError(txtPhone, message);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                order.Customer.SetAddress(txtStreet.Text, txtCity.Text, txtProvince.Text, txtPostalCode.Text);

                Address customerAddress = order.Customer.Address;

                MessageBox.Show($"Thank you for your order {order.Customer.Name}, it" +
                    $" will be shipped to {customerAddress.City} soon!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
