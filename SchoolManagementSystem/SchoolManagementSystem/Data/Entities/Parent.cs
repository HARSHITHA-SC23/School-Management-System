using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Data.Entities
{
    public class Parent
    {
        public Parent()
        {
            Students = new HashSet<Student>();
        }
        public int ID { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string FatherEmail { get; set; }
        public string MotherEmail { get; set; }
        public int Phone { get; set; }
        public virtual ICollection<Student> Students { get; set; }

    }
}
