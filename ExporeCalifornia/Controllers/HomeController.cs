using Microsoft.AspNetCore.Mvc;
namespace ExporeCalifornia.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
