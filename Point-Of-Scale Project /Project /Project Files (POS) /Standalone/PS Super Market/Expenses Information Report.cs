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
    public partial class Expenses_Information_Report : Form
    {
        public Expenses_Information_Report()
        {
            InitializeComponent();
        }
        string query, path;
        MainClass db = new MainClass();
        DataTable tb;

        private void Expenses_Information_Report_Load(object sender, EventArgs e)
        {
            path = @"C:\PS Supermarket\Expenses Information.pdf";

            LoadCategories();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                ReportDocument rep = new ReportDocument();
                rep.Load(@"C:\PS Supermarket\Expenses Report.rpt");
                db.CrystalReportServer(rep);
                rep.SetParameterValue("From", txtfrom.Text);
                rep.SetParameterValue("To", txtto.Text);
                rep.SetParameterValue("Category", txtcategory.Text);
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

        private void LoadCategories()
        {
            tb = db.SearchStoredProcedure("ExpensesCategories");
            if (tb.Rows.Count > 0)
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    if (!txtcategory.Items.Contains(tb.Rows[i][0].ToString()))
                    {
                        txtcategory.Items.Add(tb.Rows[i][0].ToString());
                    }
                }
            }
        }
    }
}
