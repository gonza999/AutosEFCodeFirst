namespace Autos.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRalationBetweenClientesAndProvinciasAndLocalidades : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "ProvinciaId", c => c.Int(nullable: false));
            AlterColumn("dbo.Clientes", "LocalidadId", c => c.Int(nullable: false));
            CreateIndex("dbo.Clientes", "ProvinciaId");
            CreateIndex("dbo.Clientes", "LocalidadId");
            AddForeignKey("dbo.Clientes", "LocalidadId", "dbo.Localidades", "LocalidadId");
            AddForeignKey("dbo.Clientes", "ProvinciaId", "dbo.Provincias", "ProvinciaId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clientes", "ProvinciaId", "dbo.Provincias");
            DropForeignKey("dbo.Clientes", "LocalidadId", "dbo.Localidades");
            DropIndex("dbo.Clientes", new[] { "LocalidadId" });
            DropIndex("dbo.Clientes", new[] { "ProvinciaId" });
            AlterColumn("dbo.Clientes", "LocalidadId", c => c.Int());
            AlterColumn("dbo.Clientes", "ProvinciaId", c => c.Int());
        }
    }
}
