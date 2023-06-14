using Microsoft.AspNetCore.Mvc;

namespace MedicalClinic.Controllers;
public class AdminController : Controller
{
    public IActionResult Admin()
    {
        return View();
    }

    public IActionResult AddDoctor()
    {
        return View();
    }

    public IActionResult Doctors()
    {
        return View();
    }

    public IActionResult ClinicInformationSettings()
    {
        return View();
    }


}
