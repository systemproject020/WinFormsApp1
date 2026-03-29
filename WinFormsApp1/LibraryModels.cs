namespace LibrarySystem
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public int AvailableCopies { get; set; }
    }

    public class BorrowTransaction
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public int BookID { get; set; }
        public DateTime DateBorrowed { get; set; }
        public DateTime? DateReturned { get; set; }
        public decimal Penalty { get; set; }
    }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}