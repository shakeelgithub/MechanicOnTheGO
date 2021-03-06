namespace Web.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateTimeTypeChangedTodatetime2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contracts", "Time", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contracts", "Time", c => c.DateTime());
        }
    }
}
