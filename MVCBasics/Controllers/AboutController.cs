using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MVCBasics.Controllers
{
    public class AboutController : Controller
    {
        // GET: AboutController
        public String Index()
        {
            return "This is about Controller";
        }

        public JsonResult Content()
        {
            string data = System.IO.File.ReadAllText("./wwwroot/Content.json");
            JObject json = JObject.Parse(data);
            return Json(data);
        }
        
    }
}
