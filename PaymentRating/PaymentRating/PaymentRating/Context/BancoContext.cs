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
        

        public DbSet<Avaliacao> Avaliacoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AvaliacaoMapping());
        }
    }
}