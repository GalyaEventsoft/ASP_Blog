using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Dal;
using Blog.Enyities;

namespace Blog.WebUI.Controllers
{
    public class ArticleController : Controller
    {
        //
        // GET: /Article/


        [HttpGet]
        public ActionResult Index(int id)
        {
            Article article = new ArticleDal().GetArticle(id);
            ViewBag.Article = article;
            ViewBag.Comments = new CommentDal().GetComments(id);
            UserDal users = new UserDal();
            ViewBag.Name = users.GetUser(article.UserId).Name;

            return View();
        }

        [HttpPost]
        public JsonResult Index(string Comment_content, int Comment_articleId)
        {
            String comment_user = @Request.Cookies["Login"].Value;
            AddNewComment(UserIdOrDefault(comment_user), Comment_content, Comment_articleId);

            return Json(new
            {
                Comment_user = comment_user,
                Comment_content = Comment_content,
                CreationDate = DateTime.Now
            });
        }


        private void AddNewComment(int userId, string comment, int id)
        {
            if (!String.IsNullOrEmpty(comment))
            {
                new CommentDal().AddComment(new Comment()
                {
                    UserId = userId,
                    CommentText = comment,
                    ArticleID = id,
                    CreationDate = DateTime.Now
                });
            }
        }

        private int UserIdOrDefault(string login)
        {
            int userId = new UserDal().GetUserId(login);
            if (userId == 0)
            {
                userId = new UserDal().GetUserId("user");
            }
            return userId;
        }

    }
}
