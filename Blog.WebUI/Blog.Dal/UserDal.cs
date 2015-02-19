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
                return context.BlogUsers.Where(u => u.Login == name).Select(u => u.Id).FirstOrDefault();
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

        public void AddUser(string name, string login, string pass)
        {
            using (BlogEntities context = new BlogEntities())
            {
                BlogUser user = new BlogUser();
                user.Name = name;
                user.Login = login;
                user.Password = pass;

                context.BlogUsers.Add(user);
                context.SaveChanges();
            }
        }

        public bool IsOur(string login, string password)
        {
            using (BlogEntities context = new BlogEntities())
            {
              BlogUser user =  context.BlogUsers.Where(u => u.Login == login && u.Password == password).FirstOrDefault();
              if (user != null)
              {
                  return true;
              }
              else
              {
                  return false;
              }
            }
        }
    }
}
