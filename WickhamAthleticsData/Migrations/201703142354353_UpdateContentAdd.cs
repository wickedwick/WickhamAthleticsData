namespace WickhamAthleticsData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateContentAdd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.PanelContent",
                    c => new
                    {
                        PK_autContentId = c.Int(nullable: false, identity: true),
                        FK_intRowId = c.Int(nullable: true),
                        intRenderOrder = c.Int(nullable: true),
                        strContentClassName = c.String(nullable: true),
                    })
                    .PrimaryKey(t => t.PK_autContentId)
                    .ForeignKey("dbo.RowPanel", t => t.FK_intRowId, cascadeDelete: true)
                    .Index(t => t.PK_autContentId)
                    .Index(p => p.FK_intRowId);
        }
        
        public override void Down()
        {
        }
    }
}
