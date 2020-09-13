using System;
using CoreMvcTutorial.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvcTutorial.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            Movie godFather = new Movie()
            {
                Title = "The Godfather",
                ReleaseDate = new DateTime(1972, 3, 24)
            };
            return View(godFather);
        }
        
    }
}