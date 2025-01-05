using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Buddy_Expense_and_Debt_Tracker.Components.Utilities
{
    public class Utils
    {
        public static string ROOTFOLDER = Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.Desktop), "ExpenseManager");

        public static string USERS = Path.Combine(ROOTFOLDER, "users.json");
        public static string TRANSACTIONS = Path.Combine(ROOTFOLDER, "transactions.json");
        public static string TAGS = Path.Combine(ROOTFOLDER, "tags.json");



        public static Guid CURRENTUSER = Guid.Empty;
        public static bool ISAUTHENTICATED = false;

        public static double income = 0;
        public static double expense = 0;
        public static double debt = 0;
    }
}
