namespace eManagerSystem.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentDBv1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        GradeId = c.Int(nullable: false, identity: true),
                        GradeName = c.String(),
                    })
                .PrimaryKey(t => t.GradeId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(maxLength: 100),
                        MSSV = c.Int(nullable: false),
                        CurrentGradeId = c.Int(nullable: false),
                        CurrentSubjectId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Grades", t => t.CurrentGradeId, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.CurrentSubjectId, cascadeDelete: true)
                .Index(t => t.CurrentGradeId)
                .Index(t => t.CurrentSubjectId);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        SubjectId = c.Int(nullable: false, identity: true),
                        SubjectName = c.String(),
                    })
                .PrimaryKey(t => t.SubjectId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "CurrentSubjectId", "dbo.Subjects");
            DropForeignKey("dbo.Students", "CurrentGradeId", "dbo.Grades");
            DropIndex("dbo.Students", new[] { "CurrentSubjectId" });
            DropIndex("dbo.Students", new[] { "CurrentGradeId" });
            DropTable("dbo.Subjects");
            DropTable("dbo.Students");
            DropTable("dbo.Grades");
        }
    }
}
