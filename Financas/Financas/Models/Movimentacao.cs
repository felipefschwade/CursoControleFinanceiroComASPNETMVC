using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Financas.Models
{
    public class Movimentacao
    {
        public virtual Usuario Usuario { get; set; }
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public int UsuarioId { get; set; }
        public Tipo Tipo { get; set; }
    }
}