using FiapWebAPI.Models;
using FiapWebAPI.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace FiapWebAPI.Repository
{
    public class MedicoRepository
    {
        private readonly FiapContext context;
        public MedicoRepository()
        {
            context = new FiapContext();
        }


        public IList<Medico> List()
        {
            return context.Medico.ToList();
        }

        public Medico Detail(int Id)
        {
            return context.Medico.Find(Id);
        }


        public void Create(Medico medico)
        {
            context.Medico.Add(medico);
            context.SaveChanges();
        }

        public void Edit(Medico medico)
        {

            context.Entry(medico).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();

        }

        public void Delete(int Id)
        {
            FiapContext context = new FiapContext();
            Medico medico = context.Medico.Find(Id);
            context.Entry(medico).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }

    }
}