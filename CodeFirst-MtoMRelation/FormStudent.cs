using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst_MtoMRelation
{
    public partial class FormStudent : Form
    {
        //Student ekleme isleminin yapildigi basit bir bölüm.

        int selectedStudentID;
        Student selectedStudent;
        UniversityContext db = DbSingleTone.GetInstance();
        public FormStudent()
        {
            InitializeComponent();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        public void FillStudents()
        {
            var students = db.Students.Select(x => new
            {
                x.StudentID,
                x.Firstname,
                x.Lastname,
                Fullname = x.Firstname+ " "+x.Lastname

            }).ToList();

            dataGridViewStudent.DataSource = students;

        }
        private void FormStudent_Load(object sender, EventArgs e)
        {
            FillStudents();
        }

        private void txtAddStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Firstname = txtFirstName.Text;
            student.Lastname = txtLastName.Text;
            db.Students.Add(student);
            db.SaveChanges();
            FillStudents();
        }

        private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedStudentID =Convert.ToInt32(dataGridViewStudent.CurrentRow.Cells["StudentID"].Value);
            selectedStudent = db.Students.Find(selectedStudentID);
        }
    }
}
