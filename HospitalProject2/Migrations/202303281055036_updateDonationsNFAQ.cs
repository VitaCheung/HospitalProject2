namespace HospitalProject2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDonationsNFAQ : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Donations", new[] { "department_Id" });
            DropIndex("dbo.FAQs", new[] { "department_Id" });
            CreateIndex("dbo.Donations", "department_id");
            CreateIndex("dbo.FAQs", "department_id");
        }

        public override void Down()
        {
            DropIndex("dbo.FAQs", new[] { "department_id" });
            DropIndex("dbo.Donations", new[] { "department_id" });
            CreateIndex("dbo.FAQs", "department_Id");
            CreateIndex("dbo.Donations", "department_Id");
        }
    }
}
