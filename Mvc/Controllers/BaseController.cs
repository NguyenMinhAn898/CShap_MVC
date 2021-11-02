using Microsoft.AspNetCore.Mvc;
using Mvc.Models;
using Mvc.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Controllers
{
    public class BaseController : Controller
    {
        protected BlogService blogService = new BlogService();
        protected CategoryService categoryService = new CategoryService();
        public static List<PlaceModel> listPlace = new List<PlaceModel>();
        public static List<CategoryModel> listCategory = new List<CategoryModel>();

        public List<PlaceModel> initPlace()
        {
            listPlace.Add(new PlaceModel(1, "Việt Nam"));
            listPlace.Add(new PlaceModel(2, "Châu Á"));
            listPlace.Add(new PlaceModel(3, "Châu Âu"));
            listPlace.Add(new PlaceModel(4, "Châu Mỹ"));
            listPlace.Add(new PlaceModel(5, "Thế giới"));

            return listPlace;
        }
        public List<CategoryModel> initCategory()
        {
            listCategory.Add(new CategoryModel(1, "Kinh tế"));
            listCategory.Add(new CategoryModel(2, "Chính trị"));
            listCategory.Add(new CategoryModel(3, "Văn hóa"));
            listCategory.Add(new CategoryModel(4, "Sức khỏe"));
            listCategory.Add(new CategoryModel(5, "Lao động"));
            listCategory.Add(new CategoryModel(6, "Tài chính"));

            return listCategory;
        }
    }
}
