namespace NTPT_1821050973.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SV3 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Sinhviens");
            AlterColumn("dbo.Sinhviens", "Masv", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Sinhviens", "Masv");
            DropColumn("dbo.Sinhviens", "ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sinhviens", "ID", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.Sinhviens");
            AlterColumn("dbo.Sinhviens", "Masv", c => c.String());
            AddPrimaryKey("dbo.Sinhviens", "ID");
        }
    }
}
