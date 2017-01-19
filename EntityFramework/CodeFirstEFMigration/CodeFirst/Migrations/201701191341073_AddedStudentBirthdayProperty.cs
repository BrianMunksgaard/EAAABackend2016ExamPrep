namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedStudentBirthdayProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "StudentBirthday", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "StudentBirthday");
        }
    }
}
