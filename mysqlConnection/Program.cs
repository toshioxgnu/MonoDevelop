using System;
using MySql.Data.MySqlClient;

namespace mysqlConnection {
    class Program {
        static void Main (string[] args) {
            String connectionString = null;
            MySqlConnection connection1;
            connectionString = "server=localhost;database=Alumnos;uid=root;pwd=root;";
            connection1 = new MySqlConnection (connectionString);
            try {
                Console.WriteLine ("Connection stablished");
            } catch (Exception ex) {
                Console.WriteLine ("Can not open connection ! ");
            }
        }
    }
}