using Microsoft.EntityFrameworkCore;
using Senex.Models;
using Senex.Repository.Context;

namespace Senex.Repository
{
    public class IdosoRepository
    {
        private readonly SenexContext context;
        public IdosoRepository()
        {
            context = new SenexContext();
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
            SenexContext context = new SenexContext();
            Idoso idoso = context.Idoso.Find(Id);
            context.Entry(idoso).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }

    }
}