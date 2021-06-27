namespace Autos.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewColumnComisionInVentas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ventas", "Comision", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ventas", "Comision");
        }
    }
}
