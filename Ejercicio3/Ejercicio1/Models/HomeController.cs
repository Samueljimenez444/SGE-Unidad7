using Ejercicio1.Models.Entity;
using Ejercicio1.Models.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejercicio1.Models
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            string hello = "";
            int hour = DateTime.Now.Hour;

            string date = DateTime.Now.ToString("dd/MM/yyyy");
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

            clsPerson persona = new clsPerson
            {
                name = "Samuel",
                surname = "Jimenez",
                age = 19
            };
            ViewData["Message"] = hello;
            ViewBag.Date = date;
            return View(persona);
        }
      
        public IActionResult listadoPersonas()
        {
            List<clsPerson> listaPersonas = Data.getPersonList();
            
            clsPerson terceraPersona = null;

            if (listaPersonas.Count >= 3)
            {
                terceraPersona = listaPersonas[2]; 
            }

            return View(terceraPersona);
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
