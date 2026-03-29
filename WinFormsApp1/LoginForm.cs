using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Transactions;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        List<User> users = new List<User>()
        {
            new User { Username = "Admin", Password = "admin123", Role = "Admin" },
            new User { Username = "Librarian", Password = "lib123", Role = "Librarian" }
        };

        public static string LoggedInRole;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            panel1.Region = System.Drawing.Region.FromHrgn(RoundRec(0, 0, panel1.Width, panel1.Height, 20, 20));
            panel1.BackColor = Color.FromArgb(180, 0, 0, 0);
        }

        private void button1_Click_1(object sender, EventArgs e)
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


                if (user.Role == "Admin")
                {
                    Admin_Form admin = new Admin_Form();
                    admin.Show();
                }
                else if (user.Role == "Librarian")
                {
                    Librarian librarian = new Librarian();
                    librarian.Show();
                }

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
    }
}
