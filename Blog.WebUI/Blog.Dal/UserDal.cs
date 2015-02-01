using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Enyities;

namespace Blog.Dal
{
    public class UserDal
    {
        public List<BlogUser> GetUsers()
        {
            using (BlogEntities context = new BlogEntities())
            {
                return context.BlogUsers.ToList();
            }
        }

        public BlogUser GetUser(int id)
        {
            using (BlogEntities context = new BlogEntities())
            {
                return context.BlogUsers.Where(u => u.Id == id).FirstOrDefault();
            }
        }

        public int GetUserId(string name)
        {
            using (BlogEntities context = new BlogEntities())
            {
                return context.BlogUsers.Where(u => u.Name == name).Select(u => u.Id).FirstOrDefault();
            }
        }

        public void AddUser(BlogUser user)
        {
            using (BlogEntities context = new BlogEntities())
            {
                context.BlogUsers.Add(user);
                context.SaveChanges();
            }
        }
    }
}
