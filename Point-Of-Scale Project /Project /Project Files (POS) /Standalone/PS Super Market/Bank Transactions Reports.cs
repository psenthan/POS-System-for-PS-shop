using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
namespace PS_Super_Market
{
    public partial class Bank_Transactions_Reports : Form
    {
        public Bank_Transactions_Reports()
        {
            InitializeComponent();
        }
        string type="";
        MainClass db = new MainClass();
        DataTable tb;
        string query;
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                ReportDocument rep = new ReportDocument();
                string path = @"C:\PS Supermarket\Bank Transactions.pdf";
                
                rep.Load(@"C:\PS Supermarket\Bank Transactions.rpt");
                db.CrystalReportServer(rep);
                rep.SetParameterValue("From", txtfrom.Text);
                rep.SetParameterValue("To", txtto.Text);
                rep.SetParameterValue("Type", type);
                rep.SetParameterValue("Bank", txtbankidentity.Text);
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                rep.ExportToDisk(ExportFormatType.PortableDocFormat, path);
                Process.Start(path);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadAllBanks()
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
        private void chkdeposit_CheckedChanged(object sender, EventArgs e)
        {
            type = "";
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

        private void chkwithdraw_CheckedChanged(object sender, EventArgs e)
        {
            type = "";
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

        private void Bank_Transactions_Reports_Load(object sender, EventArgs e)
        {
            LoadAllBanks();
        }
    }
}
