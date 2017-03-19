namespace WickhamAthleticsData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationName : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.PanelContent");
            AddColumn("dbo.PanelContent", "PK_autContentId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.PanelContent", "PK_autContentId");
            DropColumn("dbo.PanelContent", "PK_autRowId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PanelContent", "PK_autRowId", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.PanelContent");
            DropColumn("dbo.PanelContent", "PK_autContentId");
            AddPrimaryKey("dbo.PanelContent", "PK_autRowId");
        }
    }
}
