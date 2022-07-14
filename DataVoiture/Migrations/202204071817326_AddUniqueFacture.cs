namespace DataVoiture.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUniqueFacture : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.FactureVente", "NumFacture", unique: true);
            CreateIndex("dbo.FactureAchat", "NumFacture", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.FactureAchat", new[] { "NumFacture" });
            DropIndex("dbo.FactureVente", new[] { "NumFacture" });
        }
    }
}
