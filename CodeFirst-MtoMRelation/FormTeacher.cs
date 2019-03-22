using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//@Author Yunus Emre Ertürk ===> yemrerturk@gmail.com / www.muhendiserturk.com
namespace CodeFirst_MtoMRelation
{
    public partial class FormTeacher : Form
    {
        //Teacher ekleme isleminin yapildigi basit bir bölüm.
        int selectedTeacherID;
        Teacher selectedTeacher;

        UniversityContext db = DbSingleTone.GetInstance();
        public FormTeacher()
        {
            InitializeComponent();
        }
        public void FillTeachers()
        {
            var teachers = db.Teachers.Select(x => new
            {
                x.TeacherID,
                x.Firstname,
                x.Lastname,
                Fullname = x.Firstname + " " + x.Lastname

            }).ToList();

            dataGridViewTeacher.DataSource = teachers;

        }
     
        private void FormTeacher_Load(object sender, EventArgs e)
        {
            FillTeachers();
        }

        private void txtAddTeacher_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.Firstname = txtFirstName.Text;
            teacher.Lastname = txtLastName.Text;
            db.Teachers.Add(teacher);
            db.SaveChanges();
            FillTeachers();
        }

        private void dataGridViewTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedTeacherID = Convert.ToInt32(dataGridViewTeacher.CurrentRow.Cells["TeacherID"].Value);
            selectedTeacher = db.Teachers.Find(selectedTeacherID);
        }
    }
}
