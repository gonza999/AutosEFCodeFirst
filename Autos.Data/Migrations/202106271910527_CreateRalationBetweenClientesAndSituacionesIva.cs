namespace Autos.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRalationBetweenClientesAndSituacionesIva : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "SituacionIvaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Clientes", "SituacionIvaId");
            AddForeignKey("dbo.Clientes", "SituacionIvaId", "dbo.SituacionesIva", "SituacionIvaId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clientes", "SituacionIvaId", "dbo.SituacionesIva");
            DropIndex("dbo.Clientes", new[] { "SituacionIvaId" });
            AlterColumn("dbo.Clientes", "SituacionIvaId", c => c.Int());
        }
    }
}
