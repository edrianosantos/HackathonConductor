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
        public List<MeiosPagamentos> GetMeiosPagamentos()
        {
            var meiospagamentos = new List<MeiosPagamentos>();

            meiospagamentos.Add(new MeiosPagamentos() { Id = 1, Descricao = "Nubank MasterCard", Ativo = true });
            meiospagamentos.Add(new MeiosPagamentos() { Id = 2, Descricao = "HiperCard", Ativo = true });
            meiospagamentos.Add(new MeiosPagamentos() { Id = 3, Descricao = "Visa", Ativo = true });
            meiospagamentos.Add(new MeiosPagamentos() { Id = 4, Descricao = "American Express", Ativo = true });
            meiospagamentos.Add(new MeiosPagamentos() { Id = 5, Descricao = "Elo", Ativo = true });
            meiospagamentos.Add(new MeiosPagamentos() { Id = 6, Descricao = "Submarino MasterCard Internacional", Ativo = true });
            meiospagamentos.Add(new MeiosPagamentos() { Id = 7, Descricao = "Saraiva Visa Internacional", Ativo = true });
            meiospagamentos.Add(new MeiosPagamentos() { Id = 8, Descricao = "Petrobrás Visa Internacional", Ativo = true });
            meiospagamentos.Add(new MeiosPagamentos() { Id = 9, Descricao = "Santander Free", Ativo = true });

            return meiospagamentos;
        }
    }
}