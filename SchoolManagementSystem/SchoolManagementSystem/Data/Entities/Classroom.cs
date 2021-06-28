using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Data.Entities
{
    public class Classroom
    {
        public Classroom()
        {
            Teachers = new HashSet<Teacher>();
            Students = new HashSet<Student>();
            Subjects = new HashSet<Subject>();
        }
        public int ID { get; set; }
        public string ClassroomName { get; set; }
        public string Section { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
