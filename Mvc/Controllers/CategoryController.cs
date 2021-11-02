using Microsoft.AspNetCore.Mvc;
using Mvc.Db;
using Mvc.Models;
using Mvc.Service;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Controllers
{
    public class CategoryController : BaseController
    {
        public List<CategoryModel> FindAll()
        {
            List<CategoryModel> list = categoryService.findAll();
            
            return list;
        }
    }
}
