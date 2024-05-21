using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Usuarios
{
    public interface IsvUsuario
    {

        public List<Usuario> GetAllUsers();
        public Usuario AddUsuario(Usuario usuario);

    }
}
