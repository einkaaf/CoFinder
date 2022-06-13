using CoFinder.Models;
using CoFinder.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoFinder.Controllers
{
    public class HomeController : Controller
    {
        private readonly CompanyService companyService;
        private readonly NeshanService neshanService;

        public HomeController(CompanyService companyService, NeshanService neshanService)
        {
            this.companyService = companyService;
            this.neshanService = neshanService;
        }

        public IActionResult Register()
        {
            return View();
        }   
        public IActionResult Company()
        {
            Task<NeshanResponse> result = neshanService.GetLatLongFromAddressAsync("تهران گاندی بیست و یکم");
            return View(result.Result);
        }

        [HttpPost]
        public IActionResult Register(Comapny_VM comapny_VM)
        {
            companyService.RegisterCompany(comapny_VM);
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            var result = companyService.GetAllCompany();    
            return View(result);
        } 

        [HttpGet]
        public IActionResult Index([FromQuery] string nationalCode)
        {
            var result = companyService.GetAllCompany();
            return View(result);
        }

    }
}