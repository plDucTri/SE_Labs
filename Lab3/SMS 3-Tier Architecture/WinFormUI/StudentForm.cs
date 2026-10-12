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
    public partial class StudentForm : Form
    {
        private StudentService _studentService;
        private int selectedStudentID;
        public StudentForm()
        {
            InitializeComponent();
            _studentService = new StudentService();

            LoadStudents();
        }

        private void LoadStudents()
        {
            dgvStudents.DataSource = _studentService.GetAllStudents();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                StudentName = txtStudentName.Text,
                DateOfBirth = dtpDateOfBirth.Value,
                City = txtCity.Text,
                Age = int.Parse(txtAge.Text),
                YearOfEnroll = int.Parse(txtYearOfEnroll.Text),
                Major = txtMajor.Text,
                GPA = decimal.Parse(txtGPA.Text)
            };

            _studentService.AddStudent(student);

            MessageBox.Show("Student added successfully!");

            LoadStudents();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
                selectedStudentID = (int)row.Cells["StudentID"].Value;
                txtStudentName.Text = row.Cells["StudentName"].Value.ToString();
                dtpDateOfBirth.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);
                txtCity.Text = row.Cells["City"].Value.ToString();
                txtAge.Text = row.Cells["Age"].Value.ToString();
                txtYearOfEnroll.Text = row.Cells["YearOfEnroll"].Value.ToString();
                txtMajor.Text = row.Cells["Major"].Value.ToString();
                txtGPA.Text = row.Cells["GPA"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                StudentID = selectedStudentID,
                StudentName = txtStudentName.Text,
                DateOfBirth = dtpDateOfBirth.Value,
                City = txtCity.Text,
                Age = int.Parse(txtAge.Text),
                YearOfEnroll = int.Parse(txtYearOfEnroll.Text),
                Major = txtMajor.Text,
                GPA = decimal.Parse(txtGPA.Text)
            };

            _studentService.UpdateStudent(student);
            LoadStudents();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedStudentID != 0)
            {
                _studentService.DeleteStudent(selectedStudentID);
                LoadStudents();
            }
        }
    }
}