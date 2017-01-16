namespace ICD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAgreementTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agreements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AgreementTypeId = c.Int(nullable: false),
                        Status = c.String(),
                        Author = c.String(),
                        LastModifiedDate = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AgreementTypes", t => t.AgreementTypeId, cascadeDelete: true)
                .Index(t => t.AgreementTypeId);
            
            CreateTable(
                "dbo.AgreementTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Agreements", "AgreementTypeId", "dbo.AgreementTypes");
            DropIndex("dbo.Agreements", new[] { "AgreementTypeId" });
            DropTable("dbo.AgreementTypes");
            DropTable("dbo.Agreements");
        }
    }
}
