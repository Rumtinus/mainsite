using CourseRegistration.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainsite
{
    public partial class Form3 : Form
    {
        public int? darsid = null;
        public Form3()
        {
            InitializeComponent();
        }



        private void Form3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnBackLessonList_Click(null, null);
            }
        }


        private void loadcombo()
        {
            Lessons l = new Lessons();
            List<Lessons> lessons = l.all();
            var dic = new Dictionary<Lessons, string>();
            foreach (Lessons lesson in lessons)
            {
                dic.Add(lesson, lesson.Lesson);

            }
            cmbLessonPresenting.DataSource = new BindingSource(dic, null);
            cmbLessonPresenting.DisplayMember = "Value";
            cmbLessonPresenting.ValueMember = "Key";
            cmbLessonPresenting.SelectedValue = 0;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            loadcombo();
        }

        private void btnBackLessonList_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteLessonList_Click(object sender, EventArgs e)
        {
            ((Lessons)cmbLessonPresenting.SelectedValue).hasStudentsRegistrations();
            if (((Lessons)cmbLessonPresenting.SelectedValue).hasStudentsRegistrations())
            {
                MessageBox.Show("!درس مورد نظر توسط دانشجویان انتخاب شده است", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else
            {
                ((Lessons)cmbLessonPresenting.SelectedValue).delete();
                this.loadcombo();

            }

        }

        private void btnEditLessonList_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2();
            form2.lesson = (Lessons)cmbLessonPresenting.SelectedValue;
            form2.ShowDialog();
        }
    }
}
