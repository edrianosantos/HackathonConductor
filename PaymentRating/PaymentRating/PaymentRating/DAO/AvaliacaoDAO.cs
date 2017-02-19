using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PaymentRating.DAO;
using PaymentRating.Models;

namespace PaymentRating.DAO
{
    public class AvaliacaoDAO : DAO<Avaliacao>
    {
        public void SalvarAvaliacao(Avaliacao avaliacao)
        {
            Adicionar(avaliacao);
            Salvar();
        }

    }
}