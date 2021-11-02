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
        /// <summary>
        /// Blog index view
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            List<BlogModel> blogs = blogService.findAll();
            ViewBag.listBlog = blogs;
            return View();
        }

        /// <summary>
        /// Blog Search view
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public IActionResult Search(BlogModel input)
        {
            if (String.IsNullOrEmpty(input.Title))
            {
                ViewBag.listSearchBlog = blogService.findAll();
            }
            else
            {
                ViewBag.listSearchBlog = blogService.findByTile(input.Title);
            }
            return View();
        }

        /// <summary>
        /// Blog Create view
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public IActionResult Create(BlogModel input)
        {
            bool check = false;
            ViewData["MessageInsert"] = "";

            if (!String.IsNullOrEmpty(input.Title))
            {
                check = true;
                bool insertChecked = blogService.insertBlog(input);                

                if (insertChecked)
                {
                    ViewData["MessageInsert"] = "Successfully added new blog!";
                }
                else
                {
                    ViewData["MessageInsert"] = "Add new blog fail !";
                }
            }
            ViewBag.CheckInsert = check;
            ViewBag.listCategory = categoryService.findAll();

            return View();
        }
           
        /// <summary>
        /// Blog Edit view
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Edit(int id)
        {
            ViewBag.blog = blogService.findById(id);
            ViewBag.listCategory = categoryService.findAll();
            return View();
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

        /// <summary>
        /// Update blog 
        /// </summary>
        /// <param name="blog"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult updateBlog(BlogModel blog)
        {
            blogService.update(blog);
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Create new Blog
        /// </summary>
        /// <param name="newBlog"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult createBlog(BlogModel newBlog)
        {
            blogService.insertBlog(newBlog);

            return RedirectToAction("Index");
        }
    }
}
