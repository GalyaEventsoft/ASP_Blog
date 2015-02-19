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
    [Authorize]
    public class NewArticleController : Controller
    {
        //
        // GET: /NewArticle/

        public ActionResult Index()
        {
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
                    UserId = GetUserId(),
                    CreationDate = DateTime.Now
                });
                return RedirectToAction("Index", "articleslist");
            }
            return View();
        }

        private int GetUserId()
        {
            UserDal users = new UserDal();
            int id = users.GetUserId(@Request.Cookies["Login"].Value);
            return id;
        }

    }
}
