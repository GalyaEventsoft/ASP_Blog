﻿using System;
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
            ViewBag.Article = new ArticleDal().GetArticle(id);
            ViewBag.Comments = new CommentDal().GetComments(id);
            
            return View();
        }

        //public ActionResult UpdateComment(string name, string comment, int id)
        //{
        //    AddComment(UserIdOrDefault(name), comment, id);
        
        //    ViewBag.Comments = new CommentDal().GetComments(id);
        //    if (Request.IsAjaxRequest())
        //    {
        //        return PartialView("ComentSPartial");
        //    }
        //    return View("Article");
        //}

        [HttpPost]
        public JsonResult AddComment(string Comment_user, string Comment_content, int Comment_articleId)
        {
            AddNewComment(UserIdOrDefault(Comment_user), Comment_content, Comment_articleId);
          
           return Json(new {
               Comment_user = Comment_user,
               Comment_content = Comment_content,                               
               CreationDate = DateTime.Now
               });
        }


        //[HttpPost]
        //public ActionResult Index(string name, string comment, int id)
        //{            
        //    AddComment(UserIdOrDefault(name), comment, id);

        //    ViewBag.Article = new ArticleDal().GetArticle(id);
        //    ViewBag.Comments = new CommentDal().GetComments(id);
        //    return View();

        //}

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

        private int UserIdOrDefault(string name)
        {
            int userId = new UserDal().GetUserId(name);
            if (userId == 0)
            {
                userId = new UserDal().GetUserId("User");
            }
            return userId;
        }

    }
}