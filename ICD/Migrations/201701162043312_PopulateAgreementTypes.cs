namespace ICD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateAgreementTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO AGREEMENTTYPES (NAME) VALUES('Business')");
            Sql("INSERT INTO AGREEMENTTYPES (NAME) VALUES('Non-Disclosure')");
            Sql("INSERT INTO AGREEMENTTYPES (NAME) VALUES('MSA')");
            Sql("INSERT INTO AGREEMENTTYPES (NAME) VALUES('Legal')");
        }
        
        public override void Down()
        {
        }
    }
}
