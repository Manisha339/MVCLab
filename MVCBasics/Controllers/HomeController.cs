﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCBasics.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasics.Controllers
{
    //Attribute Routing 
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [ActionName("content")]
        public ContentResult GetContents()
        {
            return Content("This is a sample content from ContentResult");
        }

        public RedirectToRouteResult RedirectRoute()
        {
            return new RedirectToRouteResult(new { Controller = "About", Action = "Index" });
        }
        public ViewResult Index()
        {
            TempData["sessionName"] = "This is from temp data";
            return View();
        }

        public ViewResult Privacy()
        {
            ViewBag.Header = "This is coming from viewBag";
            ViewBag.Message = "Use this page to detail your site's privacy policy.";
            ViewBag.Temp = TempData["sessionName"];
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var error = new ErrorViewModel();
            error.RequestId = "fdf";
            error.Content = TempData.Peek("sessionName").ToString();

            return View(error);
        }

        [NonAction]
        public void ProcessView()
        {
            Console.WriteLine("Processing");
        }
        

    }
}
