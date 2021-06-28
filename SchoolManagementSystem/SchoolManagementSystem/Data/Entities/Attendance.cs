using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;


namespace SchoolManagementSystem.Data.Entities
{
    public class Attendance
    {
        public int StudentID { get; set; }
        public DateTime Date { get; set; }
        public bool Present { get; set; }
        public virtual Student Student { get; set; }
    }

    public class Attendance_Configuaration : EntityTypeConfiguration<Attendance>
    {
        public Attendance_Configuaration()
        {
            HasKey(e => new { e.StudentID });
        }
    }
}
