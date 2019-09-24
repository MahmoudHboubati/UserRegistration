namespace InfraStructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CREATE_USERS_TABLE : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 32),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
