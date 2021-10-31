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
            catch (MySqlException ex)
            {
                //Most common error numbers
                //0: cannot connect to the server
                //1045: invalid username and/or password

                switch (ex.Number)
                {
                    case 0:
                        //System.Windows.Forms.MessageBox.Show("Cannot connect to server. Contact the administrator");
                        break;

                    case 1045:
                        //System.Windows.Forms.MessageBox.Show("Invalid username/password! Please try again");
                        break;
                }

                if (ex.Number != 0 || ex.Number != 1045)
                {
                    //System.Windows.Forms.MessageBox.Show(ex.Message);
                }

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
            catch (MySqlException ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
