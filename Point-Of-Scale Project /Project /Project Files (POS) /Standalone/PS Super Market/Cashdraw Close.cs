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
using System.Diagnostics;
using System.IO;
namespace PS_Super_Market
{
    public partial class Cashdraw_Close : Form
    {
        public Cashdraw_Close()
        {
            InitializeComponent();
        }
        MainClass db = new MainClass();
        DataTable tb;
        string query, msg;
        public string Date
        {
            set
            {
                txtdate.Text = value;
            }
        }
        string path = @"C:\PS Supermarket\Summary.pdf";
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (txtclosingbalance.Text!="")
            {
                query = "update Shift SET [End]='" + txtclosingbalance.Text + "', Status='" + "Closed" + "' where Date='" + txtdate.Text + "'";
                msg = db.Update(query);
                if (msg == "1")
                {
                    MessageBox.Show("The Cashdraw has been Closed, please wait a short while to send the email", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (db.CheckInternet())
                {
                    ReportDocument rep = new ReportDocument();
                    rep.Load(@"C:\PS Supermarket\Summary Report.rpt");
                    rep.SetParameterValue("From", txtdate.Text);
                    rep.SetParameterValue("To", txtdate.Text);
                    rep.SetParameterValue("Sales", txtsales.Text);
                    rep.SetParameterValue("Returns", txtreturn.Text);
                    rep.SetParameterValue("Purchasing", txtpurchasing.Text);
                    rep.SetParameterValue("Expenses", txtexpenses.Text);
                    rep.SetParameterValue("Deposit", txtdeposit.Text);
                    rep.SetParameterValue("Withdraw", txtwithdraw.Text);
                    rep.SetParameterValue("Profit", "0");
                    rep.SetParameterValue("OpeningBalance", txtopeningbalance.Text);
                    rep.SetParameterValue("ClosingBalance", txtclosingbalance.Text);
                    path = @"C:\PS Supermarket\Summary Report.pdf";
                    db.CrystalReportServer(rep);
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                    rep.ExportToDisk(ExportFormatType.PortableDocFormat, path);
                    Process.Start(path);

                    Application.Exit();
                }

                this.Cursor = Cursors.Default; 
            }
            else
            {
                MessageBox.Show("--Invalid Operation--", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtsales_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtopeningbalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtreturn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtexpenses_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtdeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtwithdraw_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtpurchasing_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtpurchasing_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtclosingbalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Cashdraw_Close_Load(object sender, EventArgs e)
        {
            {

                try
                {
                    
                    //openingbalance

                    query = "select Start from Shift where Date='" + txtdate.Text + "'";
                    tb = db.Search(query);
                    if (tb.Rows.Count > 0)
                    {
                        txtopeningbalance.Text = tb.Rows[0][0].ToString();
                    }
                    else
                    {
                        txtopeningbalance.Text = "0";
                    }

                    //transport
                    query = "select sum(BillingTransport.Amount) from BillingTransport, Billing where  BillingTransport.InvoiceNo=Billing.InvoiceNo and Billing.Date='" + txtdate.Text + "'";
                    tb = db.Search(query);
                    if (tb.Rows[0][0].ToString() != "")
                    {
                        txttransport.Text = tb.Rows[0][0].ToString();
                    }
                    else
                    {
                        txttransport.Text = "0";
                    }

                    //Sales Total
                    query = "select sum(SubTotal) from Billing where Date>='" + txtdate.Text + "' and SubTotal>0 ";
                    tb = db.Search(query);
                    if (tb.Rows[0][0].ToString() != "")
                    {
                        txtsales.Text = tb.Rows[0][0].ToString();
                    }
                    else
                    {
                        txtsales.Text = "0";
                    }

                    query = "select sum(SubTotal) from Billing where Date>='" + txtdate.Text + "' and SubTotal<0 ";
                    tb = db.Search(query);
                    if (tb.Rows[0][0].ToString() != "")
                    {
                        txtreturn.Text = tb.Rows[0][0].ToString();
                    }
                    else
                    {
                        txtreturn.Text = "0";
                    }

                    //Purchasing
                    query = "select sum(SubTotal) from Purchasing where Date>='" + txtdate.Text + "' ";
                    tb = db.Search(query);
                    if (tb.Rows[0][0].ToString() != "")
                    {
                        txtpurchasing.Text = tb.Rows[0][0].ToString();
                    }
                    else
                    {
                        txtpurchasing.Text = "0";
                    }

                    //Expenses
                    query = "select sum(Amount) from Expenses where Date>='" + txtdate.Text + "'  ";
                    tb = db.Search(query);
                    if (tb.Rows[0][0].ToString() != "")
                    {
                        txtexpenses.Text = tb.Rows[0][0].ToString();
                    }
                    else
                    {
                        txtexpenses.Text = "0";
                    }

                    //Bank Deposit
                    query = "select sum(Amount) from BankTransactions where Type='" + "Deposit" + "' and Date>='" + txtdate.Text + "'  ";
                    tb = db.Search(query);
                    if (tb.Rows[0][0].ToString() != "")
                    {
                        txtdeposit.Text = tb.Rows[0][0].ToString();
                    }
                    else
                    {
                        txtdeposit.Text = "0";
                    }


                    //Withdraw
                    query = "select sum(Amount) from BankTransactions where Type='" + "Withdraw" + "' and Date>='" + txtdate.Text + "'  ";
                    tb = db.Search(query);
                    if (tb.Rows[0][0].ToString() != "")
                    {
                        txtwithdraw.Text = tb.Rows[0][0].ToString();
                    }
                    else
                    {
                        txtwithdraw.Text = "0";
                    }

                    txtclosingbalance.Text = (double.Parse(txtopeningbalance.Text) + (double.Parse(txtsales.Text) + double.Parse(txtwithdraw.Text) + double.Parse(txtreturn.Text)) - (double.Parse(txtexpenses.Text) + double.Parse(txtdeposit.Text))).ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
