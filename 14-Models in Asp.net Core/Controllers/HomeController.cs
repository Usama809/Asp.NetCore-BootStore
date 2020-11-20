using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _14_Models_in_Asp.net_Core.Models;

namespace _14_Models_in_Asp.net_Core.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {       
            return View();
        }
        public ViewResult AboutUs()
        {
            return View();

        }
        public ViewResult ContactUS()
        {
            return View();
        }
    }
}
