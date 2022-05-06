using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutosEF2022.Entidades;

namespace AutosEF2022.Context.EntityTypeConfigurations
{
    public class MarcaEntityTypeConfigurations : EntityTypeConfiguration<Marca>
    {
        public MarcaEntityTypeConfigurations()
        {
            ToTable("Marcas");
            HasKey(m => m.MarcaId);
            Property(m => m.Nombre).HasMaxLength(50);
            HasMany(m => m.Autos)
            .WithRequired(m => m.Marca)
            .WillCascadeOnDelete(false);
        }

    }
}
