using Microsoft.AspNetCore.Mvc;
using MistressObedience.Models;

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
        public IActionResult Serve(ServantModel model)
        {
            if(!ModelState.IsValid) {
                return View(model);
            }

            ViewBag.message = $"{model.Name}, aged {model.Age}, with a devotion level of {model.DevotionLevel}, you are now bound to Mistress Celeste.";
            return View(model);
        }
    }
}
