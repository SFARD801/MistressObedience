using Microsoft.AspNetCore.Mvc;

namespace MistressObedience.Controllers
{
    public class SubmissionController : Controller
    {
        public IActionResult Serve()
        {
            return View();
        }
    }
}
