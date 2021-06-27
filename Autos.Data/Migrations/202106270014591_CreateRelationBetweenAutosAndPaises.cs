namespace Autos.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationBetweenAutosAndPaises : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Autos", "PaisDeOrigenId");
            AddForeignKey("dbo.Autos", "PaisDeOrigenId", "dbo.PaisesDeOrigen", "PaisDeOrigenId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Autos", "PaisDeOrigenId", "dbo.PaisesDeOrigen");
            DropIndex("dbo.Autos", new[] { "PaisDeOrigenId" });
        }
    }
}
