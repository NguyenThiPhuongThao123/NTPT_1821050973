namespace NTPT_1821050973.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SV1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Sinhviens");
            AddColumn("dbo.Sinhviens", "ID", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Sinhviens", "Masv", c => c.String());
            AddPrimaryKey("dbo.Sinhviens", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Sinhviens");
            AlterColumn("dbo.Sinhviens", "Masv", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Sinhviens", "ID");
            AddPrimaryKey("dbo.Sinhviens", "Masv");
        }
    }
}
