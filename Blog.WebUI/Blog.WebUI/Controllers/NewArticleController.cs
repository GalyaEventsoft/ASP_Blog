using Blog.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Enyities;
using Blog.Dal;

namespace Blog.WebUI.Controllers
{
    public class NewArticleController : Controller
    {
        //
        // GET: /NewArticle/

        public ActionResult Index()
        {
            //if (model.Title != null && model.Content != null)
            //{
            //    new ArticleDal().AddArticle(new Article()
            //    {
            //        Title = model.Title,
            //        Content = model.Content,
            //        ShortContent = model.ShortContent,
            //        UserId = 1,
            //        CreationDate = DateTime.Now
            //    });
            //    return RedirectToAction("Index", "RedirectToAction");
            //}
            return View();
        }

        [HttpPost]
        public ActionResult Index(ArticleContentModel model)
        {
            if (model.Title != null && model.Content != null)
            {
                new ArticleDal().AddArticle(new Article()
                {
                    Title = model.Title,
                    Content = model.Content,
                    ShortContent = model.ShortContent,
                    UserId = 1,
                    CreationDate = DateTime.Now
                });
                return RedirectToAction("Index", "articleslist");
            }
            return View();
        }

    }
}
