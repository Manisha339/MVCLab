using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasics.Controllers
{
    public class HeaderController : Controller
    {
        public PartialViewResult Index()
        {
            ViewBag.Text = "This is a partial Header view daya coming from server";
            return PartialView("_Header");
        }
    }
}
