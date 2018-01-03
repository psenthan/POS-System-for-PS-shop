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
using LiveCharts.Wpf;
using LiveCharts;
namespace PS_Super_Market
{
    public partial class Profit_Chart_Generator : Form
    {
        public Profit_Chart_Generator()
        {
            InitializeComponent();
        }
        MainClass db = new MainClass();
        DataTable tb;
        string query, msg;

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtyear.Text != "")
            {
                try
                {
                    
                    this.Cursor = Cursors.WaitCursor;
                    db.Delete("delete from TempSalesChart");
                    query = "select   Month( Billing.Date), sum((Billing.SellPrice-Inventory.Cost)*Billing.Quantity)  from Inventory, Billing, ItemInformation where Iteminformation.ItemCode=Inventory.ItemCode and Inventory.ID=Billing.ItemID and Year(Billing.Date)='" + txtyear.Text + "'   group by Month(Billing.Date) ";
                    tb = db.Search(query);
                    if (tb.Rows.Count > 0)
                    {
                        for (int i = 0; i < tb.Rows.Count; i++)
                        {
                            query = "insert into TempSalesChart values ('" + txtyear.Text + "', '" + tb.Rows[i][0].ToString() + "','" + tb.Rows[i][1].ToString() + "')";
                            db.Insert(query);
                        }

                        ReportDocument rep = new ReportDocument();
                        rep.Load(@"C:\PS Supermarket\Profit Chart Report.rpt");
                        db.CrystalReportServer(rep);
                        string path = @"C:\PS Supermarket\Profit Chart.pdf";
                        if (File.Exists(path))
                        {
                            File.Delete(query);
                        }
                        rep.ExportToDisk(ExportFormatType.PortableDocFormat, path);
                        Process.Start(path);
                    }
                    else
                    {
                        MessageBox.Show("--No Records Found--", "System Admin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    this.Cursor = Cursors.Default;
                }
                catch (Exception ex)
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtyear_Leave(object sender, EventArgs e)
        {
            if (CheckIsInt(txtyear.Text) && txtyear.Text.Length == 4)
            {

            }
            else
            {
                MessageBox.Show("Invalid Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtyear.ResetText();
                txtyear.Focus();
            }
        }
        private bool CheckIsInt(string input)
        {
            int value;
            if (int.TryParse(input, out value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtyear_SelectedIndexChanged(object sender, EventArgs e)
        {
             
           
        }

        private void Profit_Chart_Generator_Load(object sender, EventArgs e)
        {
            query = "select Year(Date) from Billing group by Year(Date)";
            tb = db.Search(query);
            if (tb.Rows.Count > 0)
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    txtyear.Items.Add(tb.Rows[i][0].ToString());
                }
            }
        }
    }
}
