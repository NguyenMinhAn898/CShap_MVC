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
            BlogDataModel data = new BlogDataModel();
            data.listBlogs = blogService.findAll();

            return View(data);
        }

        /// <summary>
        /// Blog Search view
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public IActionResult Search(BlogModel input)
        {
            BlogDataModel data = new BlogDataModel();
            data.Title_Search = input.Title;

            if (String.IsNullOrEmpty(input.Title))
            {
                data.listBlogs = blogService.findAll();
            }
            else
            {
                data.listBlogs = blogService.findByTile(input.Title);
            }
            return View(data);
        }

        /// <summary>
        /// Blog Create view
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public IActionResult Create(BlogModel input)
        {
            BlogDataModel data = new BlogDataModel();
            data.Blog = new BlogModel();
            data.listPlace = initPlace();
            data.listCategory = initCategory();

            return View(data);
        }
           
        /// <summary>
        /// Blog Edit view
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Edit(int id)
        {
            BlogDataModel data = new BlogDataModel();
            data.Blog = blogService.findById(id);
            data.listCategory = categoryService.findAll();
            data.listPlace = initPlace();
            return View(data);
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
