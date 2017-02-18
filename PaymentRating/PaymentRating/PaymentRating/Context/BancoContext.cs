using PaymentRating.Mapping;
using PaymentRating.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PaymentRating.Context
{
    public class BancoContext : DbContext
    {
        public BancoContext() : base("PaymentRating")
        {
            //throw new NotImplementedException();
        }

        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<MeiosPagamentos> MeiosPagamentos { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AvaliacaoMapping());
            modelBuilder.Configurations.Add(new MeiosPagamentosMapping());
            modelBuilder.Configurations.Add(new UsuarioMapping());
        }
    }
}