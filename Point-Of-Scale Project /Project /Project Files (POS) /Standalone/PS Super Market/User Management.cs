using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS_Super_Market
{
    public partial class User_Management : Form
    {
        public User_Management()
        {
            InitializeComponent();
        }
        string query, msg, active;
        MainClass db = new MainClass();

        private void txtusername_Leave(object sender, EventArgs e)
        {
            if (txtusername.Text!="")
            {
                txtusername.Text = txtusername.Text.ToLower();
                query = "select * from Login where Username='" + db.Encrypt(txtusername.Text) + "'";
                tb = db.Search(query);
                if (tb.Rows.Count>0)
                {
                    MessageBox.Show("Username is not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtusername.Focus();
                }
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text != "" && txtpassword.Text != "" && txtname.Text != "" && txtrole.Text != "")
            {
                query = "insert into Login values ('" + db.Encrypt(txtusername.Text) + "','" + db.Encrypt(txtpassword.Text) + "','" + db.Encrypt(txtname.Text) + "','" + db.Encrypt(txtrole.Text) + "','" + db.Encrypt(active) + "')";
                msg = db.Insert(query);
                if (msg=="1")
                {
                    MessageBox.Show("--The Information has been successfully saved--", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtusername.Clear();
                    txtpassword.Clear();
                    txtname.Clear();
                    txtrole.ResetText();
                    txtusername.Focus();
                }
                else
                {
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("--Insufficient values--", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkactive.Checked)
            {
                active = "1";
            }
            else
            {
                active = "0";
            }
        }

        private void txtusername_Click(object sender, EventArgs e)
        {

        }

        private void User_Management_Load(object sender, EventArgs e)
        {
            chkactive.Checked = true;
        }

        DataTable tb;
        private void txtname_Leave(object sender, EventArgs e)
        {
            txtname.Text = db.TitleCase(txtname.Text);
        }
    }
}
