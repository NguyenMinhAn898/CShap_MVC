using Microsoft.AspNetCore.Mvc;
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
    }
}
