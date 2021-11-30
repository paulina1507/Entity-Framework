using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_ESTILOS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.RenderCarousel = true;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            ViewBag.RenderCarousel = false;
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Your login page.";
            ViewBag.RenderCarousel = false;
            return View();
        }

        public ActionResult Privacidad()
        {
            ViewBag.Message = "Your privacity page.";
            ViewBag.RenderCarousel = false;
            return View();
        }

        public ActionResult Confidencialidad()
        {
            ViewBag.Message = "Your confidentiality page.";
            ViewBag.RenderCarousel = false;
            return View();
        }
        public ActionResult Terminos()
        {
            ViewBag.Message = "Your terms page.";
            ViewBag.RenderCarousel = false;
            return View();
        }

        public ActionResult Deslinde()
        {
            ViewBag.Message = "Your terms page.";
            ViewBag.RenderCarousel = false;
            return View();
        }
    }
}