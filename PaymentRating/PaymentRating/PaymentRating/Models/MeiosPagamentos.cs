using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaymentRating.Models
{
    public class MeiosPagamentos
    {
        public MeiosPagamentos()
        {
            this.Avaliacoes = new List<Avaliacao>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }

        //public virtual Avaliacao Avaliacao { get; set; }
        public virtual ICollection<Avaliacao> Avaliacoes { get; set; }

    }

}