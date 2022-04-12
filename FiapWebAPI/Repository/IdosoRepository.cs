using FiapWebAPI.Models;
using FiapWebAPI.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace FiapWebAPI.Repository
{
    public class IdosoRepository
    {
        private readonly FiapContext context;
        public IdosoRepository()
        {
            context = new FiapContext();
        }


        public IList<Idoso> List()
        {
            return context.Idoso.ToList();
        }

        public Idoso Detail(int Id)
        {
            return context.Idoso.Find(Id);
        }


        public void Create(Idoso idoso)
        {
            context.Idoso.Add(idoso);
            context.SaveChanges();
        }

        public void Edit(Idoso idoso)
        {
        
            context.Entry(idoso).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();

        }

        public void Delete(int Id)
        {
            FiapContext context = new FiapContext();
            Idoso idoso = context.Idoso.Find(Id);
            context.Entry(idoso).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }

    }
}