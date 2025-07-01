using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Gallery()
        {
            return View();
        }
        public IActionResult Service()
        {
            return View();
        }
    }
}
