namespace Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "EndDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "EndDate", c => c.DateTime(nullable: false));
        }
    }
}
