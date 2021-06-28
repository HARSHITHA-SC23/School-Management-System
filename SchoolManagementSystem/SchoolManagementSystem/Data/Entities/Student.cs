using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Data.Entities
{
    public class Student
    {
        public Student()
        {
            Attendances = new HashSet<Attendance>();
            Exams = new HashSet<Exam>();
            ExamResults = new HashSet<ExamResult>();
        }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public int Phone { get; set; }
        public int? ParentID { get; set; }
        public DateTime JoiningDate { get; set; }
        public int? ClassroomID { get; set; }
        public int? ExamResultID { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual Parent Parent { get; set; }
        public virtual Classroom Classroom { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ICollection<ExamResult> ExamResults { get; set; }



    }
}
