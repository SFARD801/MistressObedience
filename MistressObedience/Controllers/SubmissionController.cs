using Microsoft.AspNetCore.Mvc;

namespace MistressObedience.Controllers
{
    public class SubmissionController : Controller
    {
        [HttpGet]
        public IActionResult Serve()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Serve(string servantName)
        {
            ViewBag.message = $"{servantName}, you belong to Mistress Celeste.";
            return View();
        }
    }
}
