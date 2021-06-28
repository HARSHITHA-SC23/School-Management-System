using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Data.Entities
{
    public class ExamResult
    {
        public int ID { get; set; }
        public int SubjectID { get; set; }
        public int ExamID { get; set; }
        public int Marks { get; set; }
        public virtual Student Student { get; set; }
        public virtual Exam Exam { get; set; }

    }
   
}
