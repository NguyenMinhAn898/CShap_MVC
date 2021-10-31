using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Db
{
    public class DBConnect
    {
        private MySqlConnection connection;
        private string datasource;
        private string username;
        private string password;
        private string database;

        public MySqlConnection Connection { get => connection; }

        /// <summary>
        /// Constructor
        /// </summary>
        public DBConnect()
        {
            Initialize();
        }

        /// <summary>
        /// Initialize values
        /// </summary>
        private void Initialize()
        {
            datasource = "127.0.0.1";
            username = "root";
            password = "root";
            database = "devfast_mvc";

            string connectionString = "datasource=" + datasource + ";" + "username=" + username + ";" + "password=" + password + ";" + "database=" + database + ";";

            connection = new MySqlConnection(connectionString);
        }

        /// <summary>
        /// Opens a MySQL-Connection
        /// </summary>
        /// <returns></returns>
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Close a MySQL-Connection
        /// </summary>
        /// <returns></returns>
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch 
            {
                return false;
            }
        }
    }
}
