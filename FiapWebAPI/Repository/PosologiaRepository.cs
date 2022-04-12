using FiapWebAPI.Models;
using FiapWebAPI.Repository.Context;
using Microsoft.EntityFrameworkCore;
 
namespace FiapWebAPI.Repository
{
    public class PosologiaRepository
    {
        private readonly FiapContext context;
        public PosologiaRepository()
        {
            context = new FiapContext();
        }

 
        public IList<Posologia> List()
        {
            return context.Posologia.ToList();
        }

        public Posologia Detail(int Hora)
        {
            return context.Posologia.Find(Hora);
        }

        public void Create(Posologia Posologia)
        {
            context.Posologia.Add(Posologia);
            context.SaveChanges();
        }
 
        public void Edit(Posologia Posologia)
        {
        
            context.Entry(Posologia).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
 
        }

        public void Delete(int Id)
        {
            FiapContext context = new FiapContext();
            Posologia posologia = context.Posologia.Find(Id);
            context.Entry(posologia).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }

    }
}

