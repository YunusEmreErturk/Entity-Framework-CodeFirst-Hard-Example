using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_MtoMRelation
{
    public class Student
    {
        public Student() {
            this.teachers = new HashSet<Teacher>();
        }
        [Key]
        public int StudentID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public virtual ICollection<Teacher> teachers { get; set; }

    }
}
