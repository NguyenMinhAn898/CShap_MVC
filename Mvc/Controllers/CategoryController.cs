using Microsoft.AspNetCore.Mvc;
using Mvc.Db;
using Mvc.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Controllers
{
    public class CategoryController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public List<Category> FindAll()
        {
            List<Category> list = new List<Category>();

            using (MySqlConnection conn = new MySqlConnection("datasource=localhost;username=root;password=root;database=devfast_mvc"))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from category where id < 10", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Category category = new Category();
                        category.Id = Convert.ToInt32(reader["id"]);
                        category.Name = reader["name"].ToString();
                        category.is_active = Convert.ToBoolean(reader["is_active"]);

                        list.Add(category);
                    }
                    reader.Close();
                }
            }
            return list;
        }
    }
}
