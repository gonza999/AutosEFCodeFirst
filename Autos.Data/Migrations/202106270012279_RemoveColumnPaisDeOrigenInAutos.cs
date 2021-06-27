namespace Autos.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveColumnPaisDeOrigenInAutos : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Autos", "PaisDeOrigen");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Autos", "PaisDeOrigen", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
