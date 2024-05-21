using Entidades;
using Services.Usuarios;

using Microsoft.AspNetCore.Mvc;

namespace Reto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControllerUsuario : ControllerBase
    {
       
       
            private IsvUsuario _svUsuario;
            public ControllerUsuario(IsvUsuario svUsuario)
            {
                _svUsuario = svUsuario;
            }

            
            [HttpGet]
            public IEnumerable<Usuario> Get()
            {
                return _svUsuario.GetAllUsers();
            }

            
            [HttpPost]
            public void Post([FromBody] Usuario usuario)
            {
                _svUsuario.AddUsuario(usuario);
            }

            
            
        
    }
}
