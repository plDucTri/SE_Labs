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
    public partial class CourseForm : Form
    {
        private CourseService _courseService;
        private DepartmentService _departmentService;
        private InstructorService _instructorService;

        private int selectedCourseID;
        public CourseForm()
        {
            InitializeComponent();
            _courseService = new CourseService();
            _departmentService = new DepartmentService();
            _instructorService = new InstructorService();
            LoadDepartments();
            LoadInstructors();
            LoadCourses();
        }

        private void LoadDepartments()
        {
            cboDepartment.DataSource = _departmentService.GetAllDepartments();
            cboDepartment.DisplayMember = "DepartmentName";
            cboDepartment.ValueMember = "DepartmentID";
        }

        private void LoadInstructors()
        {
            cboInstructor.DataSource = _instructorService.GetAllInstructors();
            cboInstructor.DisplayMember = "InstructorName";
            cboInstructor.ValueMember = "InstructorID";
        }

        private void LoadCourses()
        {
            dgvCourses.DataSource = _courseService.GetAllCourses();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Course course = new Course
            {
                CourseName = txtCourseName.Text,
                Credits = int.Parse(txtCredits.Text),
                DepartmentID = (int)cboDepartment.SelectedValue,
                InstructorID = (int)cboInstructor.SelectedValue
            };
            _courseService.AddCourse(course);
            LoadCourses();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCourseID != 0)
            {
                _courseService.DeleteCourse(selectedCourseID);
                LoadCourses();
            }
        }

        private void dgvCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCourses.Rows[e.RowIndex];
                selectedCourseID = (int)row.Cells["CourseID"].Value;
            }
        }
    }
}
