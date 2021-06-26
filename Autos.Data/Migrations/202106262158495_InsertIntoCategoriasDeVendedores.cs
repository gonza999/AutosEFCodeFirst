namespace Autos.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertIntoCategoriasDeVendedores : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into CategoriasDeVendedores Values ('Senior')");
            Sql("Insert Into CategoriasDeVendedores Values ('Junior')");
        }
        
        public override void Down()
        {
            Sql("Delete CategoriasDeVendedores Where Descripcion='Senior'");
            Sql("Delete CategoriasDeVendedores Where Descripcion='Junior'");
        }
    }
}
