using LibrarySystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Transactions;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Main_Form : Form
    {

        List<Book> books = new List<Book>();
        List<BorrowTransaction> transactions = new List<BorrowTransaction>();

        private void LoadBooks()
        {
            books.Add(new Book { BookID = 11, Title = "C# Programming", AvailableCopies = 3 });
            books.Add(new Book { BookID = 22, Title = "Database Systems", AvailableCopies = 2 });
            books.Add(new Book { BookID = 33, Title = "Data Structures", AvailableCopies = 2 });
            books.Add(new Book { BookID = 43, Title = "Python Crash Course", AvailableCopies = 4 });
        }

        private void DisplayBooks()
        {
            dgvBooks.DataSource = null;
            dgvBooks.DataSource = books;
        }
        private void LoadBorrowHistory()
        {
            dgvReports.DataSource = null;
            dgvReports.DataSource = transactions.Select(t => new
            {
                t.StudentID,
                t.BookID,
                t.DateBorrowed,
                t.DateReturned,
                t.Penalty
            }).ToList();
        }

        private void LoadMostBorrowedBooks()
        {
            var report = transactions
                .GroupBy(t => t.BookID)
                .Select(g => new
                {
                    BookID = g.Key,
                    BorrowCount = g.Count()
                })
                .OrderByDescending(x => x.BorrowCount)
                .ToList();

            dgvReports.DataSource = report;
        }
        const decimal penaltyPerDay = 10;

        public Main_Form()
        {
            InitializeComponent();
            LoadBooks();
            DisplayBooks();
        }

        private void rdoHistory_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                int bookID = int.Parse(txtBookID.Text);

                var transaction = transactions
                    .LastOrDefault(t => t.BookID == bookID && t.DateReturned == null);

                if (transaction == null)
                    throw new Exception("No active borrow record found.");

                transaction.DateReturned = DateTime.Now;

                // Compute penalty
                int days = (transaction.DateReturned.Value - transaction.DateBorrowed).Days;

                if (days > 7)
                {
                    transaction.Penalty = (days - 7) * penaltyPerDay;
                }
                else
                {
                    transaction.Penalty = 0;
                }


                var book = books.FirstOrDefault(b => b.BookID == bookID);
                if (book != null)
                    book.AvailableCopies++;

                MessageBox.Show($"Book returned. Penalty: {transaction.Penalty}");

                DisplayBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Return Error");
            }
            finally
            {
                txtBookID.Clear();
            }
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            if (LoginForm.LoggedInRole == "Librarian")
            {
                btnReports.Enabled = false;
            }
        }


        private void btnReports_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (rdoHistory.Checked)
                    LoadBorrowHistory();
                else
                    LoadMostBorrowedBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerifyBorrow_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtStudentID.Text) ||
                    string.IsNullOrWhiteSpace(txtStudentName.Text) ||
                    string.IsNullOrWhiteSpace(txtBookID.Text))
                {
                    throw new Exception("All fields are required.");
                }

                int bookID;
                if (!int.TryParse(txtBookID.Text, out bookID))
                {
                    throw new Exception("Invalid Book ID format.");
                }


                Book selectedBook = books.FirstOrDefault(b => b.BookID == bookID);

                if (selectedBook == null)
                {
                    throw new Exception("Book not found.");
                }

                if (selectedBook.AvailableCopies <= 0)
                {
                    throw new Exception("No copies available for this book.");
                }


                selectedBook.AvailableCopies--;

                BorrowTransaction transaction = new BorrowTransaction()
                {
                    StudentID = txtStudentID.Text,
                    BookID = selectedBook.BookID,
                    DateBorrowed = DateTime.Now
                };

                transactions.Add(transaction);

                lblStatus.Text = $"SUCCESS: {txtStudentName.Text} borrowed '{selectedBook.Title}'";
                MessageBox.Show("Borrow successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DisplayBooks();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format.", "Format Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Borrowing failed.";
            }
            finally
            {

                txtBookID.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
        }
    }
}




