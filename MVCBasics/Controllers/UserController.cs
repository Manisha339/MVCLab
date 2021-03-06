using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCBasics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBasics.Controllers
{
    //Attribute Routing
    [Route("user")]
    public class UserController : Controller
    {
        // GET: UserController
        //Attribute Routing
        [Route("Index")]
        public ActionResult Index()
        {
            List<UserModel> users = new List<UserModel>();
            users.Add(new UserModel { ID = 1, Name = "Philip" });
            users.Add(new UserModel { ID = 2, Name = "Jon" });
            users.Add(new UserModel { ID = 3, Name = "Kabir" });

            ViewData["users"] = users;
            return View();
        }
        //Attribute Routing
        [Route("")]
        [Route("Form")]
        public ViewResult GetForm()
        {
            return View("Form");
        }
        [ServiceFilter(typeof(ValidationFilter))]
        [HttpPost]
        public IActionResult PostForm(EmployeeModel employee)
        {
            /*if (ModelState.IsValid)
            {
                ViewBag.FullName = " Thank you for submitting the Form " + employee.FirstName + " " + employee.LastName;

            }
            else
            {
                StringBuilder sb = new StringBuilder("");
                foreach(var value in ModelState.Values)
                {
                    if (value.Errors.Count > 0)
                    {
                        for(int i = 0; i < value.Errors.Count; i++)
                        {
                            sb.Append(value.Errors[i].ErrorMessage + "\n");
                        }
                    }
                }
                ViewBag.Error = sb.ToString();
            }*/
            ViewBag.FullName = " Thank you for submitting the Form " + employee.FirstName + " " + employee.LastName;
            return View("Form");
        }
    }
}

