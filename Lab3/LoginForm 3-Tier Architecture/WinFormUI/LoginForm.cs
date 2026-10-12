using BLL;
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
    public partial class LoginForm : Form
    {
        private UserService service;
        public LoginForm()
        {
            InitializeComponent();
            service = new UserService();
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            bool result = service.Login(txtUsername.Text, txtPassword.Text);
          
            if (result)
            {
                MessageBox.Show("Login successful!");
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed!");
            }
        }
    }
}
