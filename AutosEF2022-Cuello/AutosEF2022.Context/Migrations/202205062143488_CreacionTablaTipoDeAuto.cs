namespace AutosEF2022.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreacionTablaTipoDeAuto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autos",
                c => new
                    {
                        AutoId = c.Int(nullable: false, identity: true),
                        MarcaId = c.Int(nullable: false),
                        Modelo = c.String(nullable: false, maxLength: 20),
                        TipoDeAuto = c.String(nullable: false, maxLength: 50),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaisDeOrigen = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.AutoId)
                .ForeignKey("dbo.Marcas", t => t.MarcaId)
                .Index(t => t.MarcaId)
                .Index(t => t.TipoDeAuto, unique: true);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        MarcaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.MarcaId);
            
            CreateTable(
                "dbo.TiposDeAutos",
                c => new
                    {
                        TipoDeAutoId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.TipoDeAutoId)
                .Index(t => t.Descripcion, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Autos", "MarcaId", "dbo.Marcas");
            DropIndex("dbo.TiposDeAutos", new[] { "Descripcion" });
            DropIndex("dbo.Autos", new[] { "TipoDeAuto" });
            DropIndex("dbo.Autos", new[] { "MarcaId" });
            DropTable("dbo.TiposDeAutos");
            DropTable("dbo.Marcas");
            DropTable("dbo.Autos");
        }
    }
}
