using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assignment03.Controllers
{
    public class AboutController : Controller
    {
       // [HttpPost]
       //displaying from about page once it is clicked.
        public ViewResult Index()
        {
          
            return View("Index");
        }
    }
}
