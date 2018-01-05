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
    public partial class Expenses_Management : Form
    {
        public Expenses_Management()
        {
            InitializeComponent();
        }
        string user, query, msg;
        MainClass db = new MainClass();
        DataTable tb;
        public string[] Info
        {
            set
            {
                txtdate.Text = value[0];
                user = value[1];
                if (value[2] == "1")
                {
                    chksearch.Enabled = true;
                    chksearch.Checked = true;
                    txtid.Clear();
                    txtid.Focus();
                }
                else
                {
                    chksearch.Enabled = false;
                }
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (txtid.Text!="" && chksearch.Checked==false && txtcategory.Text!="" && txtamount.Text!="")
            {
                GenerateID();
                query = "insert into Expenses values ('" + txtid.Text + "', '" + txtcategory.Text + "', '" + txtamount.Text + "', '" + txtdescription.Text + "', '" + txtdate.Text + "', '" + user + "')";
                msg = db.Insert(query);
                if (msg=="1")
                {
                    MessageBox.Show("--Successfully Saved--", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GenerateID();
                    LoadCategories();
                    txtamount.Clear();
                    txtcategory.ResetText();
                    txtdescription.Clear();
                    txtamount.Focus();
                }
                else
                {
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("--Insufficient Values--", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtid_Click(object sender, EventArgs e)
        {
            
             
        }

        private void chksearch_CheckedChanged(object sender, EventArgs e)
        {
            if (chksearch.Checked)
            {
                txtcategory.ResetText();
                txtamount.Clear();
                txtdescription.Clear();
                txtid.Clear();
                txtid.Focus();
                

            }
            else
            {
                txtcategory.ResetText();
                txtamount.Clear();
                txtdescription.Clear();
                GenerateID();
                txtamount.Focus();
            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            if (chksearch.Checked && txtid.Text != "")
            {
                query = "select * from Expenses where ID='" + txtid.Text + "'";
                tb = db.Search(query);
                if (tb.Rows.Count > 0)
                {
                    txtcategory.Text = tb.Rows[0][1].ToString();
                    txtamount.Text = tb.Rows[0][2].ToString();
                    txtdescription.Text = tb.Rows[0][3].ToString();

                }
                else
                {
                    txtcategory.ResetText();
                    txtamount.Clear();
                    txtdescription.Clear();
                }
            }
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (chksearch.Checked)
            {
                if (char.IsDigit(e.KeyChar)|| e.KeyChar=='\b')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar=='.' || e.KeyChar=='.')
            {
                if (e.KeyChar=='.' && txtamount.Text.Contains('.'))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtcategory_Leave(object sender, EventArgs e)
        {
            txtcategory.Text = db.TitleCase(txtcategory.Text);
        }

        private void txtdescription_Leave(object sender, EventArgs e)
        {
            txtdescription.Text = db.TitleCase(txtdescription.Text);
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (chksearch.Checked && txtid.Text!="")
            {
                query = "delete from Expenses where ID='" + txtid.Text + "'";
                msg = db.Delete(query);
                if (msg=="1")
                {
                    MessageBox.Show("--Record has been deleted Successfully--", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtamount.Clear();
                    txtcategory.ResetText();
                    txtdescription.Clear();
                    txtid.Clear();
                    txtid.Focus();
                }
                else
                {
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("--Invalid Entry--", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Expenses_Management_Load(object sender, EventArgs e)
        {
            LoadCategories();
            GenerateID();
        }

        private void txtdescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadCategories()
        {
            query = "select Category from Expenses group by Category";
            tb = db.Search(query);
            if (tb.Rows.Count > 0)
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    txtcategory.Items.Add(tb.Rows[i][0].ToString());
                }
            }
        }

        private void GenerateID()
        {
            query = "select ID from Expenses where ID in (select max(ID) from Expenses)";
            tb = db.Search(query);
            if (tb.Rows.Count > 0)
            {
                txtid.Text = (int.Parse(tb.Rows[0][0].ToString()) + 1).ToString();
            }
            else
            {
                txtid.Text = "1";
            }
        }
    }
}
