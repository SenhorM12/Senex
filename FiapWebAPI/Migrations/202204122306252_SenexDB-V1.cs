namespace Senex.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SenexDBV1 : DbMigration
    {
        public override void Up()
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
            
            CreateTable(
                "PF0954.T_IDOSO",
                c => new
                    {
                        CPF_IDOSO = c.Int(nullable: false, identity: true),
                        NM_IDOSO = c.String(),
                        ENDR_IDOSO = c.String(),
                    })
                .PrimaryKey(t => t.CPF_IDOSO);
            
            CreateTable(
                "PF0954.Medico",
                c => new
                    {
                        CRM_MED = c.Int(nullable: false, identity: true),
                        NM_MED = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CRM_MED);
            
            CreateTable(
                "PF0954.T_POSOLOGIA",
                c => new
                    {
                        ID_REMEDIO = c.Int(nullable: false, identity: true),
                        QUANT_POSOLOGIA = c.Int(nullable: false),
                        TP_POSOLOGIA = c.String(),
                    })
                .PrimaryKey(t => t.ID_REMEDIO);
            
            CreateTable(
                "PF0954.T_USR",
                c => new
                    {
                        LOGIN_USR = c.String(nullable: false, maxLength: 128),
                        SENHA_USR = c.String(nullable: false),
                        EMAIL_USR = c.String(),
                        NOME_USR = c.String(),
                    })
                .PrimaryKey(t => t.LOGIN_USR);
            
        }
        
        public override void Down()
        {
            DropTable("PF0954.T_USR");
            DropTable("PF0954.T_POSOLOGIA");
            DropTable("PF0954.Medico");
            DropTable("PF0954.T_IDOSO");
            DropTable("PF0954.T_RESP_FMLR");
        }
    }
}
