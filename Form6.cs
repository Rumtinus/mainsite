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
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            if (stuId != null) {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Visual studio\\Samples\\mainsite\\Database1.mdf\";Integrated Security=True";
                conn.Open();

                string q = string.Format("select * from tbldanesh where Id={0}", stuId );
                SqlCommand cmd = new SqlCommand(q, conn);
                SqlDataReader dread = cmd.ExecuteReader();
                if (dread != null)
                {

                    dread.Read();
                    txtnamedanesh.Text = dread["Firstname"].ToString();
                    txtlastnamedenesh.Text = dread["Lastname"].ToString();
                }

            }
                txtnamedanesh.Select();
        }


        private void save_it()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Visual studio\\Samples\\mainsite\\Database1.mdf\";Integrated Security=True";
            conn.Open();
            string q = "";
            if (stuId == null)
            {
                q = string.Format("insert into [tbldanesh] (Firstname , Lastname) values (N'{0}',N'{1}')", txtnamedanesh.Text, txtlastnamedenesh.Text);
            }
            else {
                q = string.Format("update tbldanesh set Firstname=N'{0}',Lastname=N'{1}' where Id={2}", txtnamedanesh.Text, txtlastnamedenesh.Text,stuId);
            }
            SqlCommand cmd = new SqlCommand(q, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtnamedanesh_TextChanged(object sender, EventArgs e)
        {
            label6.Text = "";
            label5.Text = "";
            Boolean x = txtnamedanesh.Text.Any(char.IsDigit);
            if (x == true)
            {
                txtnamedanesh.ForeColor = Color.Red;
            }
            else
            {
                txtnamedanesh.ForeColor = Color.Black;
            }
        }

        private void btnsavedanesh_Click(object sender, EventArgs e)
        {
            if (txtnamedanesh.Text == "")
            {
                label5.Text = "لطفا نام دانشجو را وارد نمایید!";
                label5.ForeColor = Color.Red;

            }
            else
            {
                label5.Text = "";
            }


            if (txtlastnamedenesh.Text == "")
            {
                label6.Text = "لطفا نام خانوادگی دانشجو را وارد نمایید!";
                label6.ForeColor = Color.Red;
            }
            else
            {
                label6.Text = "";
            }

            if (txtnamedanesh.ForeColor == Color.Red || txtlastnamedenesh.ForeColor == Color.Red)
            {

                MessageBox.Show("!نام یا نام خانوادگی نمی تواند شامل عدد باشد", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtnamedanesh.Text != "" && txtlastnamedenesh.Text != "")
            {
                save_it();
                txtlastnamedenesh.Text = "";
                txtnamedanesh.Text = "";
                label6.Text = "دانشجو با موفقیت ثبت شد!";
                label6.ForeColor = Color.Green;


            }
        }

        private void btnbackdanesh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtlastnamedenesh_TextChanged(object sender, EventArgs e)
        {
            label6.Text = "";
            label5.Text = "";
            Boolean x = txtlastnamedenesh.Text.Any(char.IsDigit);
            if (x == true)
            {
                txtlastnamedenesh.ForeColor = Color.Red;
            }
            else
            {
                txtlastnamedenesh.ForeColor = Color.Black;
            }
        }

        private void txtnamedanesh_Click(object sender, EventArgs e)
        {
            txtnamedanesh.SelectAll();
        }

        private void txtlastnamedenesh_Click(object sender, EventArgs e)
        {
            txtlastnamedenesh.SelectAll();
        }

        private void Form6_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtnamedanesh.ContainsFocus)
            {
                txtlastnamedenesh.Focus();
            }
            else if (e.KeyCode == Keys.Enter && txtlastnamedenesh.ContainsFocus)
            {
                btnsavedanesh_Click(null,null);
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnbackdanesh_Click(null, null);
            }
        }
    }
}
