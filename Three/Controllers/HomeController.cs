﻿
using Microsoft.AspNetCore.Mvc;
namespace Three.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return  View();
        }
    }
}
