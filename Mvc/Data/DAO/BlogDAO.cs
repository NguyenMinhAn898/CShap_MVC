using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Data.DAO
{
    public class BlogDAO : BaseDAO<BlogModel>
    {
        public override string tableName => "Blog";
        public List<BlogModel> findByTitle(String title)
        {
            return findAllByTitle(title).Cast<BlogModel>().ToList();
        }

        public void iniiData()
        {
            for(int i = 1; i < 10; i++)
            {
                BlogModel newBlog = new BlogModel(i, "Blog " + i, "Blog description " + i, "img " + i, i, true, i, new DateTime());
                insertTable(newBlog);
            }
        }
    }
}
