using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using CourseRegistration.Models;
using mainsite.Common;
using mainsite.Models;

namespace mainsite
{
    public partial class Form2 : Form
    {
        public Lessons lesson = new Lessons();

        public Form2()
        {
            InitializeComponent();

        }

        private void btnsavedars_Click(object sender, EventArgs e)
        {

            if (txtLessonPresenting.Text == "")
            {
                lblLessonPresenting.Text = "لطفا نام درس خود را وارد نمایید!";
                lblLessonPresenting.ForeColor = Color.Red;
            }
            else
            {



                this.lesson.Lesson = txtLessonPresenting.Text;
                this.lesson.save();
                txtLessonPresenting.Text = "";
                txtLessonPresenting.Focus();
                lblLessonPresenting.Text = "درس مورد نظر با موفقیت ثبت شد!";
                lblLessonPresenting.ForeColor = Color.Green;
            }
        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnsavedars_Click(null, null);
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnBackLessonPresenting_Click(null, null);
            }
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            if (this.lesson.LessonID != null)
            {
                txtLessonPresenting.Text = this.lesson.Lesson;
            }
        }

        private void btnBackLessonPresenting_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLessonPresenting_Click(object sender, EventArgs e)
        {
            txtLessonPresenting.SelectAll();
        }
    }
}
