using Entidades;
using Services.Clinicas;

using Microsoft.AspNetCore.Mvc;
using Service.Clinicas;


namespace Reto.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ControllerClinica : ControllerBase
    { 

        private ISvClinica _svclinica;

        public ControllerClinica(ISvClinica Svclinica)
        {
             _svclinica = Svclinica;
        }


        [HttpGet]
        public IEnumerable<Clinica> Get()
        {
            return _svclinica.GetAllClinica();
        }


        [HttpPost]
        public void Post([FromBody] Clinica clinica)
        {
            _svclinica.AddClinica(clinica);
        }
    }
}
