using Microsoft.AspNetCore.Mvc;
using MistressObedience.Models;
using MistressObedience.Services;
using MistressObedience.Data;

namespace MistressObedience.Controllers
{
    public class SubmissionController : Controller
    {
        public readonly ServantContext _context;
        
        public SubmissionController(ServantContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Serve()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Serve(ServantModel model)
        {
            if(!ModelState.IsValid)
                return View(model);

            _context.Servants.Add(model);
            _context.SaveChanges();

            ViewBag.message = $"{model.Name}, your devotion is now recorded permanently.";
            return View(model); 
        }
    }
}
