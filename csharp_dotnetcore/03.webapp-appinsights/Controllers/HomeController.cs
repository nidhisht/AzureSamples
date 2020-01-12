using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _03.webapp_appinsights.Models;

namespace _03.webapp_appinsights.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult GenerateException()
        {
            DoSomething();
            throw new Exception("This is user generated Exception from HomeController");
        }

        private void DoSomething()
        {
            try
            {
                throw new Exception("This is exception from private methid. This will be caught.");
            }
            catch (Exception ex)
            {
                //Do nothing
            }
        }
    }
}
