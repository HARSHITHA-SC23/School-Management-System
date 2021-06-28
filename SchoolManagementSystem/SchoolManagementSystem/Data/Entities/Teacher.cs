using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Data.Entities
{
    public class Teacher
    {
        public Teacher()
        {
            Classrooms = new HashSet<Classroom>();
            Exams = new HashSet<Exam>();
            Subjects = new HashSet<Subject>();
        }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public int Phone { get; set; }
        public int Qualification { get; set; }
        public DateTime JoiningDate { get; set; }
        public virtual ICollection<Classroom> Classrooms { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }

    }
}
