using SchoolManagementSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SchoolManagementSystem.Data
{
  public class SchoolContext : DbContext
    {
        public SchoolContext(): base("SchoolDB")
        {

        }
        protected override void OnModelCreating (DbModelBuilder builder)
        {
            builder.Configurations.Add(new Attendance_Configuaration());
        }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<Classroom> Classrooms { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<ExamResult> ExamResults { get; set; }
        public virtual DbSet<ExamType> ExamTypes { get; set; }
        public virtual DbSet<Parent> Parents { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }

    }
}
