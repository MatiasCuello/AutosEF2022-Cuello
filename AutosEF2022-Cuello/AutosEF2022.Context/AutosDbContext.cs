using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using AutosEF2022.Context.EntityTypeConfigurations;
using AutosEF2022.Entidades;

namespace AutosEF2022.Context
{
    public partial class AutosDbContext : DbContext
    {
        public AutosDbContext()
            : base("name=AutosDbContext")
        {
        }

        public virtual DbSet<Auto> Autos { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<TipoDeAuto> TiposDeAutos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AutoEntityTypeConfigurations());
            modelBuilder.Configurations.Add(new MarcaEntityTypeConfigurations());
            modelBuilder.Configurations.Add(new TipoDeAutoEntityTypeConfigurations());
        }
    }
}
