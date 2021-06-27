namespace Autos.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationBetweenAutosAndVentas : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ventas", "AutoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Ventas", "AutoId");
            AddForeignKey("dbo.Ventas", "AutoId", "dbo.Autos", "AutoId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ventas", "AutoId", "dbo.Autos");
            DropIndex("dbo.Ventas", new[] { "AutoId" });
            AlterColumn("dbo.Ventas", "AutoId", c => c.Int());
        }
    }
}
