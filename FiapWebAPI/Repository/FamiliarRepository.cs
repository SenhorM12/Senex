using FiapWebAPI.Models;
using FiapWebAPI.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace FiapWebAPI.Repository
{
    public class FamiliarRepository
    {
        private readonly FiapContext context;
        public FamiliarRepository()
        {
            context = new FiapContext();
        }


        public IList<Familiar> List()
        {
            return context.Familiar.ToList();
        }

        public Familiar Detail(int Id)
        {
            return context.Familiar.Find(Id);
        }

        public void Create(Familiar familiar)
        {
            context.Familiar.Add(familiar);
            context.SaveChanges();
        }

        public void Edit(Familiar familiar)
        {
        
            context.Entry(familiar).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();

        }

        public void Delete(int Id)
        {
            FiapContext context = new FiapContext();
            Familiar familiar = context.Familiar.Find(Id);
            context.Entry(familiar).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }

    }
}