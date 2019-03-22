using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_MtoMRelation
{
    public class Teacher
    {
        public Teacher()
        {
            this.students = new HashSet<Student>();
        }
        [Key]
        public int TeacherID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public virtual ICollection<Student> students { get; set; }
    }
}
