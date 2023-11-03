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
    public partial class Form4 : Form
    {
        public int? termId = null;
        public Form4()
        {
            InitializeComponent();

        }

        private void btnbacktarifterm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsavetarifterm_Click(object sender, EventArgs e)
        {
            if (txttarifterm.Text == "")
            {
                label2.Text = "لطفا ترم خود را وارد نمایید!";
                label2.ForeColor = Color.Red;
            }
            else if (txttarifterm.ForeColor == Color.Red)
            {
                MessageBox.Show("!کد ترم نمی تواند شامل حروف باشد", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                save_it();
                txttarifterm.Text = "";
                txttarifterm.Focus();
                label2.Text = "ترم مورد نظر با موفقیت ثبت شد!";
                label2.ForeColor = Color.Green;
            }




        }
        private void save_it()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Visual studio\\Samples\\mainsite\\Database1.mdf\";Integrated Security=True";
            conn.Open();
            string q = "";

            if (termId == null)
            {
                q = string.Format("insert into tblterm (Term) values ({0})", txttarifterm.Text);
            }
            else 
            {
                q = string.Format("update tblterm set Term= '{0}' where Id={1}", txttarifterm.Text, termId);
            }
            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (termId != null)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Visual studio\\Samples\\mainsite\\Database1.mdf\";Integrated Security=True";
                conn.Open();

                string q = string.Format("select * from tblterm where Id={0}", termId);
                SqlCommand cmd = new SqlCommand(q, conn);
                SqlDataReader dread = cmd.ExecuteReader();
                if (dread != null)
                {

                    dread.Read();
                    txttarifterm.Text = dread["Term"].ToString();
                }

            }
            txttarifterm.Select();
        }

        private void txttarifterm_TextChanged(object sender, EventArgs e)
        {
            Boolean x = txttarifterm.Text.All(char.IsDigit);
            if (x == true)
            {
                txttarifterm.ForeColor = Color.Black;
            }
            else
            {
                txttarifterm.ForeColor = Color.Red;
            }
        }

        private void Form4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnsavetarifterm_Click(null, null);
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnbacktarifterm_Click(null, null);
            }
        }

        private void txttarifterm_Click(object sender, EventArgs e)
        {
            txttarifterm.SelectAll();
        }
    }
}
