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
    public partial class Bank_Transactions_Management : Form
    {
        public Bank_Transactions_Management()
        {
            InitializeComponent();
        }
        public string [] Info
        {
            set
            {
                txtdate.Text = value[0];
                user = value[1];
                if (value[2]=="1")
                {
                    chksearch.Enabled = true;
                }
                else
                {
                    chksearch.Enabled = false;
                }
            }
        }
        MainClass db = new MainClass();
        DataTable tb;
        string query, msg, bankid, user, type;
        private void Bank_Transactions_Management_Load(object sender, EventArgs e)
        {
            chkdeposit.Checked = true;
            GenerateTransactionID();
            LoadBanks();
        }

        private void GenerateTransactionID()
        {
            query = "select ID from BankTransactions where ID in (select max(ID) from BankTransactions)";
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

        private void txtbankname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)|| e.KeyChar=='\b' || e.KeyChar=='.')
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
        
        private void txtbankidentity_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateBankID();
        }

        private void txtbankidentity_TextChanged(object sender, EventArgs e)
        {
            GenerateBankID();
        }

        private void txtaccountno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            if (chksearch.Checked)
            {
                query = "delete from BankTransactions where ID='" + txtid.Text + "'";
                msg = db.Delete(query);
                if (msg=="1")
                {
                    MessageBox.Show("The Transaction has been deleted", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    txtaccountno.Clear();
                    txtamount.Clear();
                    txtbankidentity.ResetText();
                    txtbankname.Clear();
                    txtdescription.Clear();
                    txtbankidentity.Focus();
                    txtid.Focus();
                }
                else
                {
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid Operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtid_Click(object sender, EventArgs e)
        {
            
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            txtaccountno.Clear();
            txtbankidentity.ResetText();
            txtbankname.Clear();
            txtdescription.Clear();
            txtamount.Clear();
            if (chksearch.Checked && txtid.Text != "")
            {
                query = "select BankInformation.Name, BankTransactions.Amount, BankTransactions.Description, BankTransactions.Type  from BankTransactions, BankInformation where BankInformation.ID = BankTransactions.BankID and BankTransactions.ID='" + txtid.Text + "'";
                tb = db.Search(query);
                if (tb.Rows.Count > 0)
                {
                    if (tb.Rows[0][3].ToString()=="Deposit")
                    {
                        chkdeposit.Checked = true;
                        chkwithdraw.Checked = false;
                    }
                    else
                    {
                        chkdeposit.Checked = false;
                        chkwithdraw.Checked = true;
                    }
                    txtamount.Text = tb.Rows[0][1].ToString();
                    txtdescription.Text = tb.Rows[0][2].ToString();
                    txtbankidentity.Text = tb.Rows[0][0].ToString();
                }
                else
                {
                    txtamount.Clear();
                    txtbankidentity.ResetText();
                    txtdescription.Clear();
                }
            }
            else
            {

            }
        }

        private void chksearch_CheckedChanged(object sender, EventArgs e)
        {
            txtaccountno.Clear();
            txtbankidentity.ResetText();
            txtbankname.Clear();
            chkdeposit.Checked = true;
            chkwithdraw.Checked = false;
            txtdescription.Clear();
            txtamount.Clear();

            if (chksearch.Checked)
            {
                txtid.Clear();
                txtid.Focus();
            }
            else
            {
                GenerateTransactionID();
                txtbankidentity.Focus();
            }
        }

        private void chkwithdraw_CheckedChanged(object sender, EventArgs e)
        {
            if (chkwithdraw.Checked)
            {
                chkdeposit.Checked = false;
                type = "Withdraw";
            }
            else
            {
                type = "";
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

        private void txtdescription_Leave(object sender, EventArgs e)
        {
            txtdescription.Text = db.TitleCase(txtdescription.Text);
        }

        private void txtbankidentity_KeyPress(object sender, KeyPressEventArgs e)
        { 

        }

        private void chkdeposit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkdeposit.Checked)
            {
                chkwithdraw.Checked = false;
                type = "Deposit";
            }
            else
            {
                type = "";
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (chksearch.Checked==false && bankid!="" && txtamount.Text!="" )
            {
                GenerateTransactionID();
                query = "insert into BankTransactions values ('" + txtid.Text + "', '" + bankid + "','" + txtamount.Text + "', '" + txtdate.Text + "', '" + user + "', '" + txtdescription.Text + "', '"+type+"')";
                msg = db.Insert(query);
                if (msg=="1")
                {
                    MessageBox.Show("The Transaction has been saved", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GenerateTransactionID();
                    txtaccountno.Clear();
                    txtamount.Clear();
                    txtbankidentity.ResetText();
                    txtbankname.Clear();
                    txtdescription.Clear();
                    txtbankidentity.Focus();
                }
                else
                {
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid or Provide Required Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateBankID()
        {
            if (txtbankidentity.Text != "")
            {
                query = "select ID, BankName, AccountNo from BankInformation where Name='" + txtbankidentity.Text + "'";
                tb = db.Search(query);
                if (tb.Rows.Count > 0)
                {
                    bankid = tb.Rows[0][0].ToString();
                    txtbankname.Text = tb.Rows[0][1].ToString();
                    txtaccountno.Text = tb.Rows[0][2].ToString();
                }
                else
                {
                    bankid = "";
                    txtbankname.Clear();
                    txtaccountno.Clear();
                }
            }
            else
            { bankid = ""; txtbankname.Clear();
                txtaccountno.Clear();
            }
        }

        private void LoadBanks()
        {
            query = "select Name from BankInformation";
            tb = db.Search(query);
            if (tb.Rows.Count > 0)
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    txtbankidentity.Items.Add(tb.Rows[i][0].ToString());
                }
            }
        }
    }
}
