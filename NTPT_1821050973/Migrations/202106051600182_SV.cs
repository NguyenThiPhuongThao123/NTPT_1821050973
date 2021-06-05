namespace NTPT_1821050973.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SV : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sinhviens",
                c => new
                    {
                        Masv = c.String(nullable: false, maxLength: 128),
                        Hoten = c.String(),
                        Diachi = c.String(),
                    })
                .PrimaryKey(t => t.Masv);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sinhviens");
        }
    }
}
