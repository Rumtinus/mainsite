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
        public Form8()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Visual studio\\Samples\\mainsite\\Database1.mdf\";Integrated Security=True";
            conn.Open();

            string q = string.Format("select * from tbldars");
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataReader dread = cmd.ExecuteReader();
            while (dread.Read())
            {
                string columndars = dread["Lesson"].ToString();
                cmbdars.Items.Add(columndars);

            }
            conn.Close();
            conn.Open();
            string a = string.Format("select * from tblterm");
            SqlCommand cmdd = new SqlCommand(a, conn);
            SqlDataReader dreadd = cmdd.ExecuteReader();
            while (dreadd.Read())
            {
                string columnterm = dreadd["Term"].ToString();
                cmbterm.Items.Add(columnterm);

            }
            conn.Close();
            conn.Open();
            string b = string.Format("select * from tbldanesh");
            SqlCommand cmddd = new SqlCommand(b, conn);
            SqlDataReader dreaddd = cmddd.ExecuteReader();
            while (dreaddd.Read())
            {
                string columndanesh = dreaddd["Firstname"] + " " + dreaddd["Lastname"];
                cmbdanesh.Items.Add(columndanesh);

            }



            conn.Close();





            conn.Close();
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
            if (cmbdanesh.Text == "" || cmbdars.Text == "" || cmbterm.Text == "")
            {
                MessageBox.Show("!اطلاعات ناقص می باشد", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (cmbdanesh.Text != "" || cmbdars.Text != "" || cmbterm.Text != "")
            {

                save_it();
                MessageBox.Show("!دانشجو با موفقیت ثبت شد", "Processed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }
        private void save_it()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Visual studio\\Samples\\mainsite\\Database1.mdf\";Integrated Security=True";
            conn.Open();
            string q = string.Format("insert into [tblresult] (Name,Term,Lesson) values (N'{0}',{1},N'{2}')", cmbdanesh.Text, cmbterm.Text.ToString(), cmbdars.Text);
            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void Form8_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter )
            {
                btnsavesabtnam_Click(null,null);
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnbacksabtnam_Click(null, null);
            }
        }
    }
}
