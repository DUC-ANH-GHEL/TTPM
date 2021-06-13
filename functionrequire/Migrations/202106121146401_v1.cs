namespace functionrequire.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HarkWorks",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Grade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.Accounts", "FullName", c => c.String(nullable: false));
            AlterColumn("dbo.Accounts", "Pass", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Accounts", "Pass", c => c.String());
            AlterColumn("dbo.Accounts", "FullName", c => c.String());
            DropTable("dbo.HarkWorks");
        }
    }
}
