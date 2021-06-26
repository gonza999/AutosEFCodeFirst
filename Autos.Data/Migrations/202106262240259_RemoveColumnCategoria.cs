namespace Autos.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveColumnCategoria : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Vendedores", "Categoria");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vendedores", "Categoria", c => c.String(maxLength: 255));
        }
    }
}
