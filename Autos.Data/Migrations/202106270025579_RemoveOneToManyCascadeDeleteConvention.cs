namespace Autos.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveOneToManyCascadeDeleteConvention : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Autos", "PaisDeOrigenId", "dbo.PaisesDeOrigen");
            DropForeignKey("dbo.Vendedores", "CategoriaDeVendedorId", "dbo.CategoriasDeVendedores");
            DropForeignKey("dbo.Ventas", "SucursalId", "dbo.Sucursales");
            AddForeignKey("dbo.Autos", "PaisDeOrigenId", "dbo.PaisesDeOrigen", "PaisDeOrigenId");
            AddForeignKey("dbo.Vendedores", "CategoriaDeVendedorId", "dbo.CategoriasDeVendedores", "CategoriaDeVendedorId");
            AddForeignKey("dbo.Ventas", "SucursalId", "dbo.Sucursales", "SucursalId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ventas", "SucursalId", "dbo.Sucursales");
            DropForeignKey("dbo.Vendedores", "CategoriaDeVendedorId", "dbo.CategoriasDeVendedores");
            DropForeignKey("dbo.Autos", "PaisDeOrigenId", "dbo.PaisesDeOrigen");
            AddForeignKey("dbo.Ventas", "SucursalId", "dbo.Sucursales", "SucursalId", cascadeDelete: true);
            AddForeignKey("dbo.Vendedores", "CategoriaDeVendedorId", "dbo.CategoriasDeVendedores", "CategoriaDeVendedorId", cascadeDelete: true);
            AddForeignKey("dbo.Autos", "PaisDeOrigenId", "dbo.PaisesDeOrigen", "PaisDeOrigenId", cascadeDelete: true);
        }
    }
}
