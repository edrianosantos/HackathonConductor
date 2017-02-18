using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using PaymentRating.Models;

namespace PaymentRating.Mapping
{
    public class AvaliacaoMapping : DbContext
    {
        public DbSet<Avaliacao> Avaliacoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Avaliacao>().ToTable("Avaliacoes");
        }
    }
}