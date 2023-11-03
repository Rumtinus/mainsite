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

namespace mainsite
{
    public partial class Form2 : Form
    {
        public int? darsId = null;
        public Form2()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsavedars_Click(object sender, EventArgs e)
        {
            if (txttarifdars.Text == "")
            {
                label2.Text = "لطفا نام درس خود را وارد نمایید!";
                label2.ForeColor = Color.Red;
            }
            else
            {



                save_it();
                txttarifdars.Text = "";
                txttarifdars.Focus();
                label2.Text = "درس مورد نظر با موفقیت ثبت شد!";
                label2.ForeColor = Color.Green;
            }
        }

        private void btnbacktarifdars_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        private void save_it()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Visual studio\\Samples\\mainsite\\Database1.mdf\";Integrated Security=True";
            conn.Open();

            string q = "";

            if (darsId == null)
            {
                q = string.Format("insert into tbldars (Lesson) values (N'{0}')", txttarifdars.Text);
            }
            else
            {
                q = string.Format("update tbldars set Lesson= N'{0}' where id={1}", txttarifdars.Text, darsId);
            }
            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (darsId != null)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Visual studio\\Samples\\mainsite\\Database1.mdf\";Integrated Security=True";
                conn.Open();

                string q = string.Format("select * from tbldars where Id={0}", darsId);
                SqlCommand cmd = new SqlCommand(q, conn);
                SqlDataReader dread = cmd.ExecuteReader();
                if (dread != null)
                {

                    dread.Read();
                    txttarifdars.Text = dread["Lesson"].ToString();
                }

            }
            txttarifdars.Select();
        }

        private void btnsavedars_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnsavedars_Click(null, null);
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnbacktarifdars_Click(null, null);
            }
        }

        private void txttarifdars_Click(object sender, EventArgs e)
        {
            txttarifdars.SelectAll();
        }
    }
}
