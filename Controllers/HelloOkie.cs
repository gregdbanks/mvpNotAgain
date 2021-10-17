using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloOkie : Controller
    {
        // 
        // GET: /HelloOkie/

        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Okie/ 
        public IActionResult WelcomeYall(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}