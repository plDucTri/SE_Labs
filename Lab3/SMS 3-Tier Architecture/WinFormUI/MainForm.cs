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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentForm form = new StudentForm();
            form.Show();
        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseForm form = new CourseForm();
            form.Show();
        }

        private void instructorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstructorForm form = new InstructorForm();
            form.Show();
        }

        private void departmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentForm form = new DepartmentForm();
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
