namespace Senex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "PF0954.T_REMEDIO",
                c => new
                    {
                        ID_REMEDIO = c.Int(nullable: false, identity: true),
                        NM_REMEDIO = c.String(nullable: false),
                        DOSG_REMEDIO = c.Double(),
                        COR_REMEDIO = c.String(),
                    })
                .PrimaryKey(t => t.ID_REMEDIO);
            
        }
        
        public override void Down()
        {
            DropTable("PF0954.T_REMEDIO");
        }
    }
}
