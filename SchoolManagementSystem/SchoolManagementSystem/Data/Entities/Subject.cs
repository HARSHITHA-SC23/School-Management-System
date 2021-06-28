using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Data.Entities
{
    public class Subject
    {
        public string ID { get; set; }
        public string SubjectName { get; set; }
        public int TeacherID { get; set; }
        public int ClassroomID { get; set; }
        public virtual Classroom Classroom { get; set; }
        public virtual Exam Exams { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
