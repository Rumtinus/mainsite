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

        public Form3()
        {
            InitializeComponent();
        }

        private void btnbackdars_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbtarifdars_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cmbtarifdars_Click(object sender, EventArgs e)
        {

        }

        private void Form3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnbackdars_Click(null, null);
            }
        }

        private void btndeldars_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Visual studio\\Samples\\mainsite\\Database1.mdf\";Integrated Security=True";
            connection.Open();
            string q = string.Format("delete from tbldars where Id={0}", cmbtarifdars.SelectedValue);
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

            string q = string.Format("select * from tbldars");
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataReader dread = cmd.ExecuteReader();
            var dic = new Dictionary<int, string>();
            while (dread.Read())
            {
                string dars = dread["Lesson"].ToString();
                dic.Add(int.Parse(dread["Id"].ToString() ?? "0"), dars);

            }
            cmbtarifdars.DataSource = new BindingSource(dic, null);
            cmbtarifdars.DisplayMember = "Value";
            cmbtarifdars.ValueMember = "Key";
            cmbtarifdars.SelectedValue = 0;
            conn.Close();
        }

        private void btneditdars_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2();
            form2.darsId = int.Parse(cmbtarifdars.SelectedValue.ToString());
            form2.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            loadcombo();
        }
    }
}
