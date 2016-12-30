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
        public GUI_LogIn()
        {
            InitializeComponent();
        }

        BUS_LogIn buslogin = null;

        private void showLoginForm(object sender, EventArgs e)
        {
            buslogin = new BUS_LogIn();
        }

        private bool validateInputData(string username, string password)
        {
            if ((username ?? "").Trim().Length == 0)
            {
                MessageBox.Show("Tài khoản là bắt buộc!");
                return false;
            }
            if (username.Length > 50)
            {
                MessageBox.Show("Tài khoản có độ dài ký tự từ 1 đến 50");
                return false;
            }
            if ((password ?? "").Trim().Length == 0)
            {
                MessageBox.Show("Mật khẩu là bắt buộc!");
                return false;
            }
            if (password.Length > 50)
            {
                MessageBox.Show("Mật khẩu có độ dài ký tự từ 1 đến 50");
                return false;
            }
            return true;
        }

        private void clickLogin(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPassword.Text;
            var inputData = validateInputData(username, password);
            if(inputData)
            {
                if (buslogin.getInputData(username, password))
                {
                    GUI_Home guihome = new GUI_Home();
                    this.Hide();
                    guihome.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                    txtUser.Text = txtPassword.Text = "";
                    txtUser.Focus();
                }
            }
            else
            {
                txtUser.Text = txtPassword.Text = "";
                txtUser.Focus();
            }
        }
    }
}
