using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mvc.Models;

namespace Mvc.Data.DAO
{
    public class Database
    {
        private static Database instance = null;
        private Database() { }
        public static Database getDatabase
        {
            get
            {
                if (instance == null)
                    instance = new Database();
                return instance;
            }
        }

        private static List<BlogModel> listBlog = new List<BlogModel>();
        /// <summary>
        /// Get list blog
        /// </summary>
        public List<BlogModel> getListBlog
        {
            get
            {
                return listBlog;
            }

        }

        public int insertTable(String name, Object row)
        {
            if (name.Contains("Blog"))
            {
                return insertBlog((BlogModel)row);
            }
            return 0;
        }

        /// <summary>
        /// Insert new Blog
        /// </summary>
        /// <param name="newBlog"></param>
        /// <returns></returns>
        private int insertBlog(BlogModel newBlog)
        {
            listBlog.Add(newBlog);
            return newBlog.Id;
        }

        /// <summary>
        /// Select list Blog by title
        /// </summary>
        /// <param name="name"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public List<Object> selectTable(String name, String where = null)
        {
            if (String.Compare(name, "Blog") == 0)
            {
                if(where != null)
                {
                    return selectBlog(where).Cast<Object>().ToList();

                }
                else
                {
                    return listBlog.Cast<object>().ToList();
                }
            }
            return new List<object>();
        }

        private List<BlogModel> selectBlog(String title)
        {
            List<BlogModel> output = new List<BlogModel>();
            foreach (BlogModel blog in listBlog)
            {
                if (blog.Title.Contains(title))
                {
                    output.Add(blog);
                }
            }
            return output;
        }

        public int updateTable(String name, Object row)
        {
            return 0;
        }
        public bool deleteTable(String name, Object row)
        {
            return false;
        }
        public Object findTableById(String name, int id)
        {
            return new object();
        }
    }
}
