namespace DataVoiture.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifierVoitureModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FactureVente", "Id_voiture", "dbo.VoitureVente");
            DropForeignKey("dbo.FactureAchat", "Id_voiture", "dbo.VoitureVente");
            DropIndex("dbo.FactureVente", new[] { "Id_voiture" });
            DropPrimaryKey("dbo.VoitureVente");
            AddColumn("dbo.FactureVente", "VoitureVente_Id", c => c.Int());
            AddColumn("dbo.VoitureVente", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.VoitureVente", "Id");
            CreateIndex("dbo.FactureVente", "VoitureVente_Id");
            AddForeignKey("dbo.FactureVente", "VoitureVente_Id", "dbo.VoitureVente", "Id");
            AddForeignKey("dbo.FactureAchat", "Id_voiture", "dbo.VoitureVente", "Id", cascadeDelete: true);
            DropColumn("dbo.VoitureVente", "Id_voiture");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VoitureVente", "Id_voiture", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.FactureAchat", "Id_voiture", "dbo.VoitureVente");
            DropForeignKey("dbo.FactureVente", "VoitureVente_Id", "dbo.VoitureVente");
            DropIndex("dbo.FactureVente", new[] { "VoitureVente_Id" });
            DropPrimaryKey("dbo.VoitureVente");
            DropColumn("dbo.VoitureVente", "Id");
            DropColumn("dbo.FactureVente", "VoitureVente_Id");
            AddPrimaryKey("dbo.VoitureVente", "Id_voiture");
            CreateIndex("dbo.FactureVente", "Id_voiture");
            AddForeignKey("dbo.FactureAchat", "Id_voiture", "dbo.VoitureVente", "Id_voiture", cascadeDelete: true);
            AddForeignKey("dbo.FactureVente", "Id_voiture", "dbo.VoitureVente", "Id_voiture");
        }
    }
}
