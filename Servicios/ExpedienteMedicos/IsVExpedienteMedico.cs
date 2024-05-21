using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ExpedienteMedicos
{
    public interface IsVExpedienteMedico
    {
        public List<ExpedienteMedico> GetAllExpedientes();
        public ExpedienteMedico AddExpedienets(ExpedienteMedico expediente);
    }
}
