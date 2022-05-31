using CoFinder.Models;
using CoFinder.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoFinder.Controllers
{
    public class HomeController : Controller
    {
        private readonly CompanyService companyService;

        public HomeController(CompanyService companyService)
        {
            this.companyService = companyService;
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CompanySearch_VM companySearch_VM)
        {
            var result = companyService.GetCompany(companySearch_VM.NationalCode);
            return View(result);
        }

    }
}