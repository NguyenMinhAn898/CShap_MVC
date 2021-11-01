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
        public IActionResult Search(String search)
        {
            ViewBag.listSearchBlog = findByTitle(search);
            return View();
        }
        public IActionResult Create(BlogModel input)
        {
            return View();
        }
        public IActionResult Edit(int id)
        {
            ViewBag.blog = findById(id);
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

        private BlogModel findById(int id=0)
        {
            if (id <= 0)
                return new BlogModel();
            return blogService.findById(id);
        }
        /// <summary>
        /// Delete row by id
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpDelete]
        public ActionResult deleteBlogById([FromBody] BlogModel input)
        {             
            return blogService.deletById(input.Id) ? Json(data: true) : Json(data: false); ;
        }
    }
}
