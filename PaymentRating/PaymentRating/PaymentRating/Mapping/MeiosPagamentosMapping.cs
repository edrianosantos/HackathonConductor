using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using PaymentRating.Models;

namespace PaymentRating.Mapping
{
    public class MeiosPagamentosMapping : EntityTypeConfiguration<MeiosPagamentos>
    {
        public MeiosPagamentosMapping()
        {
            this.ToTable("MeiosPagamentos");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.Descricao).HasMaxLength(100);

        }
    }

}