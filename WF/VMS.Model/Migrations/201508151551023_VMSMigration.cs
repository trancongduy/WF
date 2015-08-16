namespace VMS.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VMSMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teacher",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LastName = c.String(nullable: false, maxLength: 10),
                        FirstName = c.String(nullable: false, maxLength: 10),
                        Email = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false, maxLength: 11),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teacher");
        }
    }
}
