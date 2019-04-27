using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
namespace Razor_Fun.Controllers
{
    public class HomeController : Controller
    {
        public string[] Hobbies = new string[]{"Coding","Reading","Cooking"};
        public List<string> UserHobbies=new List<string>();

        [HttpGet("")]
        public IActionResult index()
        {
            return View();
        }
        [HttpPost("add")]
        public IActionResult Add(string hobby)
        {
            ViewBag.active=1;
            UserHobbies.Add(hobby);
            return View("index",UserHobbies);
        }
    }
}