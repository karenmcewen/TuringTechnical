namespace TuringTechnical.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Course_Student",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StudentID = c.Int(nullable: false),
                        CourseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.CourseID);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        CreditHours = c.Int(nullable: false),
                        MaxClassSize = c.Int(nullable: false),
                        MinClassSize = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        EnrollDate = c.DateTime(nullable: false),
                        Email = c.String(),
                        Phone = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Course_Student", "StudentID", "dbo.Students");
            DropForeignKey("dbo.Course_Student", "CourseID", "dbo.Courses");
            DropIndex("dbo.Course_Student", new[] { "CourseID" });
            DropIndex("dbo.Course_Student", new[] { "StudentID" });
            DropTable("dbo.Students");
            DropTable("dbo.Courses");
            DropTable("dbo.Course_Student");
        }
    }
}
