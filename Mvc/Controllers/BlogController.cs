using Microsoft.AspNetCore.Mvc;
using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Mvc.Controllers
{
    public class BlogController : Controller
    {
        
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Search()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }

        /// <summary>
        /// Get list Blog by name
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        private List<BlogModel> getListBlog(String title = null)
        {
            
            if(title == null)
            {
                return findAll();
            }
            else
            {
                return findByTitle(title);
            }
        }

        /// <summary>
        /// Find All Blog
        /// </summary>
        /// <returns></returns>
        private List<BlogModel> findAll()
        {
            return new List<BlogModel>();  
        }

        /// <summary>
        /// Get list Blog by Title
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        private List<BlogModel> findByTitle(String title)
        {
            return new List<BlogModel>();
        }
    }
}
