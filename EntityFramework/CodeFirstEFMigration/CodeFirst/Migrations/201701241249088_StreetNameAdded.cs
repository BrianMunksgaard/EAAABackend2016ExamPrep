namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StreetNameAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "StreetName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "StreetName");
        }
    }
}
