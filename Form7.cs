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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mainsite
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.LoadCombo();
        }

        private void Form7_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnBackStudentList_Click(null, null);
            }
        }

        private void LoadCombo()
        {
            Students s = new Students();
            List<Students> students = s.all();

            var dict = new Dictionary<Students, string>();

            foreach (Students student in students)
            {
                string Full_name = student.Firstname + " " + student.Lastname + " " + student.StudentNumber;
                dict.Add(student, Full_name);

            }
            cmbStudentList.DataSource = new BindingSource(dict, null);
            cmbStudentList.DisplayMember = "Value";
            cmbStudentList.ValueMember = "Key";

            cmbStudentList.SelectedValue = 0;

        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            
            ((Students)cmbStudentList.SelectedValue).hasStudentsRegistrations();
            if (((Students)cmbStudentList.SelectedValue).hasStudentsRegistrations())
            {
                MessageBox.Show(" !دانشجوی مورد نظر دارای واحد انتخابی می باشد","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ((Students)cmbStudentList.SelectedValue).delete();
            this.LoadCombo();

        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            this.Close();
            Form6 form6 = new Form6();
            form6.student = (Students)cmbStudentList.SelectedValue;
            form6.ShowDialog();

        }

        private void btnBackStudentList_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
