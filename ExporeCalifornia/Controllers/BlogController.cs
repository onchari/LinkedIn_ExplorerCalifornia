﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExporeCalifornia.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {
        // GET: /<controller>/
        [Route("")]
        public IActionResult Index()
        {
           
            return View();
        }

        [Route("{year:min(2000)}/{month:range(1,12)}/{key}")]
        public IActionResult Post(int year, int month, string key)
        {
            ViewBag.Title = "My First Post";
            ViewBag.Posted = DateTime.Now;
            ViewBag.Author = "Onchari Wycliffe";
            ViewBag.Body = "This is a great blog post , don't you think ?";

            return View();
        }
    }
}
