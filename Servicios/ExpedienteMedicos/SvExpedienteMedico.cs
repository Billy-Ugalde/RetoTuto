using Services.MyDbContext;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Services.ExpedienteMedicos 
{
    public class SvExpedienteMedico : IsVExpedienteMedico
    {
        private MyContext _myDbContext = default!;
        public SvExpedienteMedico()
        {
            _myDbContext = new MyContext();
        }

        public ExpedienteMedico AddExpedienets(ExpedienteMedico expediente)
        {
            _myDbContext.Expedientes.Add(expediente);
            _myDbContext.SaveChanges();

            return expediente;
        }

        public List<ExpedienteMedico> GetAllExpedientes()
        {
            return  _myDbContext.Expedientes.Include(x => x.usuario).ToList();
        }
    }
}
