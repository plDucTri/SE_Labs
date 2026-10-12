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
    public partial class InstructorForm : Form
    {
        private InstructorService _instructorService;
        private DepartmentService _departmentService;
        private int selectedInstructorID;
        public InstructorForm()
        {
            InitializeComponent();
            _instructorService = new InstructorService();
            _departmentService = new DepartmentService();
            LoadDepartments();
            LoadInstructors();
        }

        private void LoadDepartments()
        {
            cboDepartment.DataSource = _departmentService.GetAllDepartments();

            cboDepartment.DisplayMember = "DepartmentName";

            cboDepartment.ValueMember = "DepartmentID";
        }

        private void LoadInstructors()
        {
            dgvInstructors.DataSource = _instructorService.GetAllInstructors();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Instructor instructor = new Instructor
            {
                InstructorName = txtInstructorName.Text,

                DepartmentID = (int)cboDepartment.SelectedValue
            };
            _instructorService.AddInstructor(instructor);
            LoadInstructors();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadInstructors();
        }

        private void dgvInstructors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvInstructors.Rows[e.RowIndex];
                selectedInstructorID = (int)row.Cells["InstructorID"].Value;
            }
        }
    }
}
