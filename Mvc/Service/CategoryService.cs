using Mvc.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Service
{
    public class CategoryService:BaseService
    {
        public List<CategoryModel> findAll()
        {
            List<CategoryModel> list = new List<CategoryModel>();

            cnn.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("select * from category where is_active=true", cnn.Connection);

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    CategoryModel category = new CategoryModel();
                    category.Id = Convert.ToInt32(reader["id"]);
                    category.Name = reader["name"].ToString();
                    category.Is_active = Convert.ToBoolean(reader["is_active"]);

                    list.Add(category);
                }
                reader.Close();
            }
            cnn.CloseConnection();

            return list;
        }
    }
}
