using System;
using System.Collections.Generic;
using LibrarySystem;

namespace WinFormsApp1
{
    public static class LibraryData
    {
        public static List<Book> books = new List<Book>();
        public static List<BorrowTransaction> transactions = new List<BorrowTransaction>();

        public static Dictionary<string, string> validStudents = new Dictionary<string, string>()
        {
            { "MMC2025-00110", "Jahzell Adriano" },
            { "MMC2025-00115", "Camille Maur" },
            { "MMC2025-00162", "Anonuevo Rainan" },
        };

        public const decimal penaltyPerDay = 10;
    }
}