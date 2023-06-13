using Application.Models;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace MedicalClinic.Controllers
{
    public class MedicalController : Controller
    {
        private readonly ITelegramService _telegramService;

        public MedicalController(ITelegramService telegramService)
        {
            _telegramService = telegramService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Service()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Feature()
        {
            return View();
        }

        public IActionResult OurDoctor()
        {
            return View();
        }
        public IActionResult Appointment()
        {
            return View();
        }

        public IActionResult Testimonial()
        {
            return View();
        }   

        [HttpPost]
        public IActionResult SendMessage([FromForm] TelegramMessageModel model)
        {
            _telegramService.SendMessage(model);
            return NoContent();
        }
    }
}
