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

namespace mainsite
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        
        private void Form5_Load(object sender, EventArgs e)
        {
            loadcombo();
        }

        private void Form5_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnBackTermList_Click(null, null);
            }
        }


        private void loadcombo()
        {

            Terms T = new Terms();
            List<Terms> terms = T.all();
            var dic = new Dictionary<Terms, string>();
            foreach (Terms term in terms)
            {
                dic.Add(term, term.Term.ToString());

            }
            cmbTermList.DataSource = new BindingSource(dic, null);
            cmbTermList.DisplayMember = "Value";
            cmbTermList.ValueMember = "Key";
            cmbTermList.SelectedValue = 0;
        }

        private void btnBackTermList_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditTermList_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 form4 = new Form4();
            form4.Term = (Terms)cmbTermList.SelectedValue;
            form4.ShowDialog();

        }

        private void btnDeleteTermList_Click(object sender, EventArgs e)
        {
            
            ((Terms)cmbTermList.SelectedValue).hasStudentsRegistrations();
            if (((Terms)cmbTermList.SelectedValue).hasStudentsRegistrations())
            {
                MessageBox.Show("!ترم مورد توسط دانشجویان انتخاب شده است","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ((Terms)cmbTermList.SelectedValue).delete();
            this.loadcombo();

        }
    }
}
