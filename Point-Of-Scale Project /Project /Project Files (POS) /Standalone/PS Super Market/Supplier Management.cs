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
    public partial class Supplier_Management : Form
    {
        public Supplier_Management()
        {
            InitializeComponent();
        }
         
        MainClass db = new MainClass();
        DataTable tb;
        string query, msg;
        private void Supplier_Management_Load(object sender, EventArgs e)
        {
            GenerateID();

            LoadSupplier();
        }

        private void GenerateID()
        {
            query = "select ID from SupplierInformation where ID in (select max(ID) from SupplierInformation)";
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

        private void txtname_Leave(object sender, EventArgs e)
        {
            if (txtname.Text!="")
            {
                query = "select * from SupplierInformation where Name='" + txtname.Text + "'";
                tb = db.Search(query);
                if (tb.Rows.Count>0)
                {
                    if (chksearch.Checked && tb.Rows[0][0].ToString()==txtid.Text)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Existing Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtname.Focus();
                    }
                }
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (txtname.Text!="" && txtemail.Text!="" && txtid.Text!="")
            {
                if (chksearch.Checked)
                {
                    query = "update SupplierInformation SET Name='" + db.TitleCase( txtname.Text) + "', Address='" + txtaddress.Text + "', Email='" + txtemail.Text + "', ContactNo='" + txtcontactno.Text + "' where ID='" + txtid.Text + "'";
                    msg = db.Update(query);
                    if (msg=="1")
                    {
                        MessageBox.Show("Information has been updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSupplier();
                        txtid.Focus();
                    }
                    else
                    {
                        MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    query = "insert into SupplierInformation values ('" + txtid.Text + "', '" + db.TitleCase(txtname.Text )+ "', '" + txtemail.Text + "', '" + txtaddress.Text + "', '" + txtcontactno.Text + "')";
                    msg = db.Update(query);
                    if (msg == "1")
                    {
                        MessageBox.Show("Information has been Saved", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GenerateID();
                        txtname.ResetText();
                        txtcontactno.Clear();
                        LoadSupplier();
                        txtaddress.Clear();
                        txtemail.Clear();
                        txtname.Focus();
                    }
                    else
                    {
                        MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("--Invalid Entry--", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chksearch_CheckedChanged(object sender, EventArgs e)
        {
            if (chksearch.Checked)
            {
                txtid.Clear();
                materialFlatButton1.Text = "Update Supplier";
                txtid.Focus();
            }
            else
            {
                GenerateID();
                materialFlatButton1.Text = "Register Supplier";
                txtname.Focus();
            }
        }

        private void txtid_Click(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            if (chksearch.Checked && txtid.Text!="")
            {
                query = "select * from SupplierInformation where ID='" + txtid.Text + "'";
                tb = db.Search(query);
                if (tb.Rows.Count>0)
                {
                    txtname.Text = tb.Rows[0][1].ToString();
                    txtemail.Text = tb.Rows[0][2].ToString();
                    txtaddress.Text = tb.Rows[0][3].ToString();
                    txtcontactno.Text = tb.Rows[0][4].ToString();
                }
                else
                {
                    txtname.ResetText();
                    txtaddress.Clear();
                    txtemail.Clear();
                    txtcontactno.Clear();
                }
            }
            else
            {
                txtname.ResetText();
                txtaddress.Clear();
                txtemail.Clear();
                txtcontactno.Clear();
            }
        }

        private void txtaddress_Leave(object sender, EventArgs e)
        {
            txtaddress.Text = db.TitleCase(txtaddress.Text);
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)|| e.KeyChar=='\b')
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
            else
            {
                e.Handled = true;
            }
        }

        private void txtcontactno_KeyPress(object sender, KeyPressEventArgs e)
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

        private void LoadSupplier()
        {
            txtname.Items.Clear();
            query = "select Name from SupplierInformation";
            tb = db.Search(query);
            if (tb.Rows.Count > 0)
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    txtname.Items.Add(tb.Rows[i][0].ToString());
                }
            }
        }
    }
}
