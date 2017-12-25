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
    public partial class Bank_Information_Reports : Form
    {
        public Bank_Information_Reports()
        {
            InitializeComponent();
        }
        MainClass db = new MainClass();
        DataTable tb;
        string query;
        private void Bank_Information_Reports_Load(object sender, EventArgs e)
        {
            query = "select BankName from BankInformation group by BankName";
            tb = db.Search(query);
            if (tb.Rows.Count>0)
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    txtbank.Items.Add(tb.Rows[i][0].ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                ReportDocument rep = new ReportDocument();
                rep.Load(@"C:\PS Supermarket\Bank Information.rpt");
                string path = @"C:\PS Supermarket\Bank Information.pdf";
                db.CrystalReportServer(rep);
                rep.SetParameterValue("BankName", txtbank.Text);
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
