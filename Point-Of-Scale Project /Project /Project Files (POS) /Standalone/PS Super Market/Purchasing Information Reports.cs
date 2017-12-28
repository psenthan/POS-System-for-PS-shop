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
    public partial class Purchasing_Information_Reports : Form
    {
        public Purchasing_Information_Reports()
        {
            InitializeComponent();
        }
        DataTable tb;
        MainClass db = new MainClass();
        string query; 
        private void Purchasing_Information_Reports_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }
        private void LoadSuppliers()
        {
            query = "select Name from SupplierInformation";
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

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                ReportDocument rep = new ReportDocument();
                rep.Load(@"C:\PS Supermarket\Purchasing Report.rpt");
                string path = @"C:\PS Supermarket\Purchasing Information.pdf";
                rep.SetParameterValue("From", txtfrom.Text);
                rep.SetParameterValue("To", txtto.Text);
                rep.SetParameterValue("Supplier", txtcustomer.Text);
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
            this.Cursor = Cursors.Default;
        }
    }
}
