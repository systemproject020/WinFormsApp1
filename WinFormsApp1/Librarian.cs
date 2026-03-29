using LibrarySystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Transactions;
using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class Librarian : Form
    {

        private void DisplayBooks()
        {
            if (LibraryData.books.Count == 0)
            {
                LibraryData.books.Add(new Book { BookID = 11, Title = "C# Programming", AvailableCopies = 3 });
                LibraryData.books.Add(new Book { BookID = 22, Title = "Database Systems", AvailableCopies = 2 });
                LibraryData.books.Add(new Book { BookID = 33, Title = "Data Structures", AvailableCopies = 2 });
                LibraryData.books.Add(new Book { BookID = 43, Title = "Python Crash Course", AvailableCopies = 4 });
            }
        }

        private void LoadBooks()
        {
            dgvBooks.DataSource = null;
            dgvBooks.DataSource = LibraryData.books;
        }

        public Librarian()
        {
            InitializeComponent();
            DisplayBooks();
            LoadBooks();
        }


        private void btnVerifyBorrow_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txtStudentName.Text) || string.IsNullOrWhiteSpace(txtBookID.Text))
                    throw new Exception("All fields are required.");

             
                string[] words = txtStudentName.Text.Trim().Split(' ');
                foreach (string word in words)
                {
                    if (!char.IsUpper(word[0]))
                        throw new Exception("Each word must start with a capital letter.");
                }

           
                var student = LibraryData.validStudents.FirstOrDefault(x => x.Value == txtStudentName.Text);
                if (string.IsNullOrEmpty(student.Key))
                    throw new Exception("Student not recognized.");
                txtStudentID.Text = student.Key;

                int bookID;
                if (!int.TryParse(txtBookID.Text, out bookID))
                    throw new Exception("Invalid Book ID.");

                Book selectedBook = LibraryData.books.FirstOrDefault(b => b.BookID == bookID);
                if (selectedBook == null)
                    throw new Exception("Book not found.");

                if (selectedBook.AvailableCopies <= 0)
                    throw new Exception("No copies available.");

                var activeBorrow = LibraryData.transactions
                    .FirstOrDefault(t => t.StudentID == txtStudentID.Text && t.DateReturned == null);

                if (activeBorrow != null)
                {
                    var book = LibraryData.books.FirstOrDefault(b => b.BookID == activeBorrow.BookID);
                    string title = book != null ? book.Title : "Unknown";

                    throw new Exception($"{txtStudentName.Text} still has unreturned book: {title}");
                }

                selectedBook.AvailableCopies--;

                LibraryData.transactions.Add(new BorrowTransaction
                {
                    StudentID = txtStudentID.Text,
                    StudentName = txtStudentName.Text,
                    BookID = bookID,
                    DateBorrowed = DateTime.Now
                });

                MessageBox.Show("Borrow successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvBooks.DataSource = null;
                dgvBooks.DataSource = LibraryData.books;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                txtBookID.Clear();
            }
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                int bookID;
                if (!int.TryParse(txtBookID.Text, out bookID))
                    throw new Exception("Invalid Book ID.");

                var transaction = LibraryData.transactions
                    .LastOrDefault(t => t.BookID == bookID && t.DateReturned == null);

                if (transaction == null)
                    throw new Exception("No active record.");

                transaction.DateReturned = DateTime.Now;

                int days = (transaction.DateReturned.Value - transaction.DateBorrowed).Days;

                if (days > 7)
                    transaction.Penalty = (days - 7) * LibraryData.penaltyPerDay;
                else
                    transaction.Penalty = 0;

                var book = LibraryData.books.FirstOrDefault(b => b.BookID == bookID);
                if (book != null)
                    book.AvailableCopies++;

                MessageBox.Show("Return successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvBooks.DataSource = null;
                dgvBooks.DataSource = LibraryData.books;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtBookID.Clear();
            }
        }

        private void Librarian_Load(object sender, EventArgs e)
        {
            if (LoginForm.LoggedInRole == "Librarian")
            {
                txtStudentID.Visible = false;
                lblid.Visible = false;
            }
        }


        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {
            var student = LibraryData.validStudents
             .FirstOrDefault(x => x.Value == txtStudentName.Text);
            if (!string.IsNullOrEmpty(student.Key))
            {
                txtStudentID.Text = student.Key;
            }
            else
            {
                txtStudentID.Clear();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to log out?",
                    "Confirm Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    Fromm1 login = new Fromm1();
                    login.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Console.WriteLine("Logout attempt done.");
            }
        }
    }
}

