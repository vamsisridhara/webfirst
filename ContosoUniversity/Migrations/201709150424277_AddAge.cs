namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAge : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "Age", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "Age");
        }
    }
}
