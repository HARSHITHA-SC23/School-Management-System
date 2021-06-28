using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Data.Entities
{
    public class ExamType
    {
        public ExamType()
        {
            Exams = new HashSet<Exam>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }

    }
}
