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

        [HttpPost]
        public ActionResult Create(RegisterModel model)
        {
            return View("Index",model);
        }

        
    }
}
