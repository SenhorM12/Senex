using Microsoft.EntityFrameworkCore;
using Senex.Models;
using Senex.Repository.Context;

namespace Senex.Repository
{
    public class RemedioRepository
    {
        private readonly SenexContext context;
        public RemedioRepository()
        {
            context = new SenexContext();
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
            SenexContext context = new SenexContext();
            Remedio remedio = context.Remedio.Find(Id);
            context.Entry(remedio).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }

    }
}