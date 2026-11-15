using System;
using MySqlConnector;


namespace Inventory
{
    public static class database
    {


        private static readonly string connectionString =
             "Server=localhost;Port=3306;Database=inventory_db;User ID=root;Password=Inventory123;";

        public static MySqlConnection GetConnection()
        {  
            return new MySqlConnection( connectionString );
        }
    }
}
