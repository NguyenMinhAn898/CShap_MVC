using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Models
{
    public class BlogDataModel
    {
        public List<BlogModel> listBlogs { get; set; }
        public List<CategoryModel> listCategory { get; set; }
        public List<PlaceModel> listPlace { get; set; }
    }
}
