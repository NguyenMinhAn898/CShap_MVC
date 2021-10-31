using Mvc.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public bool Is_active { get; set; }
        public DateTime? Updated_at { get; set; }
        public DateTime? Created_at { get; set; }
    }
}
