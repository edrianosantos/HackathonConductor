using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PaymentRating.DAO;
using PaymentRating.Models;

namespace PaymentRating.DAO
{
    public class MeiosPagamentosDAO : DAO<MeiosPagamentos>
    {
        public void SetDadosIniciais()
        {
            var meiospagamentos = new List<MeiosPagamentos>();

            meiospagamentos.Add(new MeiosPagamentos() { Descricao = "Nubank MasterCard", Ativo = true });
            meiospagamentos.Add(new MeiosPagamentos() { Descricao = "HiperCard", Ativo = true });
            meiospagamentos.Add(new MeiosPagamentos() { Descricao = "Visa", Ativo = true });
            meiospagamentos.Add(new MeiosPagamentos() { Descricao = "American Express", Ativo = true });
            meiospagamentos.Add(new MeiosPagamentos() { Descricao = "Elo", Ativo = true });
            meiospagamentos.Add(new MeiosPagamentos() { Descricao = "Submarino MasterCard Internacional", Ativo = true });
            meiospagamentos.Add(new MeiosPagamentos() { Descricao = "Saraiva Visa Internacional", Ativo = true });
            meiospagamentos.Add(new MeiosPagamentos() { Descricao = "Petrobrás Visa Internacional", Ativo = true });
            meiospagamentos.Add(new MeiosPagamentos() { Descricao = "Santander Free", Ativo = true });

            foreach (var meio in meiospagamentos)
            {
                Adicionar(meio);
            }
        }
    }
}