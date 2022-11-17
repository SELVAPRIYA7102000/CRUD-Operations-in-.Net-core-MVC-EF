using Microsoft.AspNetCore.Mvc;

namespace PersonDetailAPI.Controllers
{
    public class PersonAPIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
