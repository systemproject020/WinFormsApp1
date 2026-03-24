using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Transactions;
using LibrarySystem;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {

        List<User> users = new List<User>()
        {
            new User { Username = "admin", Password = "admin123", Role = "Admin" },
            new User { Username = "librarian", Password = "lib123", Role = "Librarian" }
        };

        public static string LoggedInRole;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var user = users.FirstOrDefault(u =>
                    u.Username == txtUsername.Text &&
                    u.Password == txtPassword.Text);

                if (user == null)
                    throw new Exception("Invalid username or password.");

                LoggedInRole = user.Role;

                MessageBox.Show("Login Successful!");

                Main_Form main = new Main_Form();
                main.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Error");
            }
            finally
            {
                txtPassword.Clear();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }
    }
}
