namespace Autos.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCategoriasDeVendedoresTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategoriasDeVendedores",
                c => new
                    {
                        CategoriaDeVendedorId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.CategoriaDeVendedorId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CategoriasDeVendedores");
        }
    }
}
