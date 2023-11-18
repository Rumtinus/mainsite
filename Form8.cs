using CourseRegistration.Models;
using mainsite.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainsite
{
    public partial class Form8 : Form
    {
        public StudentsRegistrations studentsRegistrations = new StudentsRegistrations();
        
        public Form8()
        {
            InitializeComponent();
        }



        private void Form8_Load(object sender, EventArgs e)
        {


            Lessons l = new Lessons();
            List<Lessons> lessons = l.all();
            var dicLesson = new Dictionary<Lessons, string>();
            foreach (Lessons lesson in lessons)
            {
                dicLesson.Add(lesson, lesson.Lesson);

            }
            cmbLessonChoosing.DataSource = new BindingSource(dicLesson, null);
            cmbLessonChoosing.DisplayMember = "Value";
            cmbLessonChoosing.ValueMember = "Key";
            cmbLessonChoosing.SelectedItem = studentsRegistrations.ID != null ? studentsRegistrations : 0;


            Terms T = new Terms();
            List<Terms> terms = T.all();
            var dicTerm = new Dictionary<Terms, string>();
            foreach (Terms term in terms)
            {
                dicTerm.Add(term, term.Term.ToString());

            }
            cmbTermChoosing.DataSource = new BindingSource(dicTerm, null);
            cmbTermChoosing.DisplayMember = "Value";
            cmbTermChoosing.ValueMember = "Key";
            cmbTermChoosing.SelectedItem = studentsRegistrations.ID!=null?studentsRegistrations:0;



            Students s = new Students();
            List<Students> students = s.all();

            var dicStudent = new Dictionary<Students, string>();

            foreach (Students student in students)
            {
                string Full_name = student.Firstname + " " + student.Lastname + " " + student.StudentNumber;
                dicStudent.Add(student, Full_name);

            }
            cmbStudentChoosing.DataSource = new BindingSource(dicStudent, null);
            cmbStudentChoosing.DisplayMember = "Value";
            cmbStudentChoosing.ValueMember = "Key";
            cmbStudentChoosing.SelectedItem = studentsRegistrations.ID != null ? studentsRegistrations: 0;

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnbacksabtnam_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnsavesabtnam_Click(object sender, EventArgs e)
        {

            if (cmbStudentChoosing.Text == "" || cmbLessonChoosing.Text == "" || cmbTermChoosing.Text == "")
            {
                MessageBox.Show("!اطلاعات ناقص می باشد", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else 
            {

                studentsRegistrations.LessonID = ((Lessons)cmbLessonChoosing.SelectedValue).LessonID??0;
                studentsRegistrations.TermsID = ((Terms)cmbTermChoosing.SelectedValue).TermID ?? 0;
                studentsRegistrations.StudentsID = ((Students)cmbStudentChoosing.SelectedValue).StudentID ?? 0;
                studentsRegistrations.CreateAt =  DateTime.Now;
                studentsRegistrations.save();
                MessageBox.Show("!دانشجو با موفقیت ثبت شد", "Processed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }
        

        private void Form8_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnsavesabtnam_Click(null, null);
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnbacksabtnam_Click(null, null);
            }
        }
    }
}
