using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

       
        public ActionResult ClassList()
        {
            var model = new Entities();
            return View(model.Classes.AsEnumerable());
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Models.UserResponse userResponse)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", userResponse);
            }
            else
            {
                return View();
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        [Authorize]
        public ActionResult UserClasses()
        {
            return View();
        }

        public ActionResult EnrollClass()
        {
            return View();
        }

    }
}