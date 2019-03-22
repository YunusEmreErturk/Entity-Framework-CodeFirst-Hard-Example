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
    
    public partial class FormRelationshipscs : Form
    {
        //comboboxtan bir TeacherID cekmek icin bu degiskeni belirledim.
        int selectedTeacherID;
        //Hangi teachera students ekleyecegımı bilmek icin yukardaki variable'da aldığım idyi bu teacherı bulmak için kullanacagım.
        Teacher selectedTeacher;
        
        UniversityContext db = DbSingleTone.GetInstance();
        public FormRelationshipscs()
        {
            InitializeComponent();
        }

        //Teacher'larin combobox'a getirilmesi.
        public void FillTeachers()
        {
            var teachers = db.Teachers.Select(x => new 
            {
                x.TeacherID,
                x.Firstname,
                x.Lastname,
                Fullname = x.Firstname + " " + x.Lastname

            }).ToList();

           
            comboBoxTeachers.DisplayMember = "Fullname";
            comboBoxTeachers.ValueMember = "TeacherID";
            comboBoxTeachers.DataSource = teachers;

        }
        //Student'ların  listboxa getirilmesi.
        public void FillStudents()
        {   
            //Onemli burda new den sonra bir entity olusturmamız lazım yoksa Anonymous tip oldugu icin hata alırız ! Cünkü listboxta Combobox gibi value atama yapmak yok ! "
            List<MyEntity> students = db.Students.Select(x => new MyEntity
            {
                id=x.StudentID,
                Fullname = x.Firstname + " " + x.Lastname

            }).ToList();

            listBoxStudents.DisplayMember = "Fullname";
            listBoxStudents.ValueMember = "id";
            listBoxStudents.DataSource = students;
        }


        private void FormRelationshipscs_Load(object sender, EventArgs e)
        {
            FillTeachers();
            FillStudents();
            FillDataGridView();
        }

        //DataGridView doldurulması burada yapılıyor.
        public void FillDataGridView()
        {
            selectedTeacherID =Convert.ToInt32(comboBoxTeachers.SelectedValue);
            selectedTeacher = db.Teachers.Find(selectedTeacherID);

            var student = selectedTeacher.students.Select(x => new 
            {
                Fullname = x.Firstname + " " + x.Lastname,
                x.StudentID
              
            }).ToList();
            dataGridViewRelations.DataSource = student;

        }

        //Kilit nokta burası listboxtan secilen studentlarin id'lerini Olusturdugum MyEntity içersinde buluyorum.
        //Buldugum id ye ait student'i getiriyorum ve yeni bir Student tipinde bir referans değişkene atıyorum.
        //Bu student degiskeninin gosterdiği Student nesnesini secili teacher'in "students" larına ekliyorum .
        //Ve son olarak datagridview'i güncelliyorum.
        private void btnMakeRelation_Click(object sender, EventArgs e)
        {
            selectedTeacher = db.Teachers.Find(comboBoxTeachers.SelectedValue);
            foreach (MyEntity item in listBoxStudents.SelectedItems)
            {
                Student student = db.Students.Find(item.id);
                selectedTeacher.students.Add(student);
                db.SaveChanges();  
            }
            FillDataGridView();
            
        }

    
        //Her yeni secimde datagridviewi guncelliyorum ki hangi teacher'da hangi student'lar var gorelım .
        private void comboBoxTeachers_TextChanged(object sender, EventArgs e)
        {

            FillDataGridView();

        }
    }
}
