namespace Autos.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveColumnLocalidadInClientes : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Clientes", "Localidad");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clientes", "Localidad", c => c.String(maxLength: 255));
        }
    }
}
