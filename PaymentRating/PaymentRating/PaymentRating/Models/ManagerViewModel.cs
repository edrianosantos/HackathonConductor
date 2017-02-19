using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaymentRating.Models
{
    public class ManagerViewModel
    {
        public Usuario UsuarioViewModel { get; set; }
        public Avaliacao AvaliacaoViewModel { get; set; }
        public MeiosPagamentos MeiosPagamentosViewModel { get; set; }

        
    }
}