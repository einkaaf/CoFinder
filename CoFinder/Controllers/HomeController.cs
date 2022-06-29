using CoFinder.Models;
using CoFinder.Service;
using CoFinder.Zibal;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoFinder.Controllers
{
    public class HomeController : Controller
    {
        private readonly CompanyService companyService;
        private readonly NeshanService neshanService;
        private readonly ZibalService zibalService;

        public HomeController(CompanyService companyService, NeshanService neshanService, ZibalService zibalService)
        {
            this.companyService = companyService;
            this.neshanService = neshanService;
            this.zibalService = zibalService;
        }

        [HttpGet]
        public IActionResult Company([FromQuery] string nationalCode)
        {
            CompanySearchResult_VM result = companyService.SearchCompany(nationalCode);

            if (string.IsNullOrWhiteSpace(nationalCode) || null == result)
            {
                return RedirectToAction("Index");
            }
            return View(result);
        }

        public IActionResult Register()
        {
            return View();
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

        public IActionResult PaymentResult([FromQuery] string result)
        {
            ViewBag.result = result;
            return View();
        }

        [HttpGet]
        public IActionResult Index([FromQuery] string nationalCode)
        {
            if(nationalCode == null)
            {
                var result = companyService.GetAllCompany();
                return View(result);
            }
            else
            {
                var result = companyService.GetAllCompany().Where(x=>x.NationalCode.Equals(nationalCode)).ToList();
                return View(result);
            }
          
        
        }

        [HttpGet]
        [Route("/Zibal")]
        public IActionResult Zibal([FromQuery] string price)
        {
            var trackid = zibalService.GetZibalTrackId(price);
            var url = "https://gateway.zibal.ir/start/" + trackid;
            return Redirect(url);
        }

        [HttpGet]
        [Route("/ZibalCallBack")]
        public IActionResult ZibalConfirm([FromQuery] string success, [FromQuery] string trackId, [FromQuery] string orderId, [FromQuery] string status)
        {
            if (success.Equals("1"))
            {
                return RedirectToAction("PaymentResult", new { result = 1 });
            }
            else
            {
                return RedirectToAction("PaymentResult", new { result = 2 });
            }

        }

    }
}