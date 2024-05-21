using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExpedienteMedico
    {
        public int id { get; set; }
        public string HistorialClinico { get; set; }
        public string Alergias { get; set; }
        public string GrupoSanguindeo { get; set; }
        public Usuario? usuario { get; set; }

    }
}
