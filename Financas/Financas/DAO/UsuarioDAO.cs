using Financas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Financas.DAO
{
    public class UsuarioDAO
    {
        public UsuarioDAO(FinancasContext context)
        {
            this.Context = context;
        }

        public FinancasContext Context { get; private set; }

        public void Adiciona (Usuario Usuario)
        {
            Context.UsuariosContext.Add(Usuario);
            Context.SaveChanges();
        }

        public IList<Usuario> ListaTodos()
        {
            return Context.UsuariosContext.ToList();
        }
    }
}