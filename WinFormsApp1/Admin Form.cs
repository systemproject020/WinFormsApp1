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
using ClosedXML.Excel; 

namespace WinFormsApp1
{
    public partial class Admin_Form : Form
    {
        private void LoadBooks()
        {
            if (LibraryData.books.Count == 0)
            {
                LibraryData.books.Add(new Book { BookID = 11, Title = "C# Programming", AvailableCopies = 3 });
                LibraryData.books.Add(new Book { BookID = 22, Title = "Database Systems", AvailableCopies = 2 });
                LibraryData.books.Add(new Book { BookID = 33, Title = "Data Structures", AvailableCopies = 2 });
                LibraryData.books.Add(new Book { BookID = 43, Title = "Python Crash Course", AvailableCopies = 4 });
            }
        }

        public Admin_Form()
        {
            InitializeComponent();
            LoadBooks();
            DisplayBooks();
        }

        private void DisplayBooks()
        {
            dgvBooks.DataSource = null;
            dgvBooks.DataSource = LibraryData.books;

            if (dgvBooks.Rows.Count > 0)
                dgvBooks.ClearSelection();
        }

        private void LoadBorrowHistory()
        {
            dgvBooks.DataSource = null;
            dgvBooks.DataSource = LibraryData.transactions.Select(t => new
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
            var report = LibraryData.transactions
                .GroupBy(t => t.BookID)
                .Select(g => new
                {
                    BookID = g.Key,
                    Count = g.Count()
                })
                .OrderByDescending(x => x.Count)
                .ToList();

            dgvBooks.DataSource = report;
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {
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
                    RoleForm login = new RoleForm();
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

        private void btnReport_Click(object sender, EventArgs e)
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                rdoAvailable.Checked = false;
                rdoHistory.Checked = false;
                rdoMostBorrowed.Checked = false;
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (LibraryData.transactions.Count == 0)
                    throw new Exception("Please process a borrow transaction first before exporting.");

                using (var workbook = new XLWorkbook())
                {

                    var sheet1 = workbook.Worksheets.Add("Borrow History");


                    sheet1.Cell(1, 1).Value = "Student ID";
                    sheet1.Cell(1, 2).Value = "Student Name";
                    sheet1.Cell(1, 3).Value = "Book ID";
                    sheet1.Cell(1, 4).Value = "Date Borrowed";
                    sheet1.Cell(1, 5).Value = "Date Returned";
                    sheet1.Cell(1, 6).Value = "Penalty";


                    var headerRow1 = sheet1.Range("A1:F1");
                    headerRow1.Style.Font.Bold = true;
                    headerRow1.Style.Fill.BackgroundColor = XLColor.DarkBlue;
                    headerRow1.Style.Font.FontColor = XLColor.White;


                    int row = 2;
                    foreach (var t in LibraryData.transactions)
                    {
                        sheet1.Cell(row, 1).Value = t.StudentID;
                        sheet1.Cell(row, 2).Value = t.StudentName;
                        sheet1.Cell(row, 3).Value = t.BookID;
                        sheet1.Cell(row, 4).Value = t.DateBorrowed.ToString("MM/dd/yyyy hh:mm tt");
                        sheet1.Cell(row, 5).Value = t.DateReturned.HasValue ? t.DateReturned.Value.ToString("MM/dd/yyyy hh:mm tt") : "Not yet returned";
                        sheet1.Cell(row, 6).Value = t.Penalty;
                        row++;
                    }

                    sheet1.Columns().AdjustToContents();


                    var sheet2 = workbook.Worksheets.Add("Most Borrowed Books");


                    sheet2.Cell(1, 1).Value = "Book ID";
                    sheet2.Cell(1, 2).Value = "Book Title";
                    sheet2.Cell(1, 3).Value = "Times Borrowed";


                    var headerRow2 = sheet2.Range("A1:C1");
                    headerRow2.Style.Font.Bold = true;
                    headerRow2.Style.Fill.BackgroundColor = XLColor.DarkBlue;
                    headerRow2.Style.Font.FontColor = XLColor.White;


                    var mostBorrowed = LibraryData.transactions
                        .GroupBy(t => t.BookID)
                        .Select(g => new
                        {
                            BookID = g.Key,
                            Title = LibraryData.books.FirstOrDefault(b => b.BookID == g.Key)?.Title ?? "Unknown",
                            Count = g.Count()
                        })
                        .OrderByDescending(x => x.Count)
                        .ToList();

                    int row2 = 2;
                    foreach (var item in mostBorrowed)
                    {
                        sheet2.Cell(row2, 1).Value = item.BookID;
                        sheet2.Cell(row2, 2).Value = item.Title;
                        sheet2.Cell(row2, 3).Value = item.Count;
                        row2++;
                    }

                    sheet2.Columns().AdjustToContents();


                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "Excel Files|*.xlsx";
                    saveDialog.FileName = $"LibraryReport_{DateTime.Now:MMddyyyy_HHmm}.xlsx";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(saveDialog.FileName);
                        MessageBox.Show("The library report has been successfully exported to Excel.", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f = new LoginForm();
            f.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



