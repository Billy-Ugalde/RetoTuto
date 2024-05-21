using Entidades;
using Microsoft.EntityFrameworkCore;
using Service.Clinicas;
using Services.MyDbContext;

namespace Services.Clinicas
{
    public class SvClinica : ISvClinica
    {
        private MyContext _myDbContext = default!;
        public SvClinica()
        {
            _myDbContext = new MyContext();
        }
        public Clinica AddClinica(Clinica Clinica)
        {
            _myDbContext.Clinicas.Add(Clinica);
            _myDbContext.SaveChanges();

            return Clinica;
        }

        public List<Clinica> GetAllClinica()
        {
            return _myDbContext.Clinicas.Include(x => x.Users).ToList();
        }
    }
}
