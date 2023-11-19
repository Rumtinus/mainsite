using CourseRegistration.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainsite
{
    public partial class Form9 : Form
    {
        public int? stuId = null;
        public Form9()
        {
            InitializeComponent();
        }


        private void Form9_Load(object sender, EventArgs e)
        {
            filler();
        }
        private void filler()
        {
            List<StudentsRegistrations> studentsRegistrations = new();
            StudentsRegistrations s = new StudentsRegistrations();
            studentsRegistrations = s.all();
            List<ShowStudentsRegistrationsData> showStudentsRegistrationsDatas = new();
            foreach (StudentsRegistrations sr in studentsRegistrations)
            {
                ShowStudentsRegistrationsData temp = new();
                temp.Id = sr.ID ?? 0;
                temp.Students = sr.student.Firstname + " " + sr.student.Lastname;
                temp.Lessons = sr.lesson.Lesson;
                temp.Terms = sr.term.Term;

                showStudentsRegistrationsDatas.Add(temp);

            }
            dataGridViewRegistration.DataSource = showStudentsRegistrationsDatas;
        }

        private void Form9_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnBackRegistrationList_Click(null, null);
            }
        }

        private void btnBackRegistrationList_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteRegistrationList_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridViewRegistration.CurrentRow.Cells[0].Value.ToString());
            StudentsRegistrations studentsRegistrations = new StudentsRegistrations();
            studentsRegistrations.ID = id;
            studentsRegistrations.delete();
            filler();
        }

        private void btnEditRegistrationList_Click(object sender, EventArgs e)
        {
            this.Close();
            Form8 form8 = new Form8();
            int id = int.Parse(dataGridViewRegistration.CurrentRow.Cells[0].Value.ToString());
            StudentsRegistrations studentsRegistrations = new StudentsRegistrations();
            studentsRegistrations.get(id);
            form8.studentsRegistrations = studentsRegistrations;
            form8.ShowDialog();
        }
    }
}
