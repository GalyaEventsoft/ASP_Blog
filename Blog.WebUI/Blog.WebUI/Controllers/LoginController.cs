using Blog.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Blog.Dal;

namespace Blog.WebUI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index()
        {
            if (!String.IsNullOrEmpty(Request.Params["Login"]))
            {
                if (Request.Cookies["Login"] != null)
                {
                    var cookie = new HttpCookie("Login")
                    {
                        Expires = DateTime.Now.AddDays(-1d)
                    };
                    Response.Cookies.Add(cookie);
                }
                FormsAuthentication.SignOut();

                return View();
            }
            else
            {
                ViewBag.NewTitle = "Log in";

                return View();
            }
        }

        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                UserDal users = new UserDal();

                if (users.IsOur(model.Login, model.Password))
                {
                    HttpCookie cookie = new HttpCookie("Login", model.Login);
                    Response.Cookies.Add(cookie);
                    FormsAuthentication.SetAuthCookie(model.Login, true);
                    return RedirectToAction("Index", "ArticlesList");
                }
                return View();
            }
            else
            {
                return View();
            }


        }

    }
}
