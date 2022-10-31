using Microsoft.EntityFrameworkCore;
using Senex.Models;
using Senex.Repository.Context;

namespace Senex.Repository
{
    public class UserRepository
    {
        private readonly SenexContext context;
        public UserRepository()
        {
            context = new SenexContext();
        }


        public IList<User> List()
        {
            return context.User.ToList();
        }

        public User Detail(int Id)
        {
            return context.User.Find(Id);
        }


        public void Create(User user)
        {
            context.User.Add(user);
            context.SaveChanges();
        }

        public void Edit(User user)
        {

            context.Entry(user).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();

        }

        public void Delete(int Id)
        {
            SenexContext context = new SenexContext();
            User user = context.User.Find(Id);
            context.Entry(user).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }

    }
}