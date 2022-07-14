namespace DataVoiture.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FactureVente", "Id_voiture", "dbo.VoitureVente");
            DropIndex("dbo.FactureVente", new[] { "Id_voiture" });
            AlterColumn("dbo.FactureVente", "Id_voiture", c => c.Int());
            CreateIndex("dbo.FactureVente", "Id_voiture");
            AddForeignKey("dbo.FactureVente", "Id_voiture", "dbo.VoitureVente", "Id_voiture");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FactureVente", "Id_voiture", "dbo.VoitureVente");
            DropIndex("dbo.FactureVente", new[] { "Id_voiture" });
            AlterColumn("dbo.FactureVente", "Id_voiture", c => c.Int(nullable: false));
            CreateIndex("dbo.FactureVente", "Id_voiture");
            AddForeignKey("dbo.FactureVente", "Id_voiture", "dbo.VoitureVente", "Id_voiture", cascadeDelete: true);
        }
    }
}
