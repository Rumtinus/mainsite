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

        private void btnbackfehrestdanesh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.LoadCombo();
        }

        private void btneditfehrestdanesh_Click(object sender, EventArgs e)
        {
            this.Close();
            Form6 form6 = new Form6();
            form6.stuId = int.Parse(cmbfehrastdanesh.SelectedValue.ToString());
            form6.ShowDialog();

        }

        private void btndelfehrestdanesh_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Visual studio\\Samples\\mainsite\\Database1.mdf\";Integrated Security=True";
            connection.Open();
            string q = string.Format("delete from tbldanesh where Id={0}", cmbfehrastdanesh.SelectedValue);
            SqlCommand cmd = new SqlCommand(q,connection);         
            cmd.ExecuteNonQuery();
            connection.Close();
            this.LoadCombo();


        }

        private void Form7_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnbackfehrestdanesh_Click(null, null);
            }
        }

        private void LoadCombo()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Visual studio\\Samples\\mainsite\\Database1.mdf\";Integrated Security=True";
            conn.Open();

            string q = string.Format("select * from tbldanesh");
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataReader dread = cmd.ExecuteReader();

            var dict = new Dictionary<int, string>();

            while (dread.Read())
            {
                string Full_name = dread["Firstname"] + " " + dread["Lastname"];
                dict.Add(int.Parse(dread["Id"].ToString() ?? "0"), Full_name);

            }
            cmbfehrastdanesh.DataSource = new BindingSource(dict, null);
            cmbfehrastdanesh.DisplayMember = "Value";
            cmbfehrastdanesh.ValueMember = "Key";

            cmbfehrastdanesh.SelectedValue = 0;
            conn.Close();
        }
    }
}
