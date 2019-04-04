using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Example.Web.Server.Models;
using Example.Library.Application;

namespace Example.Web.Server.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISomeRandomInterface _someRandomDependency;

        public HomeController(ISomeRandomInterface someRandomDependency)
        {
            _someRandomDependency = someRandomDependency;
        }

        public IActionResult Index()
        {
            MakeSomeMagic();
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

        public void MakeSomeMagic()
        {
            _someRandomDependency.GiveMe(true);
            _someRandomDependency.GiveMe(int.MinValue);
            _someRandomDependency.GiveMe("abcdefㅂㅈㄷㄱㅕㅑㅐㅔ");
        }
    }
}
