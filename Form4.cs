using CourseRegistration.Models;
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
        public Terms Term = new Terms();

        public Form4()
        {
            InitializeComponent();

        }

        private void Form4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSaveTerm_Click(null, null);
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnBackTermPresenting_Click(null, null);
            }
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            if (Term.TermID != null)
            {
                txtTermPresenting.Text = this.Term.Term.ToString();
            }
        }

        private void btnBackTermPresenting_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTermPresenting_Click(object sender, EventArgs e)
        {
            txtTermPresenting.SelectAll();
        }

        private void txtTermPresenting_TextChanged(object sender, EventArgs e)
        {
            Boolean x = txtTermPresenting.Text.All(char.IsDigit);
            if (x == true)
            {
                txtTermPresenting.ForeColor = Color.Black;
            }
            else
            {
                txtTermPresenting.ForeColor = Color.Red;
            }
        }

        private void btnSaveTerm_Click(object sender, EventArgs e)
        {
            if (txtTermPresenting.Text == "")
            {
                lblErrorTermPresenting.Text = "لطفا ترم خود را وارد نمایید!";
                lblErrorTermPresenting.ForeColor = Color.Red;
            }
            else if (txtTermPresenting.ForeColor == Color.Red)
            {
                MessageBox.Show("!کد ترم نمی تواند شامل حروف باشد", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                this.Term.Term = int.Parse(txtTermPresenting.Text.ToString());
                if (Term.CheckTerm() == true)
                {
                    MessageBox.Show("! این ترم قبلا ثبت شده است ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                Term.save();
                txtTermPresenting.Text = "";
                txtTermPresenting.Focus();
                lblErrorTermPresenting.Text = "ترم مورد نظر با موفقیت ثبت شد!";
                lblErrorTermPresenting.ForeColor = Color.Green;
            }
        }
    }
}
