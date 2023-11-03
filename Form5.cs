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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnbackfehrestterm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            loadcombo();
        }

        private void Form5_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnbackfehrestterm_Click(null, null);
            }
        }

        private void btndelfehrestterm_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Visual studio\\Samples\\mainsite\\Database1.mdf\";Integrated Security=True";
            connection.Open();
            string q = string.Format("delete from tblterm where Id={0}", cmbfehrestterm.SelectedValue);
            SqlCommand cmd = new SqlCommand(q, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            loadcombo();
        }
        private void loadcombo()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Visual studio\\Samples\\mainsite\\Database1.mdf\";Integrated Security=True";
            conn.Open();

            string q = string.Format("select * from tblterm");
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataReader dread = cmd.ExecuteReader();
            var dic = new Dictionary<int, string>();
            while (dread.Read())
            {
                string term = dread["Term"].ToString();
                dic.Add(int.Parse(dread["Id"].ToString() ?? "0"), term);

            }
            cmbfehrestterm.DataSource = new BindingSource(dic, null);
            cmbfehrestterm.DisplayMember = "Value";
            cmbfehrestterm.ValueMember = "Key";
            cmbfehrestterm.SelectedValue = 0;
            conn.Close();
        }

        private void btneditfehrestterm_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 form4 = new Form4();
            form4.termId = int.Parse(cmbfehrestterm.SelectedValue.ToString());
            form4.ShowDialog();
        }
    }
}
