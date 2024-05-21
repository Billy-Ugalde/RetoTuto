using Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Clinicas
{
    public interface ISvClinica
    {
        public List<Clinica> GetAllClinica();
        public Clinica AddClinica(Clinica Clinica);

    }
}
