using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Enyities;
using Blog.Dal;

namespace Blog.WebUI.Controllers
{
    [AllowAnonymous]
    public class ArticlesListController : Controller
    {
        //
        // GET: /ArticlesList/
        public ActionResult Index()
        {
            ViewBag.Articles = new ArticleDal().GetArticles();
            return View();
        }

    }
}
