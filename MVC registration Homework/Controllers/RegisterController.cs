using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_registration_Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_registration_Homework.Controllers
{
    public class RegisterController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }
        // GET
        public IActionResult Create()
        {
            return View();
        }

        // POST: 
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(
            [Bind("UserName,LastName,Age,Email")] RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }
            return View("Index",model);
        }
     

    }
}
