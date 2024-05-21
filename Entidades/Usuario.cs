using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public int id {  get; set; }
        public string nameUsuario { get; set; }
        public string contraseña { get; set; }
        public Clinica? Clinica { get; set; }
        public ExpedienteMedico? expedienteMedico { get; set; }


    }
}
