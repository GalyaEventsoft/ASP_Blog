using Blog.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Dal;

namespace Blog.WebUI.Controllers
{
    [AllowAnonymous]
    public class RegistrationController : Controller
    {
        //
        // GET: /Registration/
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.NewTitle = "Registration";

            return View();
        }

        [HttpPost]
        public ActionResult Index(RegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Password == model.ConfirmPassword)
                {
                    UserDal users = new UserDal();
                    users.AddUser(model.Name, model.Login, model.Password);
                  
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

    }
}
