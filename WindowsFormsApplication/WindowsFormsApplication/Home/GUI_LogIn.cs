using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication.Home
{
    public partial class GUI_LogIn : Form
    {
        BUS_LogIn buslogin = null;
        public GUI_LogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            GUI_Home guihome = new GUI_Home();
            string username = txtUser.Text;
            string password = txtPassword.Text;
            if (txtUser.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                txtUser.Text = "";
                txtPassword.Text = "";
                txtUser.Focus();
            }
            else
            {
                if (buslogin.LoginUser(username, password) == true)
                {
                    this.Hide();
                    guihome.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                    txtUser.Text = "";
                    txtPassword.Text = "";
                    txtUser.Focus();
                }
            }
            
        }

        private void GUI_LogIn_Load(object sender, EventArgs e)
        {
            buslogin = new BUS_LogIn();
        }
    }
}
