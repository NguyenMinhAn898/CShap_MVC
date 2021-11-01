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
        /// Insert Blog
        /// </summary>
        /// <param name="blog"></param>
        /// <returns></returns>
        public String insertBlog(BlogModel blog)
        {
            string result = "";
            try
            {
                cnn.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO blog" +
                    "(id, title, short_description, description, img_url, category_id, place, public_date, status, is_active, updated_at, created_at) " +
                    "VALUES (NULL,@title,@short_description, @description, @img_url, @category_id, @place, @public_date, @status, @is_active, @updated_at, @created_at)", cnn.Connection);
                cmd.Parameters.AddWithValue("@title", blog.Title);
                cmd.Parameters.AddWithValue("@short_description", blog.Short_Description);
                cmd.Parameters.AddWithValue("@description", blog.Description);
                cmd.Parameters.AddWithValue("@img_url", blog.ImageUrl);
                cmd.Parameters.AddWithValue("@category_id", blog.Category_Id);
                cmd.Parameters.AddWithValue("@place", blog.Place);
                cmd.Parameters.AddWithValue("@public_date", blog.Public_Date);
                cmd.Parameters.AddWithValue("@status", blog.Status);
                cmd.Parameters.AddWithValue("@is_active", true);
                cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
                cmd.Parameters.AddWithValue("@created_at", DateTime.Now);

                result = cmd.ExecuteScalar().ToString();

                return result;
            }
            catch
            {
                return result;
            }
            finally
            {
                cnn.CloseConnection();
            }
        }

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
                MySqlCommand cmd = new MySqlCommand("select * from blog where title like %" + title + "% and is_active = true", cnn.Connection);

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
        /// Get blog by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public BlogModel findById(int id)
        {
            BlogModel blog = new BlogModel();
            try
            {
                cnn.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("select * from blog where id = " + id + " and is_active = true", cnn.Connection);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        blog.Id = Convert.ToInt32(reader["id"]);
                        blog.Title = reader["title"].ToString();
                        blog.Short_Description = reader["short_description"].ToString();
                        blog.Description = reader["description"].ToString();
                        blog.Place = reader["place"].ToString();
                        blog.Is_active = Convert.ToBoolean(reader["is_active"]);
                    }
                    reader.Close();
                }
                return blog;
            }
            catch
            {
                return blog;
            }
            finally
            {
                cnn.CloseConnection();
            }
        }

        /// <summary>
        /// Delete row by id
        /// Xóa mềm 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool deletById(int id)
        {
            try
            {
                cnn.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("update blog set is_active = false where id ="+id+" and is_active = true", cnn.Connection);
                cmd.ExecuteReader();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                cnn.CloseConnection();
            }
        }
    }
}
