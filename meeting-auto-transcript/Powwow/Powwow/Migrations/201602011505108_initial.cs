namespace Powwow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AudioBinaries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RecordingID = c.Int(nullable: false),
                        AudioBytes = c.Binary(),
                        AudioType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Recordings", t => t.RecordingID, cascadeDelete: true)
                .Index(t => t.RecordingID);
            
            CreateTable(
                "dbo.Recordings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SalesforceUserID = c.Int(nullable: false),
                        RecordingTime = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SalesforceUsers", t => t.SalesforceUserID, cascadeDelete: true)
                .Index(t => t.SalesforceUserID);
            
            CreateTable(
                "dbo.RecordingTexts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AudioBinaryID = c.Int(nullable: false),
                        Text = c.String(),
                        InterpreterName = c.String(),
                        Recording_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AudioBinaries", t => t.AudioBinaryID, cascadeDelete: true)
                .ForeignKey("dbo.Recordings", t => t.Recording_ID)
                .Index(t => t.AudioBinaryID)
                .Index(t => t.Recording_ID);
            
            CreateTable(
                "dbo.SalesforceUsers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SalesforceIdCode = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AudioBinaries", "RecordingID", "dbo.Recordings");
            DropForeignKey("dbo.Recordings", "SalesforceUserID", "dbo.SalesforceUsers");
            DropForeignKey("dbo.RecordingTexts", "Recording_ID", "dbo.Recordings");
            DropForeignKey("dbo.RecordingTexts", "AudioBinaryID", "dbo.AudioBinaries");
            DropIndex("dbo.RecordingTexts", new[] { "Recording_ID" });
            DropIndex("dbo.RecordingTexts", new[] { "AudioBinaryID" });
            DropIndex("dbo.Recordings", new[] { "SalesforceUserID" });
            DropIndex("dbo.AudioBinaries", new[] { "RecordingID" });
            DropTable("dbo.SalesforceUsers");
            DropTable("dbo.RecordingTexts");
            DropTable("dbo.Recordings");
            DropTable("dbo.AudioBinaries");
        }
    }
}
