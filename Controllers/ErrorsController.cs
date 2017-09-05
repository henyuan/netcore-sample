using Microsoft.AspNetCore.Mvc;

namespace sample.Controllers
{
    public class ErrorsController : Controller
    {
        [Route("/errors/{status}")]
        public IActionResult Index(int status)
        {
            ViewBag.status = status;
            return View();
        }
    }
}