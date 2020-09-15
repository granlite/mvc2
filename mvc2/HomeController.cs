using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quadratic.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "description";
            return View();
        }
        public ActionResult Quadratic(double a, double b, double c)
        {
            var car = new { Manufacturer = "bmw", Model = "a320", MaxSpeed = 300 };
            ViewBag.carinfo = car.MaxSpeed;
            double d = Math.Pow(b, 2) - 4 * a * c;
            double e = Math.Pow(d, 0.5);
            double x1 = (-b - e) / (2 * a);
            double x2 = (-b + e) / (2 * a);
            ViewBag.x1 = x1;
            ViewBag.x2 = x2;
            if (d < 0)
            {
                return View("Quad0");
            }
            else if (d == 0)
            {
                return View("Quad1");
            }
            else
            {
                return View("Quad2");
            }
        }
    }
}