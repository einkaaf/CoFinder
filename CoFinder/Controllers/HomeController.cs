using CoFinder.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoFinder.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Register()
        {
            return View();
        }

    }
}