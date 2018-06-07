using AngleCalcASPMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngleCalcASPMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AngleCalc(AngleCalcModel model)
        {
            return View();
        }

        [HttpPost]
        public ActionResult AngleCalc(AngleCalcModel model, int hours, int mins, string action)
        {
            //model.hours = hours;
            //model.mins = mins;

            if (hours > 12)
            {
                hours = hours - 12;
            }

            int hour_angle = hours * 30;
            int mins_angle = mins * 6;

            if (mins > hours)
            {
                int result = mins_angle - hour_angle;
                if (result < 0)
                {
                    result = result * (-1);
                }
                model.result = result;
            }
            else
            {
                int result = hour_angle - mins_angle;
                if (result < 0)
                {
                    result = result * (-1);
                }
                model.result = result;
            }
            return View(model);
        }
    }
}