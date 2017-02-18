using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using PaymentRating.Models;

namespace PaymentRating.Mapping
{
    public class UsuarioMapping : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMapping()
        {
            this.ToTable("Usuarios");
            this.HasKey(x => x.Id);
            this.Property(x => x.Nome).IsRequired().HasMaxLength(50);
            this.Property(x => x.Email).IsRequired().HasMaxLength(100);
            this.Property(x => x.Senha).IsRequired().HasMaxLength(50);
        }
    }

}