using Mvc.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Models
{
    public class Category
    {
        private MySqlConnect connect;
        public int Id { get; set; }
        public String Name { get; set; }
        public bool is_active { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime created_at { get; set; }
    }
}
