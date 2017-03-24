using Financas.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Financas.DAO
{
    public class FinancasContext : DbContext
    {
        public DbSet<Movimentacao> MovimentacoesContext { get; set; }
        public DbSet<Usuario> UsuariosContext { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movimentacao>().HasRequired(m => m.Usuario);
            base.OnModelCreating(modelBuilder);
        }
    }
}