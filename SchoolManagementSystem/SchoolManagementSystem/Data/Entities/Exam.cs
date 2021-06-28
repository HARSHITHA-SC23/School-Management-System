using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;


namespace SchoolManagementSystem.Data.Entities
{
    public class Exam
    {
        public Exam()
        {
            ExamTypes = new HashSet<ExamType>();
            Subjects = new HashSet<Subject>();
        }
        public int ID { get; set; }
        public DateTime DateOfConduct { get; set; }
        public int StudentID { get; set; }
        public int TeacherID { get; set; }
        public int SubjectID { get; set; }
        public virtual ICollection<ExamType> ExamTypes { get; set; }
        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<ExamResult> ExamResults { get; set; }

    }
}
