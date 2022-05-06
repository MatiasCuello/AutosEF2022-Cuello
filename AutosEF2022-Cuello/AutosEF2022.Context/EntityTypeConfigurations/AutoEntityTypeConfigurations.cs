using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosEF2022.Context.EntityTypeConfigurations
{
    public class AutoEntityTypeConfigurations:EntityTypeConfiguration<Auto>
    {
        public AutoEntityTypeConfigurations()
        {
            ToTable("Autos");
            HasKey(a => a.AutoId);
            HasIndex(a => a.TipoDeAuto).IsUnique();
            Property(a => a.TipoDeAuto).IsRequired().HasMaxLength(50);
        }
    }
}
