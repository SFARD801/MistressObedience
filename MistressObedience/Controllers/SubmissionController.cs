using Microsoft.AspNetCore.Mvc;
using MistressObedience.Models;
using MistressObedience.Services;

namespace MistressObedience.Controllers
{
    public class SubmissionController : Controller
    {
        private readonly IDevotionService _devotionService;

        public SubmissionController(IDevotionService devotionService)
        {
            _devotionService = devotionService;
        }


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

            ViewBag.message = _devotionService.GetDevotionMessage(model.DevotionLevel);
            return View(model); 
        }
    }
}
