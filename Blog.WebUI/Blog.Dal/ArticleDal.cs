using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Enyities;

namespace Blog.Dal
{
    public class ArticleDal
    {
        public List<Article> GetArticles()
        {
            using (BlogEntities context = new BlogEntities())
            {
                return context.Articles.ToList();
            }
        }

        public Article GetArticle(int id)
        {
            using (BlogEntities context = new BlogEntities())
            {
                return context.Articles.Where(a=> a.Id == id).FirstOrDefault();
            }
        }

        public void AddArticle(Article article)
        {
            using (BlogEntities context = new BlogEntities())
            {
                context.Articles.Add(article);
                context.SaveChanges();
            }
        }
    }
}
