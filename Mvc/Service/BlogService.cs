using Mvc.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Service
{
    public class BlogService:BaseService
    {
        public BlogService() { }
        /// <summary>
        /// Get all blog
        /// </summary>
        /// <returns></returns>
        public List<BlogModel> findAll()
        {
            List<BlogModel> list = new List<BlogModel>();
            try
            {
                cnn.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("select * from blog where is_active = true", cnn.Connection);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        BlogModel blog = new BlogModel();
                        blog.Id = Convert.ToInt32(reader["id"]);
                        blog.Title = reader["title"].ToString();
                        blog.Short_Description = reader["short_description"].ToString();
                        blog.Description = reader["description"].ToString();
                        blog.Place = reader["place"].ToString();
                        blog.Is_active = Convert.ToBoolean(reader["is_active"]);

                        list.Add(blog);
                    }
                    reader.Close();
                }
                return list;
            }
            catch
            {
                return list;
            }
            finally
            {
                cnn.CloseConnection();
            }
        }

        /// <summary>
        /// Get list Blog by title
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public List<BlogModel> findByTile(String title)
        {
            List<BlogModel> list = new List<BlogModel>();
            try
            {
                cnn.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("select * from blog where title like %" + title + "% is_active = true", cnn.Connection);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        BlogModel blog = new BlogModel();
                        blog.Id = Convert.ToInt32(reader["id"]);
                        blog.Title = reader["title"].ToString();
                        blog.Short_Description = reader["short_description"].ToString();
                        blog.Description = reader["description"].ToString();
                        blog.Place = reader["place"].ToString();
                        blog.Is_active = Convert.ToBoolean(reader["is_active"]);

                        list.Add(blog);
                    }
                    reader.Close();
                }
                return list;
            }
            catch
            {
                return list;
            }
            finally
            {
                cnn.CloseConnection();
            }
        }
    }
}
