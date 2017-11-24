using System;
using System.Data.Entity;
using Contatos.Modelo;

namespace ContatosServices.Models
{
    public class ContatosContext : DbContext
    {
        public ContatosContext()
            :base()
        {
            
        }

        public DbSet<Evento> Eventos { get; set; }

        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
