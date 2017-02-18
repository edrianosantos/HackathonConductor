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
            this.HasKey(x => x.Id);
            this.Property(x => x.Comentario).IsRequired().HasMaxLength(300);
            this.Property(x => x.Sugestao).HasMaxLength(300);
            this.HasRequired(x => x.MeioPagamento).WithMany(x => x.Avaliacoes).HasForeignKey(t => t.IdMeioPagamento).WillCascadeOnDelete(false);
            this.HasRequired(x => x.Usuario).WithMany(x => x.Avaliacoes).HasForeignKey(t => t.IdUsuario).WillCascadeOnDelete(false);
        }
    }
}