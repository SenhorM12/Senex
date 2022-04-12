using FiapWebAPI.Models;
using FiapWebAPI.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace FiapWebAPI.Repository
{
    public class RemedioRepository
    {
        private readonly FiapContext context;
        public RemedioRepository()
        {
            context = new FiapContext();
        }


        public IList<Remedio> List()
        {
            return context.Remedio.ToList();
        }

        public Remedio Detail(int Id)
        {
            return context.Remedio.Find(Id);
        }


        public void Create(Remedio remedio)
        {
            context.Remedio.Add(remedio);
            context.SaveChanges();
        }

        public void Edit(Remedio remedio)
        {
        
            context.Entry(remedio).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();

        }

        public void Delete(int Id)
        {
            FiapContext context = new FiapContext();
            Remedio remedio = context.Remedio.Find(Id);
            context.Entry(remedio).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }

    }
}