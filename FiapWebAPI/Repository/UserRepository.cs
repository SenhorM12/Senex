using FiapWebAPI.Models;
using FiapWebAPI.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace FiapWebAPI.Repository
{
    public class UserRepository
    {
        private readonly FiapContext context;
        public UserRepository()
        {
            context = new FiapContext();
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
            FiapContext context = new FiapContext();
            User user = context.User.Find(Id);
            context.Entry(user).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }

    }
}