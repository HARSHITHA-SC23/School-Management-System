namespace SchoolManagementSystem.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Present = c.Boolean(nullable: false),
                        Student_ID = c.Int(),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Students", t => t.Student_ID)
                .Index(t => t.Student_ID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DOB = c.DateTime(nullable: false),
                        Phone = c.Int(nullable: false),
                        ParentID = c.Int(),
                        JoiningDate = c.DateTime(nullable: false),
                        ClassroomID = c.Int(),
                        ExamResultID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Classrooms", t => t.ClassroomID)
                .ForeignKey("dbo.Parents", t => t.ParentID)
                .Index(t => t.ParentID)
                .Index(t => t.ClassroomID);
            
            CreateTable(
                "dbo.Classrooms",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ClassroomName = c.String(),
                        Section = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        SubjectName = c.String(),
                        TeacherID = c.Int(nullable: false),
                        ClassroomID = c.Int(nullable: false),
                        Exams_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Classrooms", t => t.ClassroomID, cascadeDelete: true)
                .ForeignKey("dbo.Exams", t => t.Exams_ID)
                .ForeignKey("dbo.Teachers", t => t.TeacherID, cascadeDelete: true)
                .Index(t => t.TeacherID)
                .Index(t => t.ClassroomID)
                .Index(t => t.Exams_ID);
            
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateOfConduct = c.DateTime(nullable: false),
                        StudentID = c.Int(nullable: false),
                        TeacherID = c.Int(nullable: false),
                        SubjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .ForeignKey("dbo.Teachers", t => t.TeacherID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.TeacherID);
            
            CreateTable(
                "dbo.ExamResults",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SubjectID = c.Int(nullable: false),
                        ExamID = c.Int(nullable: false),
                        Marks = c.Int(nullable: false),
                        Student_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Exams", t => t.ExamID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_ID)
                .Index(t => t.ExamID)
                .Index(t => t.Student_ID);
            
            CreateTable(
                "dbo.ExamTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DOB = c.DateTime(nullable: false),
                        Phone = c.Int(nullable: false),
                        Qualification = c.Int(nullable: false),
                        JoiningDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Parents",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FatherName = c.String(),
                        MotherName = c.String(),
                        FatherEmail = c.String(),
                        MotherEmail = c.String(),
                        Phone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ExamTypeExams",
                c => new
                    {
                        ExamType_ID = c.Int(nullable: false),
                        Exam_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ExamType_ID, t.Exam_ID })
                .ForeignKey("dbo.ExamTypes", t => t.ExamType_ID, cascadeDelete: true)
                .ForeignKey("dbo.Exams", t => t.Exam_ID, cascadeDelete: true)
                .Index(t => t.ExamType_ID)
                .Index(t => t.Exam_ID);
            
            CreateTable(
                "dbo.TeacherClassrooms",
                c => new
                    {
                        Teacher_ID = c.Int(nullable: false),
                        Classroom_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Teacher_ID, t.Classroom_ID })
                .ForeignKey("dbo.Teachers", t => t.Teacher_ID, cascadeDelete: true)
                .ForeignKey("dbo.Classrooms", t => t.Classroom_ID, cascadeDelete: true)
                .Index(t => t.Teacher_ID)
                .Index(t => t.Classroom_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "ParentID", "dbo.Parents");
            DropForeignKey("dbo.Subjects", "TeacherID", "dbo.Teachers");
            DropForeignKey("dbo.Exams", "TeacherID", "dbo.Teachers");
            DropForeignKey("dbo.TeacherClassrooms", "Classroom_ID", "dbo.Classrooms");
            DropForeignKey("dbo.TeacherClassrooms", "Teacher_ID", "dbo.Teachers");
            DropForeignKey("dbo.Subjects", "Exams_ID", "dbo.Exams");
            DropForeignKey("dbo.Exams", "StudentID", "dbo.Students");
            DropForeignKey("dbo.ExamTypeExams", "Exam_ID", "dbo.Exams");
            DropForeignKey("dbo.ExamTypeExams", "ExamType_ID", "dbo.ExamTypes");
            DropForeignKey("dbo.ExamResults", "Student_ID", "dbo.Students");
            DropForeignKey("dbo.ExamResults", "ExamID", "dbo.Exams");
            DropForeignKey("dbo.Subjects", "ClassroomID", "dbo.Classrooms");
            DropForeignKey("dbo.Students", "ClassroomID", "dbo.Classrooms");
            DropForeignKey("dbo.Attendances", "Student_ID", "dbo.Students");
            DropIndex("dbo.TeacherClassrooms", new[] { "Classroom_ID" });
            DropIndex("dbo.TeacherClassrooms", new[] { "Teacher_ID" });
            DropIndex("dbo.ExamTypeExams", new[] { "Exam_ID" });
            DropIndex("dbo.ExamTypeExams", new[] { "ExamType_ID" });
            DropIndex("dbo.ExamResults", new[] { "Student_ID" });
            DropIndex("dbo.ExamResults", new[] { "ExamID" });
            DropIndex("dbo.Exams", new[] { "TeacherID" });
            DropIndex("dbo.Exams", new[] { "StudentID" });
            DropIndex("dbo.Subjects", new[] { "Exams_ID" });
            DropIndex("dbo.Subjects", new[] { "ClassroomID" });
            DropIndex("dbo.Subjects", new[] { "TeacherID" });
            DropIndex("dbo.Students", new[] { "ClassroomID" });
            DropIndex("dbo.Students", new[] { "ParentID" });
            DropIndex("dbo.Attendances", new[] { "Student_ID" });
            DropTable("dbo.TeacherClassrooms");
            DropTable("dbo.ExamTypeExams");
            DropTable("dbo.Parents");
            DropTable("dbo.Teachers");
            DropTable("dbo.ExamTypes");
            DropTable("dbo.ExamResults");
            DropTable("dbo.Exams");
            DropTable("dbo.Subjects");
            DropTable("dbo.Classrooms");
            DropTable("dbo.Students");
            DropTable("dbo.Attendances");
        }
    }
}
