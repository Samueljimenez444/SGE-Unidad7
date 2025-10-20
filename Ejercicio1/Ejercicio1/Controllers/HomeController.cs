using Ejercicio1.Models;
using Ejercicio1.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejercicio1.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            String hello = "";
            int hour = DateTime.Now.Hour;

            String date = DateTime.Now.ToString("dd/MM/yyyy");
            if (hour <= 12)
            {
                hello += " Good Morning sir";
            }
            else if (hour <= 18)
            {
                hello += " Good Afternoon sir";
            }
            else
            {
                hello += " Good Night sir";
            }

            clsPersona persona = new clsPersona
            {
                name = "Samuel",
                surname = "Jimenez",
                age = 19
            };
            ViewData["Message"] = hello;
            ViewBag.Date = date;
            return View(persona);
        }
       
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
