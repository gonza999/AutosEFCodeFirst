namespace Autos.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationBetweenVentasAndVendedoresAndClientes : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Ventas", "ClienteId");
            CreateIndex("dbo.Ventas", "VendedorId");
            AddForeignKey("dbo.Ventas", "ClienteId", "dbo.Clientes", "ClienteId");
            AddForeignKey("dbo.Ventas", "VendedorId", "dbo.Vendedores", "VendedorId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ventas", "VendedorId", "dbo.Vendedores");
            DropForeignKey("dbo.Ventas", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.Ventas", new[] { "VendedorId" });
            DropIndex("dbo.Ventas", new[] { "ClienteId" });
        }
    }
}
