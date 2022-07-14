namespace DataVoiture.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullabeCancel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FactureVente", "Prix", c => c.Decimal(nullable: false, precision: 10, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FactureVente", "Prix", c => c.Decimal(precision: 10, scale: 2));
        }
    }
}
