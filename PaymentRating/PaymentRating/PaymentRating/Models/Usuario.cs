using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaymentRating.Models
{
    public class Usuario
    {
        public Usuario()
        {
            Avaliacoes = new List<Avaliacao>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual ICollection<Avaliacao> Avaliacoes { get; set; }
    }
}