using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class ProductForm : Form
    {
        private ProductService _productService;
        public ProductForm()
        {
            InitializeComponent();
            _productService = new ProductService();
            LoadProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                ProductName = txtProductName.Text,
                Quantity = int.Parse(txtQuantity.Text),
                Price = int.Parse(txtPrice.Text)
            };

            _productService.AddProduct(product);

            MessageBox.Show("Product added successfully!");

            LoadProducts();
        }

        private void LoadProducts()
        {
            dgvProducts.DataSource = _productService.GetProducts().ToList();
        }
    }
}
