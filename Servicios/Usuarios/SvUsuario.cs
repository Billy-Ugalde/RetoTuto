using Entidades;
using Microsoft.EntityFrameworkCore;
using Service.Clinicas;
using Services.MyDbContext;
using Services.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Usuarios
{
    public class SvUsuario : IsvUsuario
    {
        private MyContext _myDbContext = default!;
        public SvUsuario()
        {
            _myDbContext = new MyContext();
        }

        public Usuario AddUsuario(Usuario usuario)
        {
            _myDbContext.Usuarios.Add(usuario);
            _myDbContext.SaveChanges();

            return usuario;
        }

        public List<Usuario> GetAllUsers()
        {
            return _myDbContext.Usuarios.Include(x => x.Clinica).ToList();
        }
    }
}
