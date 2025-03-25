using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SYSARCH_proj
{
    internal class DbHelper
    {
        public static OleDbConnection conn;
        private static string dbconnect = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\hi\\Downloads\\SYSARCH-proj\\SYSARCH-proj\\SYSARCH-proj\\univ.accdb";

        public static void GetConnection()
        {
            try
            {
                conn = new OleDbConnection(dbconnect);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}