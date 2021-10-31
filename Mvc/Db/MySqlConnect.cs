using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Db
{
    public class MySqlConnect
    {
        public string ConnectionString { get; set; }

        public MySqlConnect(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnect GetConnection()
        {
            return new MySqlConnect(ConnectionString);
        }
    }
}
