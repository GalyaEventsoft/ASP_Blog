using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Enyities;

namespace Blog.Dal
{
    public class CommentDal
    {
        public List<Comment> GetComments()
        {
            using (BlogEntities context = new BlogEntities())
            {
                return context.Comments.OrderByDescending(c => c.CreationDate).ToList();
            }
        }

        public List<Comment> GetComments(int id)
        {
            using (BlogEntities context = new BlogEntities())
            {
                return context.Comments.Where(a => a.ArticleID == id).OrderByDescending(c => c.CreationDate).ToList();
            }
        }

        public void AddComment(Comment comment)
        {
            using (BlogEntities context = new BlogEntities())
            {
                context.Comments.Add(comment);
                context.SaveChanges();
            }
        }
    }
}