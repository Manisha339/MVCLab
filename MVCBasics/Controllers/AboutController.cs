﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        
    }
}
