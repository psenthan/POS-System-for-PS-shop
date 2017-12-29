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
    public partial class Update_Stock_Information : Form
    {
        public Update_Stock_Information()
        {
            InitializeComponent();
        }
        DataTable tb;
        MainClass db = new MainClass();
        string query, msg;
        private void Update_Stock_Information_Load(object sender, EventArgs e)
        {
            LoadCategory();
            Choose();
        }
        string stockid="";
        private void lblitem_Click(object sender, EventArgs e)
        {
            Choose();
        }

        private void Choose()
        {
            stockid = "";
            Clipboard.Clear();
            Find_Products fr = new Find_Products();
            fr.ShowDialog();

            if (Clipboard.GetText() != "")
            {
                stockid = Clipboard.GetText();
                query = "select Inventory.ItemCode, ItemInformation.Description, Inventory.Cost, Inventory.SellPrice, Inventory.Alert, Inventory.Category, Inventory.ID from Inventory, ItemInformation where ItemInformation.ItemCode=Inventory.ItemCode and Inventory.ItemCode='" + stockid + "'";
                tb = db.Search(query);
                if (tb.Rows.Count > 0)
                {
                    stockid = tb.Rows[0][6].ToString();
                    txtitemcode.Text = tb.Rows[0][0].ToString();
                    txtdesciption.Text = tb.Rows[0][1].ToString();
                    txtalert.Text = tb.Rows[0][4].ToString();
                    txtcategory.Text = tb.Rows[0][5].ToString();
                    if (tb.Rows.Count > 1)
                    {
                        Clipboard.Clear();
                        Choose_Items cr = new Choose_Items();
                        cr.ItemCode = txtitemcode.Text;
                        cr.ShowDialog();
                        if (Clipboard.GetText() != "")
                        {
                            
                            query = "select Cost, SellPrice,ID from Inventory where ID='" + Clipboard.GetText() + "'";
                            tb = db.Search(query);
                            if (tb.Rows.Count > 0)
                            {
                                stockid = tb.Rows[0][2].ToString();
                                txtcost.Text = tb.Rows[0][0].ToString();
                                txtsell.Text = tb.Rows[0][1].ToString();

                            }
                            else
                            {
                                lblitem.Text = "--Click Here To Choose Item--";
                                stockid = "";
                                txtitemcode.Clear();
                                txtdesciption.Clear();
                                txtcategory.ResetText();
                                txtcost.Clear();
                                txtalert.Clear();
                                txtsell.Clear();
                                lblitem.Focus();

                            }
                        }
                        else
                        {
                            lblitem.Text = "--Click Here To Choose Item--";
                            stockid = "";
                            txtitemcode.Clear();
                            txtdesciption.Clear();
                            txtcategory.ResetText();
                            txtcost.Clear();
                            txtalert.Clear();
                            txtsell.Clear();
                            lblitem.Focus();
                        }
                    }
                    else
                    {
                        txtitemcode.Text = tb.Rows[0][0].ToString();
                        txtdesciption.Text = tb.Rows[0][1].ToString();
                        txtalert.Text = tb.Rows[0][4].ToString();
                        txtcategory.Text = tb.Rows[0][5].ToString();
                        txtcost.Text = tb.Rows[0][2].ToString();
                        txtsell.Text = tb.Rows[0][3].ToString();

                    }
                    lblitem.Text ="SELECTED: "+ txtitemcode.Text + " | " + txtdesciption.Text + " | " + txtsell.Text;

                }
            }
            else
            {
                lblitem.Text = "--Click Here To Choose Item--";
                stockid = "";
                txtitemcode.Clear();
                txtdesciption.Clear();
                txtcategory.ResetText();
                txtcost.Clear();
                txtalert.Clear();
                txtsell.Clear();
                lblitem.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (stockid!="" && txtitemcode.Text!="" && txtdesciption.Text!="" && txtcost.Text!=""&&txtsell.Text!="" && txtalert.Text!="" && txtcategory.Text!="")
            {
                query = "update Inventory SET ItemCode='" + txtitemcode.Text + "', Cost='" + txtcost.Text + "', SellPrice='" + txtsell.Text + "', Alert='" + txtalert.Text + "', Category='" + txtcategory.Text + "' where ID='" + stockid + "'";
                msg = db.Update(query);
                MessageBox.Show(msg);
                if (msg=="1")
                {
                    query = "update ItemInformation SET ItemCode='" + txtitemcode.Text + "', Description='" + txtdesciption.Text + "' where ItemCode='" + txtitemcode.Text + "'";
                    msg = db.Update(query);
                
                    
                }

                if (msg=="1")
                {
                    MessageBox.Show("--Information have been successfully updated--", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtalert.Clear();
                    txtcategory.ResetText();
                    txtcost.Clear();
                    txtdesciption.Clear();
                    txtitemcode.Clear();
                    txtsell.Clear();
                    lblitem.Text = "--Click Here To Choose Item--";
                    lblitem.Focus();
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void LoadCategory()
        {
            query = "Select category from Inventory group by category";
            tb = db.Search(query);
            if (tb.Rows.Count > 0)
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    txtcategory.Items.Add(tb.Rows[i][0].ToString());
                }
            }
        }
    }
}
