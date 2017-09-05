using Microsoft.AspNetCore.Mvc;
using sample.Models;

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
        [HttpPost("/form")]
        [ValidateAntiForgeryToken]
        public IActionResult createUser(User user)
        {
            return Ok(user);
        }
    }
}