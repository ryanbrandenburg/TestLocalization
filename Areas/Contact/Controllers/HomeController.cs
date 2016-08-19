
using Microsoft.AspNetCore.Mvc;

namespace Mediagral.Person.Controllers
{
    [Area("Contact")]
    public class HomeController : Controller
    {        
        public HomeController()
        {
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
