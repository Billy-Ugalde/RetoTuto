using Microsoft.AspNetCore.Mvc;
using Entidades;
using Services.ExpedienteMedicos;
using Services.ExpedienteMedicos;

namespace Reto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ControllerExpediente : Controller
    {
        private IsVExpedienteMedico _svExpediente;
        public ControllerExpediente(IsVExpedienteMedico svExpediente)
        {
            _svExpediente = svExpediente;
        }


        [HttpGet]
        public IEnumerable<ExpedienteMedico> Get()
        {
            return _svExpediente.GetAllExpedientes();
        }


        [HttpPost]
        public void Post([FromBody] ExpedienteMedico expediente)
        {
            _svExpediente.AddExpedienets(expediente);
        }

    }
}
