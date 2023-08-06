using Microsoft.AspNetCore.Mvc;

namespace ResourceAggregator.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home/Index
        public IActionResult Index()
        {
            return View();
        }
    }
}
