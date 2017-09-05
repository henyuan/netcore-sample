using Microsoft.AspNetCore.Mvc;

namespace sample.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        [HttpGet("/index")]
        [HttpGet("/index.html")]
        public IActionResult Index()
        {
            return View();
        }
    }
}