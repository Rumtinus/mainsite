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
    public partial class Form6 : Form
    {
        public int? stuId = null;
        public Students student = new Students();
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            if (student.StudentID != null)
            {
                txtNameStudent.Text = student.Firstname;
                txtLastnameStudent.Text = student.Lastname;
                txtStudentNumber.Text = student.StudentNumber.ToString();
            }
            txtNameStudent.Select();
        }


        private void Form6_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtNameStudent.ContainsFocus)
            {
                txtLastnameStudent.Focus();
            }
            else if (e.KeyCode == Keys.Enter && txtLastnameStudent.ContainsFocus)
            {
                txtStudentNumber.Focus();
            }
            else if (e.KeyCode == Keys.Enter && txtStudentNumber.ContainsFocus)
            {
                btnSaveStudent_Click(null, null);
            }



            if (e.KeyCode == Keys.Escape)
            {
                btnBackStudent_Click(null, null);
            }
        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            if (txtNameStudent.Text == "")
            {
                lblErrorStudentName.Text = "لطفا نام دانشجو را وارد نمایید!";
                lblErrorStudentName.ForeColor = Color.Red;

            }
            else
            {
                lblErrorStudentName.Text = "";
            }


            if (txtLastnameStudent.Text == "")
            {
                lblErrorStudentLastname.Text = "لطفا نام خانوادگی دانشجو را وارد نمایید!";
                lblErrorStudentLastname.ForeColor = Color.Red;
            }
            else
            {
                lblErrorStudentLastname.Text = "";
            }

            if (txtStudentNumber.Text == "")
            {
                lblErrorStudentLastname.Text = "لطفا شماره دانشجویی خود را وارد نمایید!";
                lblErrorStudentLastname.ForeColor = Color.Red;
            }
            else
            {
                lblErrorStudentLastname.Text = "";
            }


            if (txtNameStudent.ForeColor == Color.Red || txtLastnameStudent.ForeColor == Color.Red)
            {

                MessageBox.Show("!نام یا نام خانوادگی نمی تواند شامل عدد باشد", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (txtStudentNumber.ForeColor == Color.Red)
            {
                MessageBox.Show("!شماره دانشجویی نمی تواند شامل حروف باشد", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtNameStudent.Text != "" && txtLastnameStudent.Text != "" && txtStudentNumber.Text != "")
            {
                this.student.Firstname = txtNameStudent.Text;
                this.student.Lastname = txtLastnameStudent.Text;
                this.student.StudentNumber = int.Parse(txtStudentNumber.Text);
                student.save();
                txtLastnameStudent.Text = "";
                txtNameStudent.Text = "";
                txtStudentNumber.Text = "";
                lblErrorStudentName.Text = "دانشجو با موفقیت ثبت شد!";
                lblErrorStudentLastname.ForeColor = Color.Green;
            }
        }

        private void txtNameStudent_TextChanged(object sender, EventArgs e)
        {
            lblErrorStudentLastname.Text = "";
            lblErrorStudentName.Text = "";
            lblErrorStudentNumber.Text = "";
            Boolean x = txtNameStudent.Text.Any(char.IsDigit);
            if (x == true)
            {
                txtNameStudent.ForeColor = Color.Red;
            }
            else
            {
                txtNameStudent.ForeColor = Color.Black;
            }

        }

        private void txtLastnameStudent_TextChanged(object sender, EventArgs e)
        {
            lblErrorStudentLastname.Text = "";
            lblErrorStudentName.Text = "";
            lblErrorStudentNumber.Text = "";
            Boolean x = txtLastnameStudent.Text.Any(char.IsDigit);
            if (x == true)
            {
                txtLastnameStudent.ForeColor = Color.Red;
            }
            else
            {
                txtLastnameStudent.ForeColor = Color.Black;
            }
        }

        private void txtStudentNumber_TextChanged(object sender, EventArgs e)
        {
            lblErrorStudentLastname.Text = "";
            lblErrorStudentName.Text = "";
            lblErrorStudentNumber.Text = "";
            Boolean x = txtStudentNumber.Text.All(char.IsDigit);
            if (x != true)
            {
                txtStudentNumber.ForeColor = Color.Red;
            }
            else
            {
                txtStudentNumber.ForeColor = Color.Black;
            }
        }

        private void btnBackStudent_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnbackdanesh_Click(object sender, EventArgs e) { }

        private void txtNameStudent_Click(object sender, EventArgs e)
        {
            txtNameStudent.SelectAll();
        }

        private void txtLastnameStudent_Click(object sender, EventArgs e)
        {
            txtLastnameStudent.SelectAll();
        }

        private void txtStudentNumber_Click(object sender, EventArgs e)
        {
            txtStudentNumber.SelectAll();
        }
    }
}
