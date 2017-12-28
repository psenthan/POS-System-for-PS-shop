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
    public partial class Banks_Management : Form
    {
        public Banks_Management()
        {
            InitializeComponent();
        }
        MainClass db = new MainClass();
        DataTable tb;
        string query, msg;

        private void txtaccountno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)||e.KeyChar=='\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void chksearch_CheckedChanged(object sender, EventArgs e)
        {
            txtaccountname.Clear();
            txtaccountno.Clear();
            txtbank.Clear();
            if (chksearch.Checked)
            {
                materialFlatButton1.Text = "Update Bank Info";
                txtid.Clear();
                txtid.Focus();

            }
            else
            {
                materialFlatButton1.Text = "Register Bank Info";
                GenerateBankID();
                txtaccountname.Focus();
            }
        }

        private void Banks_Management_Load(object sender, EventArgs e)
        {
            GenerateBankID();
            
        }

        private void GenerateBankID()
        {
            query = "select ID from BankInformation where ID in (select max(ID) from BankInformation)";
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

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (txtid.Text!="" && txtaccountname.Text!="" && txtaccountno.Text!="" && txtbank.Text!="")
            {
                if (chksearch.Checked)
                {
                    query = "update BankInformation SET Name='" + txtaccountname.Text + "' , BankName='" + txtbank.Text + "', AccountNo='" + txtaccountno.Text + "' where ID='" + txtid.Text + "'";
                    msg = db.Update(query);
                    if (msg == "1")
                    {
                        MessageBox.Show("Account Information has been updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    GenerateBankID();
                    query = "insert into BankInformation values ('" + txtid.Text + "', '" + txtaccountname.Text + "', '" + txtbank.Text + "', '" + txtaccountno.Text + "')";
                    msg = db.Insert(query);
                    if (msg == "1")
                    {
                        MessageBox.Show("Account Information has been Saved", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GenerateBankID();
                        txtaccountname.Clear();
                        txtaccountno.Clear();
                        txtbank.Clear();
                        txtaccountname.FindForm();
                    }
                    else
                    {
                        MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } 
            }
            else
            {
                MessageBox.Show("Please Fill all the required Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtaccountname_Leave(object sender, EventArgs e)
        {
            if (txtaccountname.Text!=""  )
            {
                txtaccountname.Text = db.TitleCase(txtaccountname.Text);
                query = "select AccountNo, Name from BankInformation where Name='" + txtaccountname.Text + "'";
                tb = db.Search(query);
                if (tb.Rows.Count>0)
                { 
                        MessageBox.Show("This Identity is already registered under Account No " + tb.Rows[0][0].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtaccountname.Clear();
                    
                }
            }
        }

        private void txtaccountno_Leave(object sender, EventArgs e)
        {
            if (txtaccountno.Text!="")
            {
                query = "select * from BankInformation where AccountNo='" + txtaccountno.Text + "'";
                tb = db.Search(query);
                if (tb.Rows.Count>0)
                {
                 MessageBox.Show("The Account has been registered under indentity of " + tb.Rows[0][1].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 txtaccountno.Clear();
                }
            }
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (chksearch.Checked)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtid_Click(object sender, EventArgs e)
        {
            
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                if (chksearch.Checked)
                {
                    query = "select * from BankInformation where ID='" + txtid.Text + "'";
                    tb = db.Search(query);
                    if (tb.Rows.Count > 0)
                    {
                        txtaccountname.Text = tb.Rows[0][1].ToString();
                        txtbank.Text = tb.Rows[0][2].ToString();
                        txtaccountno.Text = tb.Rows[0][3].ToString();
                    }
                    else
                    {
                        txtaccountname.Clear();
                        txtbank.Clear();
                        txtaccountno.Clear();
                    }
                }
            }
            else
            {
                txtaccountname.Clear();
                txtbank.Clear();
                txtaccountno.Clear();
            }
        }

        private void txtbank_Leave(object sender, EventArgs e)
        {
            txtbank.Text = db.TitleCase(txtbank.Text);
        }
    }
}
