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
    public partial class SupplierForm : Form
    {
        private SupplierService _supplierService;
        public SupplierForm()
        {
            InitializeComponent();
            _supplierService = new SupplierService();
            LoadSuppliers();
        }
        private void LoadSuppliers()
        {
            dgvSuppliers.DataSource = _supplierService.GetSuppliers().ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier
            {
                SupplierName = txtSupplierName.Text,
                ProductName = txtProductName.Text
            };

            _supplierService.AddSupplier(supplier);

            MessageBox.Show("Supplier added successfully!");

            LoadSuppliers();
        }
    }
}
