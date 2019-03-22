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
    //@Author Yunus Emre Ertürk ===> yemrerturk@gmail.com / www.muhendiserturk.com
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStudent frm = new FormStudent();
            frm.Show();
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTeacher frm = new FormTeacher();
            frm.Show();
        }

        private void studentTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelationshipscs frm = new FormRelationshipscs();
            frm.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
