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
    public partial class Sales_Information_Report : Form
    {
        public Sales_Information_Report()
        {
            InitializeComponent();
        }
        MainClass db = new MainClass();
        DataTable tb;
        string query, path;
        
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                path = @"C:\PS Supermarket\Sales Report.pdf";
                ReportDocument rep = new ReportDocument();
                rep.Load(@"C:\PS Supermarket\Sales Report.rpt");
                db.CrystalReportServer(rep);
                rep.SetParameterValue("From", txtfrom.Text);
                rep.SetParameterValue("To", txtto.Text);
                rep.SetParameterValue("CustomerID", txtcustomer.Text);
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

        private void Sales_Information_Report_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            query = "select Name from CustomerInformation";
            tb = db.Search(query);
            if (tb.Rows.Count > 0)
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    if (!txtcustomer.Items.Contains(tb.Rows[i][0].ToString()))
                    {
                        txtcustomer.Items.Add(tb.Rows[i][0].ToString());
                    }
                }
            }
        }
    }
}
