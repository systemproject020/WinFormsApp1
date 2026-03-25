using LibrarySystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Transactions;
using System.Windows.Forms;
using System.Linq;

namespace WinFormsApp1
{
    public partial class Main_Form : Form
    {

        List<Book> books = new List<Book>();
        List<BorrowTransaction> transactions = new List<BorrowTransaction>();

        
        Dictionary<string, string> validStudents = new Dictionary<string, string>()
    {
        { "MMC2025-00110", "Jahzell Adriano" },
        { "001100002", "Juan Dela Cruz" }
    };

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

            dgvBooks.DataSource = null;
            dgvBooks.DataSource = transactions.Select(t => new
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

            dgvBooks.DataSource = report;
        }
        const decimal penaltyPerDay = 10;

        public Main_Form()
        {
            InitializeComponent();
            LoadBooks();
            DisplayBooks();

        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBookID.Text))
                {
                    MessageBox.Show("Please fill all fields.", "Input Error");
                    return;
                }

                int bookID;
                if (!int.TryParse(txtBookID.Text, out bookID))
                {
                    MessageBox.Show("Invalid Book ID format.", "Error");
                    return;
                }

                var transaction = transactions
                    .LastOrDefault(t => t.BookID == bookID && t.DateReturned == null);

                if (transaction == null)
                    throw new Exception("No active borrow record found.");

                transaction.DateReturned = DateTime.Now;


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

                if (!System.Text.RegularExpressions.Regex.IsMatch(txtStudentID.Text, @"^MMC\d{4}-\d{5}$"))
                {
                    throw new Exception("Invalid Student ID. Please enter a valid ID");
                }

                if (!validStudents.ContainsKey(txtStudentID.Text))
                {
                    throw new Exception("Student ID not recognized.");
                }

                if (validStudents[txtStudentID.Text] != txtStudentName.Text)
                {
                    throw new Exception("This Student ID is assigned to another student.");
                }

                string[] words = txtStudentName.Text.Split(' ');

                foreach (string word in words)
                {
                    if (!char.IsUpper(word[0]))
                    {
                        throw new Exception("Each word in the name must start with a capital letter.");
                    }
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

                bool hasActiveBorrow = transactions.Any(t =>
                (t.StudentID == txtStudentID.Text ||
                 t.StudentName == txtStudentName.Text) &&
                t.DateReturned == null);
                if (hasActiveBorrow)
                {
                    throw new Exception($"{txtStudentName.Text} or ID {txtStudentID.Text} still has an unreturned book.");
                }

                selectedBook.AvailableCopies--;
                BorrowTransaction transaction = new BorrowTransaction()
                {
                    StudentID = txtStudentID.Text,
                    StudentName = txtStudentName.Text,
                    BookID = selectedBook.BookID,
                    DateBorrowed = DateTime.Now
                };
                transactions.Add(transaction);
                MessageBox.Show(
                $"{txtStudentName.Text} Borrowed '{selectedBook.Title}'",
                "Borrow Successful",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                  );

                DisplayBooks();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format.", "Format Error");
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



        private void btnReports_Click(object sender, EventArgs e)
        {
            try
            {
                if (!rdoAvailable.Checked && !rdoHistory.Checked && !rdoMostBorrowed.Checked)
                {
                    MessageBox.Show("Please select a option.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (rdoAvailable.Checked)
                {
                    DisplayBooks();
                    lblTitle.Text = "Available Books";
                }
                else if (rdoHistory.Checked)
                {
                    LoadBorrowHistory();
                    lblTitle.Text = "Borrow History";
                }
                else if (rdoMostBorrowed.Checked)
                {
                    LoadMostBorrowedBooks();
                    lblTitle.Text = "Most Borrowed Books";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}





