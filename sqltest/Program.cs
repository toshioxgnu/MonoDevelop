using System;
using MySql.Data.MySqlClient;

namespace sqltest {
    class Program {
        static void Main (string[] args) {
            String connection = "Server=localhost;" + "Database=Tienda" + "User ID=root" + "Password=root";
            IDbconnection dbcon;
            dbcon = new MySqlConnection (connection);
            IDbcommand dbcmd = dbcon.CreateCommand ();

            String sql = "Select * From combos";
        }
    }
}