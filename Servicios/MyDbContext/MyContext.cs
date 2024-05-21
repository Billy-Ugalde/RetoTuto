using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.MyDbContext
{
    public class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("MyDatabase");
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Clinica> Clinicas { get; set; }
        public DbSet<ExpedienteMedico> Expedientes { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Usuario>().HasOne(users => users.expedienteMedico).WithOne(ExpedienteMedico => ExpedienteMedico.usuario);

            modelBuilder.Entity<Usuario>().HasOne(usuario => usuario.Clinica).WithMany(clinica => clinica.Users);




        }
    }
}