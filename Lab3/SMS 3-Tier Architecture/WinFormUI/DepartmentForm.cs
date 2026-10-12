using BLL;
using DAL.Model;
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
    public partial class DepartmentForm : Form
    {
        private DepartmentService _departmentService;
        public DepartmentForm()
        {
            InitializeComponent();
            _departmentService = new DepartmentService();
            LoadDepartments();
        }

        private void LoadDepartments()
        {
            dgvDepartments.DataSource = _departmentService.GetAllDepartments();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Department department = new Department
            {
                DepartmentName = txtDepartmentName.Text
            };
            _departmentService.AddDepartment(department);
            LoadDepartments();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDepartments();
        }
    }
}