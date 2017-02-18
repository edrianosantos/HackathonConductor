using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaymentRating.Models
{
    public class Avaliacao
    {
        public int Id { get; set; }
        public int IdMeioPagamento { get; set; }
        public int IdUsuario { get; set; }
        public DateTime Data { get; set; }
        public int Nota { get; set; }
        public string Comentario { get; set; }
        public string Sugestao { get; set; }
        public bool Recomendar { get; set; }

        public virtual MeiosPagamentos MeioPagamento { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}