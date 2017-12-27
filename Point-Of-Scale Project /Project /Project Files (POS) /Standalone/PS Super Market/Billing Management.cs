using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.IO;
using System.Diagnostics;
namespace PS_Super_Market
{
    public partial class Billing_Management : Form
    {
        public Billing_Management()
        {
            InitializeComponent();
        }
        public string [] Info
        {
            set
            {
                username = value[0];
                txtdate.Text = value[1];
                if (value[2] == "1")
                {
                    button1.Enabled = true;

                }
                else
                {
                    button1.Enabled = false;
                }
            }
        }
        MainClass db = new MainClass();
        DataTable tb;
        string query, msg,username, stockid, type, tempsellprice, customerid;
        int ID;
        private void Billing_Management_Load(object sender, EventArgs e)
        {
            type = "F";
            stockid = "";
            LoadItemCodes();
            GenerateInvoiceNo();
        }

        private void GenerateInvoiceNo()
        {
            query = "select * from Billing where ID in (select max(ID) from Billing)";
            tb = db.Search(query);
            if (tb.Rows.Count > 0)
            {
                ID = int.Parse(tb.Rows[0][0].ToString()) + 1;
                txtinvoiceno.Text = (int.Parse(tb.Rows[0][1].ToString()) + 1).ToString();
            }
            else
            {
                ID = 1;
                txtinvoiceno.Text = "1";
            }
        }

        private void LoadItemCodes()
        {
            query = "select ItemCode from ItemInformation";
            tb = db.Search(query);
            if (tb.Rows.Count > 0)
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    txtitemcode.Items.Add(tb.Rows[i][0].ToString());
                }
            }
        }

        private void chkshowcost_CheckedChanged(object sender, EventArgs e)
        {
            if (chkshowcost.Checked)
            {
                txtcostprice.UseSystemPasswordChar = false;
            }
            else
            {
                txtcostprice.UseSystemPasswordChar = true;
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            if (chksearch.Checked && dataGridView1.Rows.Count>0)
            {
                toolTip1.SetToolTip(button3, "Re-Print Invoice " + txtinvoiceno.Text);

            }
            else
            {
                toolTip1.SetToolTip(button3, "Re-Print Inovice");

            }
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button4, "Save Invoice");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "Delete Inovice");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button2, "Email Invoice");
        }

        private void txttransport_Leave(object sender, EventArgs e)
        {
            if (txttransport.Text=="")
            {
                txttransport.Text = "0";
            }
        }

        private void txtinvoicetotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txttotalofinvoice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtpayments_Leave(object sender, EventArgs e)
        {
            if (txtpayments.Text=="")
            {
                txtpayments.Text = "0";
            }
        }

        private void txtbalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtinvoiceno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (chksearch.Checked)
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
            else
            {
                e.Handled = true;
            }
        }

        private void chksearch_CheckedChanged(object sender, EventArgs e)
        {
            if (chksearch.Checked)
            {
                txtinvoiceno.Clear();
                txtinvoiceno.Focus();
            }
            else
            {
                GenerateInvoiceNo();
                txtcustomername.Focus();
            }
        }

        private void chksendemail_CheckedChanged(object sender, EventArgs e)
        {
            if (chksendemail.Checked)
            {
                if (txtemail.Text=="")
                {
                    MessageBox.Show("Without an Email, this feature may not work", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    chksendemail.Checked = false;
                    txtemail.Focus();
                }
            }
        }

        private void txtdiscount_Leave(object sender, EventArgs e)
        {

        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            txtemail.Text = txtemail.Text.ToLower();
        }

        private void txtcontact_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtcontact_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtitemcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            LoadItemInfowithoutMultiple();
        }
        string itemcode;
        private void LoadItemInfowithoutMultipleBarcode()
        {
            if (txtitemcode.Text != "")
            {
                query = "select ItemInformation.Description, Inventory.Cost, Inventory.SellPrice, Inventory.ID, Inventory.ItemCode from ItemInformation, Inventory where ItemInformation.ItemCode=Inventory.ItemCode and Inventory.Quantity>0 and Inventory.BarcodeText='" + txtitemcode.Text + "'";
                tb = db.Search(query);
                if (tb.Rows.Count > 0)
                {  
                    stockid = tb.Rows[0][3].ToString();
                    itemcode = tb.Rows[0][4].ToString();
                    txtdescription.Text = tb.Rows[0][0].ToString();
                    txtcostprice.Text = tb.Rows[0][1].ToString();
                    if (chkreturn.Checked)
                    {
                        txtsellprice.Text = "-" + tb.Rows[0][2].ToString();
                        tempsellprice = txtsellprice.Text;
                    }
                    else

                    { txtsellprice.Text = tb.Rows[0][2].ToString(); tempsellprice = txtsellprice.Text; }


                    txtsubtotal.Text = (double.Parse(txtquantity.Text) * double.Parse(txtsellprice.Text)).ToString();

                }
                else
                {
                    txtdescription.Clear();
                    itemcode = "";
                    stockid = "";

                }
            }
            else
            {
                itemcode = "";
                txtsellprice.Clear();
                tempsellprice = "";
            }
        }
        private void LoadItemInfowithoutMultiple()
        {
            if (txtitemcode.Text != "")
            {
                query = "select ItemInformation.Description, Inventory.Cost, Inventory.SellPrice, Inventory.ID, Inventory.ItemCode from ItemInformation, Inventory where ItemInformation.ItemCode=Inventory.ItemCode and Inventory.Quantity>0 and Inventory.ItemCode='" + txtitemcode.Text + "'";
                tb = db.Search(query);
                if (tb.Rows.Count > 0)
                {
                    
                    stockid = tb.Rows[0][3].ToString();
                    itemcode = tb.Rows[0][4].ToString();
                    txtdescription.Text = tb.Rows[0][0].ToString();
                    txtcostprice.Text = tb.Rows[0][1].ToString();
                    if (chkreturn.Checked)
                    {
                        txtsellprice.Text = "-"+tb.Rows[0][2].ToString();
                        tempsellprice = txtsellprice.Text;
                    }
                    else

                    { txtsellprice.Text = tb.Rows[0][2].ToString(); tempsellprice = txtsellprice.Text; }
                   
                    
                    txtsubtotal.Text = (double.Parse(txtquantity.Text) * double.Parse(txtsellprice.Text)).ToString();

                }
                else
                {
                    txtdescription.Clear();
                    itemcode = "";
                    stockid = "";
                    LoadItemInfowithoutMultipleBarcode();
                }
            }
            else
            {
               
                itemcode = "";
                txtsellprice.Clear();
                tempsellprice = "";
               
            }
        }

        private void LoadItemInformation()
        {
            if (txtitemcode.Text != "")
            {
                
                stockid = "";
                query = "select ItemInformation.Description, Inventory.Cost, Inventory.SellPrice, Inventory.ID, Inventory.ItemCode from ItemInformation, Inventory where ItemInformation.ItemCode=Inventory.ItemCode and Inventory.Quantity>0 and Inventory.ItemCode='" + txtitemcode.Text + "' or Inventory.BarcodeText='"+txtitemcode.Text+"'";
                tb = db.Search(query);
                if (tb.Rows.Count > 0)
                {
                    stockid = tb.Rows[0][3].ToString();
                    itemcode = tb.Rows[0][4].ToString();
                    txtdescription.Text = tb.Rows[0][0].ToString();
                    txtcostprice.Text = tb.Rows[0][1].ToString();
                    if (chkreturn.Checked)
                    {
                        txtsellprice.Text = "-" + tb.Rows[0][2].ToString();
                        tempsellprice = txtsellprice.Text;
                    }
                    else

                    { txtsellprice.Text = tb.Rows[0][2].ToString();
                        tempsellprice = txtsellprice.Text;
                    }
                   
                    txtsubtotal.Text = (double.Parse(txtquantity.Text)* double.Parse(txtsellprice.Text)).ToString();

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
                                txtcostprice.Text = tb.Rows[0][0].ToString();
                                if (chkreturn.Checked && !txtsellprice.Text.Contains('-'))
                                {
                                    txtsellprice.Text = "-" + tb.Rows[0][1].ToString();
                                }
                                else

                                { txtsellprice.Text = tb.Rows[0][1].ToString(); }
                                txtsubtotal.Text = (double.Parse(txtquantity.Text) * double.Parse(txtsellprice.Text)).ToString();
                                txtsellprice.Focus();
                            }
                            else
                            {

                                txtdescription.Clear(); txtitemcode.Focus();
                                txtsellprice.Clear();
                                txtcostprice.Clear();
                                tempsellprice = "";
                                stockid = "";
                            }
                        }
                        else
                        {
                            txtdescription.Clear();
                            txtitemcode.ResetText();
                            txtsellprice.Clear();
                            txtcostprice.Clear();
                            tempsellprice = "";
                            stockid = "";
                            txtitemcode.Focus();
                        }
                    }
                    else
                    {
                        stockid = tb.Rows[0][3].ToString();
                        txtsellprice.Focus();
                      
                    }
                     
                }
                else
                {
                    txtdescription.Clear();
                    txtcostprice.Clear();
                    txtsellprice.Clear();
                    stockid = "";
                    tempsellprice = "";
                }
            }
            else
            {
                txtdescription.Clear();
                txtcostprice.Clear();
                txtsellprice.Clear();
                tempsellprice = "";
                stockid = "";
            }
        }

        private void txtdescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtcostprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtsellprice_TextChanged(object sender, EventArgs e)
        {
            if (txtitemcode.Text!="" && tempsellprice!="")
            {
                try
                {
                    if (txtsellprice.Text == "")
                    {
                        txtsellprice.Text = tempsellprice;
                    }
                    txtsubtotal.Text = (double.Parse(txtquantity.Text) * double.Parse(txtsellprice.Text)).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               

            }
        }

        private void chkreturn_CheckedChanged(object sender, EventArgs e)
        {
            if (chkreturn.Checked)
            {
                type = "R";
            }
            else
            {
                type = "F";
            }
        }

        private void txtitemcode_TextChanged(object sender, EventArgs e)
        {
            LoadItemInfowithoutMultiple();




        }

        private void txtitemcode_Leave(object sender, EventArgs e)
        {
            if (txtitemcode.Text!="")
            {
                if (stockid=="")
                {
                   // LoadItemInformation();
                }
                else
                {
                    txtsellprice.Focus();
                }
                
            
            }
            else
            {
                txttransport.Focus();
            }
         
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (stockid!="" && chksearch.Checked==false )
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (double.Parse(txtsellprice.Text)==double.Parse(dataGridView1[2,i].Value.ToString())&& dataGridView1[7, i].Value.ToString()==stockid && dataGridView1[4, i].Value.ToString()==txtdiscount.Text && dataGridView1[0, i].Value.ToString()==itemcode && dataGridView1[6,i].Value.ToString()==type)
                    {
                        dataGridView1[3, i].Value = (double.Parse(dataGridView1[3, i].Value.ToString()) + double.Parse(txtquantity.Text)).ToString();
                        txtitemcode.ResetText();
                        txtdescription.Clear();
                        txtinvoicetotal.Text = (double.Parse(txtsubtotal.Text) + double.Parse(txtinvoicetotal.Text)).ToString();
                        txtquantity.Text = "1";
                        txtsellprice.Text = "0";
                        txtcostprice.Clear();
                        txtdiscount.Text = "0";
                        txtsubtotal.Text = "0";
                        txtitemcode.Focus();
                    }
                }
                if (txtitemcode.Text != "")
                {
                    string[] row = {itemcode, txtdescription.Text, txtsellprice.Text, txtquantity.Text, txtdiscount.Text, txtsubtotal.Text, type, stockid };
                    dataGridView1.Rows.Add(row);
                    txtitemcode.ResetText();
                    txtdescription.Clear();
                    txtinvoicetotal.Text = (double.Parse(txtsubtotal.Text) + double.Parse(txtinvoicetotal.Text)).ToString();
                    txtquantity.Text = "1";
                    txtsellprice.Text = "0";
                    txtcostprice.Clear();
                    txtdiscount.Text = "0";
                    txtsubtotal.Text = "0";
                    txtitemcode.Focus();
                }
            }
            else
            {
                MessageBox.Show("--Invalid Entry--", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtdiscount.Text!="")
            {
                GenerateDiscount();
            }
            else
            {
                txtdiscount.Text = "0";
                 
            }
        }

        private void txtquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '\b' )
            {
                if (e.KeyChar == '.' && txtquantity.Text.Contains('.'))
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

        private void txtsellprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '\b'  )
            {
                if (e.KeyChar == '.' && txtsellprice.Text.Contains('.'))
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

        private void txtinvoicetotal_TextChanged(object sender, EventArgs e)
        {
            txttotalofinvoice.Text = txtinvoicetotal.Text;
        }

        private void txttransport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '\b' )
            {
                if (e.KeyChar == '.' && txttransport.Text.Contains('.'))
                {
                    e.Handled = true;
                }
                else
                {
                    if (e.KeyChar == (char)Keys.Enter)
                    {
                        GenerateDiscount();
                    }
                    e.Handled = false;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtsubtotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtpayments_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '\b')
            {
                if (e.KeyChar == '.' && txtpayments.Text.Contains('.'))
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

        private void txttransport_TextChanged(object sender, EventArgs e)
        {
            if (txttransport.Text == "")
            {
                txttotalofinvoice.Text = txtinvoicetotal.Text;
            }
            else
            {
                txttotalofinvoice.Text = (double.Parse(txtinvoicetotal.Text) + double.Parse(txttransport.Text)).ToString();
            }
        }

        private void txtpayments_TextChanged(object sender, EventArgs e)
        {
            if (txtpayments.Text=="")
            {
                txtbalance.Text = "0";
            }
            else
            {
                txtbalance.Text =Math.Round( (double.Parse(txtpayments.Text) - double.Parse(txttotalofinvoice.Text)),2).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count>0 && chksearch.Checked==false && txtpayments.Text!="" && double.Parse(txtbalance.Text)>=0)
            {
                this.Cursor = Cursors.WaitCursor;
                GenerateInvoiceNo();
                if (txtcustomername.Text=="")
                {
                    txtcustomername.Text = "Cash Customer";
                }
                query = "select * from CustomerInformation where Name='" + txtcustomername.Text + "'";
                tb = db.Search(query);
                if (tb.Rows.Count>0)
                {
                    customerid = tb.Rows[0][0].ToString();
                    query = "update CustomerInformation set Email='" + txtemail.Text + "', Contact='" + txtcontact.Text + "' where ID='" + customerid + "'";
                    msg = db.Update(query);
                     
                }
                else
                {
                    query = "select ID from CustomerInformation where ID in (select max(ID) from CustomerInformation)";
                    tb = db.Search(query);
                    if (tb.Rows.Count>0)
                    {
                        customerid = (int.Parse(tb.Rows[0][0].ToString()) + 1).ToString();
                    }
                    else
                    {
                        customerid = "1";
                    }
                    query = "insert into CustomerInformation values ('" + customerid + "', '" + txtcustomername.Text + "', '" + txtemail.Text + "', '" + txtcontact.Text + "')";
                    msg = db.Insert(query);
                }
                if (msg=="1")
                {
                    query = "insert into BillingTransport values ('" + txtinvoiceno.Text + "', '" + txttransport.Text + "')";
                    msg = db.Insert(query);
                }
                if (msg=="1")
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (msg=="1")
                        {
                            query = "insert into Billing values ('" + ID + "', '" + txtinvoiceno.Text + "', '" + dataGridView1[7, i].Value.ToString() + "', '" + dataGridView1[3, i].Value.ToString() + "',  '" + dataGridView1[2, i].Value.ToString() + "','" + txtdate.Text + "', '" + dataGridView1[4, i].Value.ToString() + "', '" + username + "', '" + txtpayments.Text + "', '" + dataGridView1[5, i].Value.ToString() + "', '" + customerid + "', '" + dataGridView1[6, i].Value.ToString() + "')";
                            msg = db.Insert(query);
                            ID++;
                        }
                        if (msg=="1")
                        {
                            query = "select Quantity from Inventory where ID='" + dataGridView1[7, i].Value.ToString() + "'";
                            tb = db.Search(query);
                            if (tb.Rows.Count>0)
                            {
                                double newquantity = double.Parse(tb.Rows[0][0].ToString()); ;
                                if (dataGridView1[6, i].Value.ToString()=="F")
                                {
                                    newquantity = newquantity - double.Parse(dataGridView1[3, i].Value.ToString());
                                }
                                else
                                {
                                    newquantity = newquantity + double.Parse(dataGridView1[3, i].Value.ToString());

                                }
                                query = "update Inventory SET Quantity='" + newquantity + "' where ID='" + dataGridView1[7, i].Value.ToString() + "'";
                                msg = db.Update(query);
                            }
                        }
                    }
                }
                if (msg=="1")
                {
                    MessageBox.Show("--Invoice has been saved successfully--", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GenerateInvoice();

                    if (chksendemail.Checked)
                    {
                        SendEmail();
                    }
                    txttotalofinvoice.Text = "0";
                    txttransport.Text = "0";
                    txtinvoicetotal.Text = "0";
                    txtpayments.Text = "0";
                    txtbalance.Text = "0";
                    GenerateInvoiceNo();
                    dataGridView1.Rows.Clear();
                    txtcustomername.Clear();
                    chksendemail.Checked = false;
                    txtemail.Clear();
                    txtcontact.Clear();
                    this.Cursor = Cursors.Default;

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

        private void SendEmail()
        {
            if ( db.CheckInternet() == true)
            {
                if (txtemail.Text!="")
                {
                    msg = db.SendEmail(txtemail.Text, "--Thank you for your Purchasing--", "Invoice from PS Supermarket", @"C:\PS Supermarket\Bills\" + txtinvoiceno.Text + ".pdf", "PS Supermarket");
                    if (msg == "1")
                    {
                        MessageBox.Show("--Email Sent--", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                }
                else
                {
                    MessageBox.Show("--Email didn't send, Invalid Email Address--", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("--No Active Internet Connection--", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (chksearch.Checked && dataGridView1.Rows.Count > 0)
            {
                this.Cursor=Cursors.WaitCursor;
                GenerateInvoice();
                SendEmail();
                this.Cursor = Cursors.Default;
            }
            else
            {
                MessageBox.Show("--Invalid Entry--", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (chksearch.Checked && dataGridView1.Rows.Count>0)
            {
                GenerateInvoice();
            }
            else
            {
                MessageBox.Show("--Invalid Entry--", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtinvoiceno_TextChanged(object sender, EventArgs e)
        {
            txttotalofinvoice.Text = "0";
            txttransport.Text = "0";
            txtpayments.Text = "0";
            txtinvoicetotal.Text = "0";
            txtbalance.Text = "0";
            dataGridView1.Rows.Clear();
            txtcustomername.Clear();
            chksendemail.Checked = false;
            txtemail.Clear();
            txtcontact.Clear();
            if (txtinvoiceno.Text!="" && chksearch.Checked)
            {
                

                query = "select CustomerInformation.Name, CustomerInformation.Email, CustomerInformation.Contact, ItemInformation.ItemCode, ItemInformation.Description, Billing.Quantity, Billing.SellPrice, Billing.Discount, Billing.SubTotal, Billing.Type, Billing.ItemID, BillingTransport.Amount, Billing.Paid from CustomerInformation, Billing, ItemInformation, Inventory, BillingTransport where ItemInformation.ItemCode=Inventory.ItemCode and Inventory.ID=Billing.ItemID and CustomerInformation.ID=Billing.CustomerID and BillingTransport.InvoiceNo=Billing.InvoiceNo and Billing.InvoiceNo='" + txtinvoiceno.Text + "'";
                tb = db.Search(query);
                if (tb.Rows.Count>0)
                {
                  
                    
                    for (int i = 0; i < tb.Rows.Count; i++)
                    {
                        string [] row ={ tb.Rows[i][3].ToString(), tb.Rows[i][4].ToString(), tb.Rows[i][6].ToString(), tb.Rows[i][5].ToString(), tb.Rows[i][7].ToString(), tb.Rows[i][8].ToString(), tb.Rows[i][9].ToString(), tb.Rows[i][10].ToString() };
                        dataGridView1.Rows.Add(row);
                        txttotalofinvoice.Text = (double.Parse(tb.Rows[i][8].ToString()) + double.Parse(txtinvoicetotal.Text)).ToString();
                    }
                 
                    txtemail.Text = tb.Rows[0][1].ToString();
                    txtcontact.Text = tb.Rows[0][2].ToString();
                    txttotalofinvoice.Text = (double.Parse(txtinvoicetotal.Text) + double.Parse(txttransport.Text)).ToString();
                    txttransport.Text = tb.Rows[0][11].ToString();
                    txtpayments.Text = tb.Rows[0][12].ToString();
                    txtcustomername.Text = tb.Rows[0][0].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chksearch.Checked && dataGridView1.Rows.Count>0)
            {
                DialogResult deleterow = MessageBox.Show("Do you want to Delete the invoice?", "Confirmation Required", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (deleterow==DialogResult.Yes)
                {
                    msg = "1";
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (msg == "1")
                        {
                            query = "select Quantity from Inventory where ID='" + dataGridView1[7, i].Value.ToString() + "'";
                            tb = db.Search(query);
                            if (tb.Rows.Count > 0)
                            {
                                double newquantity = double.Parse(tb.Rows[0][0].ToString()); ;
                                if (dataGridView1[6, i].Value.ToString() == "F")
                                {
                                    newquantity = newquantity + double.Parse(dataGridView1[3, i].Value.ToString());
                                }
                                else
                                {
                                    newquantity = newquantity - double.Parse(dataGridView1[3, i].Value.ToString());

                                }
                                query = "update Inventory SET Quantity='" + newquantity + "' where ID='" + dataGridView1[7, i].Value.ToString() + "'";
                                msg = db.Update(query);
                            }
                        }
                    }
                    if (msg == "1")
                    {
                        query = "delete from Billing where InvoiceNo='" + txtinvoiceno.Text + "'";
                        msg = db.Delete(query);
                        if (msg == "1")
                        {
                            MessageBox.Show("--Invoice has been deleted--", "Delete Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txttotalofinvoice.Text = "0";
                            txttransport.Text = "0";
                            txtpayments.Text = "0";
                            txtbalance.Text = "0";
                            dataGridView1.Rows.Clear();
                            txtcustomername.Clear();
                            chksendemail.Checked = false;
                            txtemail.Clear();
                            txtcontact.Clear();
                            txtinvoiceno.Focus();
                        }
                        else
                        {
                            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } 
                }
                else
                {
                    MessageBox.Show("--You are safe, Invoice didn't delete--", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Invalid Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (chksearch.Checked)
            {
                MessageBox.Show("You can't delete rows while you are searching", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            else
            {
                DialogResult deleterow = MessageBox.Show("Are you sure? you want to delete the row?", "Confirmation Required", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (deleterow==DialogResult.Yes)
                {
                    txtinvoicetotal.Text = (double.Parse(txtinvoicetotal.Text) - double.Parse(dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString())).ToString();

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void txtitemcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Clipboard.Clear();
                Find_Products fr = new Find_Products();
                fr.ShowDialog();
                if (Clipboard.GetText() != null)
                {
                    txtitemcode.Text = Clipboard.GetText();
                }
            }
        }

        private void GenerateInvoice()
        {
            string path = @"C:\PS Supermarket\Bills\" + txtinvoiceno.Text + ".pdf";
            if (!Directory.Exists(@"C:\PS Supermarket\Bills"))
            {
                Directory.CreateDirectory(@"C:\PS Supermarket\Bills");
            }
            ReportDocument rep = new ReportDocument();
            rep.Load(@"C:\PS Supermarket\Invoice.rpt");
            db.CrystalReportServer(rep);
            rep.SetParameterValue("InvoiceNo", txtinvoiceno.Text);
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            rep.ExportToDisk(ExportFormatType.PortableDocFormat, path);
            DialogResult open = MessageBox.Show("Do you want to Open the Invoice?", "Open Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (open==DialogResult.Yes)
            {
                Process.Start(path);

            }
           
        }

        private void txtcustomername_TextChanged(object sender, EventArgs e)
        {
            if (chksearch.Checked==false)
            {
                if (txtcustomername.Text != "")
                {
                    query = "select * from CustomerInformation where Name='" + txtcustomername.Text + "'";
                    tb = db.Search(query);
                    if (tb.Rows.Count > 0)
                    {
                        customerid = tb.Rows[0][0].ToString();
                        txtemail.Text = tb.Rows[0]["Email"].ToString();
                        txtcontact.Text = tb.Rows[0]["Contact"].ToString();
                    }
                    else
                    {
                        txtemail.Clear();
                        txtcontact.Clear();
                        customerid = "";
                    }
                }
                else
                {
                    txtemail.Clear();
                    txtcontact.Clear();
                    customerid = "";
                } 
            }
        }

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
            if (txtitemcode.Text!="" && txtsellprice.Text!="")
            {
                if (txtquantity.Text == "")
                {
                    txtquantity.Text = "0";
                }
                txtsubtotal.Text = (double.Parse(txtquantity.Text) * double.Parse(txtsellprice.Text)).ToString();

            }
        }

        private void txtdiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)||e.KeyChar=='.'||e.KeyChar=='\b' || e.KeyChar==(char)Keys.Enter)
            {
                if (e.KeyChar=='.' && txtdiscount.Text.Contains('.'))
                {
                    e.Handled = true;
                }
                else
                {
                    if (e.KeyChar==(char)Keys.Enter)
                    {
                        GenerateDiscount();
                    }
                    e.Handled = false;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void GenerateDiscount()
        {
            double discount = ((double.Parse(txtsellprice.Text) * double.Parse(txtquantity.Text)) / 100 * double.Parse(txtdiscount.Text));
            txtsubtotal.Text = (double.Parse(txtsellprice.Text) * double.Parse(txtquantity.Text) - discount).ToString();
        }

        private void txtcustomername_Leave(object sender, EventArgs e)
        {
            txtcustomername.Text = db.TitleCase(txtcustomername.Text.ToLower());
        }
    }
}
