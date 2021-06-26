namespace Autos.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationBetweenVendedoresAndCategorias : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vendedores", "CategoriaDeVendedorId", c => c.Int(nullable: false));
            Sql("Update Vendedores Set CategoriaDeVendedorId=1");
            CreateIndex("dbo.Vendedores", "CategoriaDeVendedorId");
            AddForeignKey("dbo.Vendedores", "CategoriaDeVendedorId", "dbo.CategoriasDeVendedores", "CategoriaDeVendedorId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vendedores", "CategoriaDeVendedorId", "dbo.CategoriasDeVendedores");
            DropIndex("dbo.Vendedores", new[] { "CategoriaDeVendedorId" });
            DropColumn("dbo.Vendedores", "CategoriaDeVendedorId");
        }
    }
}
