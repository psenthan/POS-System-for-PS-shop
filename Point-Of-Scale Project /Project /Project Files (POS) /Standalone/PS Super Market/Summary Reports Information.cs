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
    public partial class Summary_Reports_Information : Form
    {
        public Summary_Reports_Information()
        {
            InitializeComponent();
        }
        public string Daily
        {
            set
            {
                if (value=="1")
                {
                    txtto.Enabled = false;
                    label1.Text = "Daily Summary Report";
                }
                else
                {
                    txtto.Enabled = true;
                  
                }
            }
        }
        public string Info
        {
            set
            {
                if (value == "1")
                {
                    txtto.Enabled = false;
                }
                else
                {
                    txtto.Enabled = true;
                }
            }
        }
        private void Summary_Reports_Information_Load(object sender, EventArgs e)
        {

        }
        MainClass db = new MainClass();
        DataTable tb;
        string query, msg;
        double Sales, Purchasing, Expenses, Deposit, Withdraw, openingbalance, closingbalance, profit, Return;

        private void txtfrom_ValueChanged(object sender, EventArgs e)
        {
            if (txtto.Enabled == false)
            {
                txtto.Text = txtfrom.Text;
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            {

                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    //openingbalance

                    query = "select Start from Shift where Date='" + txtfrom.Text + "'";
                    tb = db.Search(query);
                    if (tb.Rows.Count > 0)
                    {
                        openingbalance = double.Parse(tb.Rows[0][0].ToString());
                    }
                    else
                    {
                        openingbalance = 0;
                    }

                    //openingbalance

                    query = "select [End] from Shift where Date='" + txtto.Text + "'";
                    tb = db.Search(query);
                    if (tb.Rows.Count > 0)
                    {
                        try
                        {
                            closingbalance = double.Parse(tb.Rows[0][0].ToString());
                        }
                        catch
                        {

                            closingbalance = 0;
                        }
                    }
                    else
                    {
                        closingbalance = 0;
                    }

                    //Sales Total
                    query = "select sum(SubTotal) from Billing where Date>='" + txtfrom.Text + "' and Date<='" + txtto.Text + "' and Subtotal>0 ";
                    tb = db.Search(query);
                    if (tb.Rows[0][0].ToString() != "")
                    {
                        Sales = double.Parse(tb.Rows[0][0].ToString());
                    }
                    else
                    {
                        Sales = 0;
                    }

                    //return
                    query = "select sum(SubTotal) from Billing where Date>='" + txtfrom.Text + "' and Date<='" + txtto.Text + "' and Subtotal<0 ";
                    tb = db.Search(query);
                    if (tb.Rows[0][0].ToString() != "")
                    {
                        Return = double.Parse(tb.Rows[0][0].ToString());
                    }
                    else
                    {
                        Return = 0;
                    }
                    //Purchasing
                    query = "select sum(SubTotal) from Purchasing where Date>='" + txtfrom.Text + "' and Date<='" + txtto.Text + "'";
                    tb = db.Search(query);
                    if (tb.Rows[0][0].ToString() != "")
                    {
                        Purchasing = double.Parse(tb.Rows[0][0].ToString());
                    }
                    else
                    {
                        Purchasing = 0;
                    }

                    //Expenses
                    query = "select sum(Amount) from Expenses where Date>='" + txtfrom.Text + "' and Date<='" + txtto.Text + "'";
                    tb = db.Search(query);
                    if (tb.Rows[0][0].ToString() != "")
                    {
                        Expenses = double.Parse(tb.Rows[0][0].ToString());
                    }
                    else
                    {
                        Expenses = 0;
                    }

                    //Bank Deposit
                    query = "select sum(Amount) from BankTransactions where Type='" + "Deposit" + "' and Date>='" + txtfrom.Text + "' and Date<='" + txtto.Text + "'";
                    tb = db.Search(query);
                    if (tb.Rows[0][0].ToString() != "")
                    {
                        Deposit = double.Parse(tb.Rows[0][0].ToString());
                    }
                    else
                    {
                        Deposit = 0;
                    }


                    //Withdraw
                    query = "select sum(Amount) from BankTransactions where Type='" + "Withdraw" + "' and Date>='" + txtfrom.Text + "' and Date<='" + txtto.Text + "'";
                    tb = db.Search(query);
                    if (tb.Rows[0][0].ToString() != "")
                    {
                        Withdraw = double.Parse(tb.Rows[0][0].ToString());
                    }
                    else
                    {
                        Withdraw = 0;
                    }

                    //Profit
                    query = "select   sum((Billing.SellPrice-Inventory.Cost)*Billing.Quantity)  from Inventory, Billing, ItemInformation where ItemInformation.ItemCode=Inventory.ItemCode and Inventory.ID=Billing.ItemID  and Billing.Date>='" + txtfrom.Text + "' and Billing.Date<='" + txtto.Text + "'";
                    tb = db.Search(query);
                    if (tb.Rows[0][0].ToString() != "")
                    {
                        profit = double.Parse(tb.Rows[0][0].ToString());
                    }
                    else
                    {
                        profit = 0;
                    }
                    ReportDocument rep = new ReportDocument();
                    rep.Load(@"C:\PS Supermarket\Summary Report.rpt");
                    rep.SetParameterValue("From", txtfrom.Text);
                    rep.SetParameterValue("To", txtto.Text);
                    rep.SetParameterValue("Sales", Sales);
                    rep.SetParameterValue("Returns", Return);
                    rep.SetParameterValue("Purchasing", Purchasing);
                    rep.SetParameterValue("Expenses", Expenses);
                    rep.SetParameterValue("Deposit", Deposit);
                    rep.SetParameterValue("Withdraw", Withdraw);
                    rep.SetParameterValue("Profit", profit);
                    rep.SetParameterValue("OpeningBalance", openingbalance);
                    rep.SetParameterValue("ClosingBalance", closingbalance);
                    string path = @"C:\PS Supermarket\Summary Report.pdf";
                    db.CrystalReportServer(rep);
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                    rep.ExportToDisk(ExportFormatType.PortableDocFormat, path);
                    Process.Start(path);
                    this.Cursor = Cursors.Default;
                }
                catch (Exception ex)
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
