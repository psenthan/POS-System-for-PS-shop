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
    public partial class Expenses_Chart : Form
    {
        public Expenses_Chart()
        {
            InitializeComponent();
        }
        MainClass db = new MainClass();
        DataTable tb;
        string query, msg;

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (txtyear.Text!="")
            {
                try
                {
                    db.Delete("delete from TempChart");
                    query = "select Month(Date),sum(Amount) from Expenses where Year(Date)='" + txtyear.Text + "' group by Month(Date)";
                    tb = db.Search(query);
                    if (tb.Rows.Count > 0)
                    {
                        for (int i = 0; i < tb.Rows.Count; i++)
                        {
                            query = "insert into TempChart values ('" + tb.Rows[i][0].ToString() + "', '" + tb.Rows[i][1].ToString() + "')";
                            msg = db.Insert(query);
                        }

                        ReportDocument rep = new ReportDocument();
                        rep.Load(@"C:\PS Supermarket\Expenses Chart Report.rpt");
                        string path = @"C:\PS Supermarket\Expenses Chart.pdf";
                        rep.SetParameterValue("Year", txtyear.Text);
                        if (File.Exists(path))
                        {
                            File.Delete(path);
                        }
                        rep.ExportToDisk(ExportFormatType.PortableDocFormat, path);
                        Process.Start(path);
                    }
                    else
                    {
                        MessageBox.Show("--No Records Found--", "Invalid Year", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("--Invalid Entry--", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Expenses_Chart_Load(object sender, EventArgs e)
        {
            query = "select Year(Date) from Expenses group by Year(Date)";
            tb = db.Search(query);
            if (tb.Rows.Count>0)
            {
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    txtyear.Items.Add(tb.Rows[i][0].ToString());
                }
            }
        }
    }
}
