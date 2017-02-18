using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using PaymentRating.Models;
using System.Data.Entity.ModelConfiguration;

namespace PaymentRating.Mapping
{
    public class AvaliacaoMapping : EntityTypeConfiguration<Avaliacao>
    {
        public AvaliacaoMapping()
        {
            this.ToTable("Avaliacoes");
            this.Property(t => t.Id).HasColumnName("Id");
        }
    }
}