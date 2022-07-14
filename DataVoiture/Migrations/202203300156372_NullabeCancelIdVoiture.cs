namespace DataVoiture.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullabeCancelIdVoiture : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FactureVente", "Id_voiture", "dbo.VoitureVente");
            DropForeignKey("dbo.FactureAchat", "Id_voiture", "dbo.VoitureVente");
            DropIndex("dbo.FactureVente", new[] { "Id_voiture" });
            DropIndex("dbo.FactureAchat", new[] { "Id_voiture" });
            AlterColumn("dbo.FactureVente", "Id_voiture", c => c.Int(nullable: false));
            AlterColumn("dbo.FactureAchat", "Id_voiture", c => c.Int(nullable: false));
            CreateIndex("dbo.FactureVente", "Id_voiture");
            CreateIndex("dbo.FactureAchat", "Id_voiture");
            AddForeignKey("dbo.FactureVente", "Id_voiture", "dbo.VoitureVente", "Id_voiture", cascadeDelete: true);
            AddForeignKey("dbo.FactureAchat", "Id_voiture", "dbo.VoitureVente", "Id_voiture", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FactureAchat", "Id_voiture", "dbo.VoitureVente");
            DropForeignKey("dbo.FactureVente", "Id_voiture", "dbo.VoitureVente");
            DropIndex("dbo.FactureAchat", new[] { "Id_voiture" });
            DropIndex("dbo.FactureVente", new[] { "Id_voiture" });
            AlterColumn("dbo.FactureAchat", "Id_voiture", c => c.Int());
            AlterColumn("dbo.FactureVente", "Id_voiture", c => c.Int());
            CreateIndex("dbo.FactureAchat", "Id_voiture");
            CreateIndex("dbo.FactureVente", "Id_voiture");
            AddForeignKey("dbo.FactureAchat", "Id_voiture", "dbo.VoitureVente", "Id_voiture");
            AddForeignKey("dbo.FactureVente", "Id_voiture", "dbo.VoitureVente", "Id_voiture");
        }
    }
}
