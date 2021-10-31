using Microsoft.AspNetCore.Mvc;
using Mvc.Models;
using Mvc.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Mvc.Controllers
{
    public class BlogController : BaseController
    {
        public IActionResult Index()
        {
            List<BlogModel> blogs = findAll();
            ViewBag.listBlog = blogs;
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
        public IActionResult Edit(int id)
        {
            Console.WriteLine(id);
            return View();
        }

        /// <summary>
        /// Find All Blog
        /// </summary>
        /// <returns></returns>
        private List<BlogModel> findAll()
        {
            return blogService.findAll();
        }

        /// <summary>
        /// Get list Blog by Title
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        private List<BlogModel> findByTitle(String title)
        {
            return blogService.findByTile(title);
        }

        [HttpDelete]
        public ActionResult deleteBlogById([FromBody] BlogModel input)
        {
            return Json(data:false);
        }
    }
}
