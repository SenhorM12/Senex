namespace Senex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FiapContextV1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "PF0954.T_POSOLOGIA", name: "ID_REMEDIO", newName: "ID_POSOLOGIA");
            AddColumn("PF0954.T_IDOSO", "T_IDOSO_T_USR_LOGIN_USR", c => c.String());
            AddColumn("PF0954.Medico", "CONTATO_MED", c => c.Int(nullable: false));
            AddColumn("PF0954.Medico", "T_IDOSO_ID_IDOSO", c => c.Int(nullable: false));
            AddColumn("PF0954.T_POSOLOGIA", "T_REMEDIO_ID_REMEDIO", c => c.Int(nullable: false));
            AddColumn("PF0954.T_POSOLOGIA", "T_REMEDIO_ID_IDOSO", c => c.Int(nullable: false));
            AddColumn("PF0954.T_POSOLOGIA", "T_REMEDIO_LOGIN_USR", c => c.String());
            AddColumn("PF0954.T_REMEDIO", "T_IDOSO_ID_IDOSO", c => c.Int(nullable: false));
            AddColumn("PF0954.T_REMEDIO", "T_IDOSO_T_USR_LOGIN_USR", c => c.String());
            AddColumn("PF0954.T_USR", "CONTATO_USR", c => c.Int(nullable: false));
            AlterColumn("PF0954.T_IDOSO", "NM_IDOSO", c => c.String(nullable: false));
            DropTable("PF0954.T_RESP_FMLR");
        }
        
        public override void Down()
        {
            CreateTable(
                "PF0954.T_RESP_FMLR",
                c => new
                    {
                        ID_RESP = c.Int(nullable: false, identity: true),
                        NM_RESP = c.String(),
                        ENDR_RESP = c.String(),
                    })
                .PrimaryKey(t => t.ID_RESP);
            
            AlterColumn("PF0954.T_IDOSO", "NM_IDOSO", c => c.String());
            DropColumn("PF0954.T_USR", "CONTATO_USR");
            DropColumn("PF0954.T_REMEDIO", "T_IDOSO_T_USR_LOGIN_USR");
            DropColumn("PF0954.T_REMEDIO", "T_IDOSO_ID_IDOSO");
            DropColumn("PF0954.T_POSOLOGIA", "T_REMEDIO_LOGIN_USR");
            DropColumn("PF0954.T_POSOLOGIA", "T_REMEDIO_ID_IDOSO");
            DropColumn("PF0954.T_POSOLOGIA", "T_REMEDIO_ID_REMEDIO");
            DropColumn("PF0954.Medico", "T_IDOSO_ID_IDOSO");
            DropColumn("PF0954.Medico", "CONTATO_MED");
            DropColumn("PF0954.T_IDOSO", "T_IDOSO_T_USR_LOGIN_USR");
            RenameColumn(table: "PF0954.T_POSOLOGIA", name: "ID_POSOLOGIA", newName: "ID_REMEDIO");
        }
    }
}
