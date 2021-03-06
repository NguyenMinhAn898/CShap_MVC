using Microsoft.AspNetCore.Mvc;
using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mvc.Data;
using Mvc.Data.DAO;

namespace Mvc.Controllers
{
    public class BlogController : Controller
    {
        private BlogDAO blogDAO = new BlogDAO();
        
        public IActionResult Index()
        {
            blogDAO.iniiData();
            List<BlogModel> listBlog = getListBlog();
            ViewBag.listBlog = listBlog;

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
            return blogDAO.findAll();   
        }

        /// <summary>
        /// Get list Blog by Title
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        private List<BlogModel> findByTitle(String title)
        {
            return blogDAO.findByTitle(title);
        }
    }
}
