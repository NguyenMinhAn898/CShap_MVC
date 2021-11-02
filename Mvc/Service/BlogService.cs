using Mvc.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Service
{
    public class BlogService : BaseService
    {
        /// <summary>
        /// Insert Blog
        /// </summary>
        /// <param name="blog"></param>
        /// <returns></returns>
        public bool insertBlog(BlogModel blog)
        {
            try
            {
                cnn.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("InsertBlog", cnn.Connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("Title", blog.Title);
                cmd.Parameters.AddWithValue("Short_Description", blog.Short_Description);
                cmd.Parameters.AddWithValue("Description", blog.Description);
                cmd.Parameters.AddWithValue("Img_Url", blog.ImageUrl);
                cmd.Parameters.AddWithValue("Category_Id", blog.Category_Id);
                cmd.Parameters.AddWithValue("Place", blog.Place);

                // parameters is boolean
                MySqlParameter param = new MySqlParameter();
                param.ParameterName = "Status_Public";
                param.Value = blog.Status;
                param.DbType = System.Data.DbType.Boolean;
                cmd.Parameters.Add(param);

                // parameters is date time
                MySqlParameter paramPublicDate = new MySqlParameter();
                paramPublicDate.ParameterName = "Public_Date";
                paramPublicDate.Value = blog.Public_Date;
                paramPublicDate.DbType = System.Data.DbType.DateTime;
                cmd.Parameters.Add(paramPublicDate);

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

        /// <summary>
        /// Get all blog
        /// </summary>
        /// <returns></returns>
        public List<BlogModel> findAll()
        {
            DataTable dt = new DataTable();
            List<BlogModel> list = new List<BlogModel>();
            try
            {
                cnn.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("GetAllBlogs", cnn.Connection);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    BlogModel blog = new BlogModel();
                    blog.Id = Convert.ToInt32(dr["id"]);
                    blog.Title = dr["title"].ToString();
                    blog.Short_Description = dr["short_description"].ToString();
                    blog.Description = dr["description"].ToString();
                    blog.ImageUrl = dr["img_url"].ToString();
                    blog.Place = dr["place"].ToString();
                    blog.Is_active = Convert.ToBoolean(dr["is_active"]);
                    blog.Public_Date = !String.IsNullOrEmpty(dr["public_date"].ToString()) ? Convert.ToDateTime(dr["public_date"]) : null;

                    list.Add(blog);
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
            DataTable dt = new DataTable();
            List<BlogModel> list = new List<BlogModel>();
            try
            {
                cnn.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("GetAllBlogsByTitle", cnn.Connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("Title", title);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    BlogModel blog = new BlogModel();
                    blog.Id = Convert.ToInt32(dr["id"]);
                    blog.Title = dr["title"].ToString();
                    blog.Short_Description = dr["short_description"].ToString();
                    blog.Description = dr["description"].ToString();
                    blog.Place = dr["place"].ToString();
                    blog.Status = Convert.ToBoolean(dr["status"]);
                    blog.ImageUrl = dr["img_url"].ToString();
                    blog.Is_active = Convert.ToBoolean(dr["is_active"]);
                    blog.Public_Date = !String.IsNullOrEmpty(dr["public_date"].ToString()) ? Convert.ToDateTime(dr["public_date"]) : null;

                    list.Add(blog);
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
            if (id <= 0)
                return null;

            DataTable dt = new DataTable();
            BlogModel blog = new BlogModel();
            try
            {
                cnn.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("GetBlogById", cnn.Connection);
                cmd.Parameters.AddWithValue("BlogId", id);
                cmd.CommandType = CommandType.StoredProcedure;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    blog.Id = Convert.ToInt32(dr["id"]);
                    blog.Category_Id = Convert.ToInt32(dr["category_id"]);
                    blog.Title = dr["title"].ToString();
                    blog.Short_Description = dr["short_description"].ToString();
                    blog.Description = dr["description"].ToString();
                    blog.Place = dr["place"].ToString();
                    blog.Status = Convert.ToBoolean(dr["status"]);
                    blog.ImageUrl = dr["img_url"].ToString();
                    blog.Is_active = Convert.ToBoolean(dr["is_active"]);
                    blog.Public_Date = !String.IsNullOrEmpty(dr["public_date"].ToString()) ? Convert.ToDateTime(dr["public_date"]) : null;
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
                MySqlCommand cmd = new MySqlCommand("DeleteBlogsById", cnn.Connection);
                cmd.Parameters.AddWithValue("BlogId", id);
                cmd.CommandType = CommandType.StoredProcedure;

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

        /// <summary>
        /// Update blog 
        /// </summary>
        /// <param name="blog"></param>
        /// <returns></returns>
        public bool update(BlogModel blog)
        {
            try
            {
                cnn.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("UpdateBlogs", cnn.Connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("Id", blog.Id);
                cmd.Parameters.AddWithValue("Title", blog.Title);
                cmd.Parameters.AddWithValue("Short_Description", blog.Short_Description);
                cmd.Parameters.AddWithValue("Description", blog.Description);
                cmd.Parameters.AddWithValue("Img_Url", blog.ImageUrl);
                cmd.Parameters.AddWithValue("Category_Id", blog.Category_Id);
                cmd.Parameters.AddWithValue("Place", blog.Place);
                // parameters is boolean
                MySqlParameter param = new MySqlParameter();
                param.ParameterName = "Status_Public";
                param.Value = blog.Status;
                param.DbType = System.Data.DbType.Boolean;
                cmd.Parameters.Add(param);

                // parameters is date time
                MySqlParameter paramPublicDate = new MySqlParameter();
                paramPublicDate.ParameterName = "Public_Date";
                paramPublicDate.Value = blog.Public_Date;
                paramPublicDate.DbType = System.Data.DbType.DateTime;
                cmd.Parameters.Add(paramPublicDate);

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
