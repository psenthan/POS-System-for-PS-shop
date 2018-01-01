using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.Wpf;
using LiveCharts;
using System.Media;
using Encryption;
namespace PS_Super_Market
{
    public partial class Main_Menu : Form
    {
        private int childFormNumber = 0;

        public Main_Menu()
        {
            InitializeComponent();
        }
        
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
         }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        public string[] Info
        {
            set
            {
                txtdate.Text = value[0];
                username = value[1];
            }
        }
        string prishift = "False", msg;
        private void CheckShift()
        {
            this.WindowState = FormWindowState.Maximized;
            query = "select Status from Shift where Date='" + txtdate.Text + "'";
            tb = db.Search(query);
            if (tb.Rows.Count > 0)
            {
                if (tb.Rows[0][0].ToString() == "Closed")
                {
                    if (prishift == "True")
                    {
                        query = "update Shift set [End]='" + "" + "', Status='" + "Open" + "' where Date='" + txtdate.Text + "'";
                        msg = db.Update(query);
                        if (msg == "1")
                        {
                            MessageBox.Show("This has been Re-Opened Successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Restart();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Today Cashdraw has been closed, Application will be restarted", "Closed Cashdrwa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Application.Restart();
                    }
                }

            }
            else

            {
                Cashdraw_Open sr = new Cashdraw_Open();
                sr.Date = txtdate.Text;
                sr.ShowDialog();
            }
        }
        string username,role;
        private void Main_Menu_Load(object sender, EventArgs e)
        {
            lblyear.Text = DateTime.Now.Year.ToString() + " Summary";
            backgroundWorker1.RunWorkerAsync();

            query = "select Role from Login where username='" + Class1.Encrypt(username) + "'";
            tb = db.Search(query);
            if (tb.Rows.Count > 0)
            {
                if (Class1.Decrypt(tb.Rows[0][0].ToString()) == "Administrator" || Class1.Decrypt(tb.Rows[0][0].ToString()) == "Sales Supervisor" || Class1.Decrypt(tb.Rows[0][0].ToString()) == "Stock Supervisor")
                {
                    prishift = "True";
                }
                else
                {
                    prishift = "False";
                }
                role = Class1.Decrypt(tb.Rows[0][0].ToString());
                //Purchasing
                newPurchasingToolStripMenuItem1.Enabled = false;
                purchasingReportToolStripMenuItem.Enabled = false;
                deletePurchasingToolStripMenuItem.Enabled = false;
                updateItemInfomationToolStripMenuItem.Enabled = false;
                inventoryReportToolStripMenuItem.Enabled = false;


                //Sales

                newInvoiceToolStripMenuItem.Enabled = false;
                salesInformationReportToolStripMenuItem.Enabled = false;
                deleteBillingToolStripMenuItem.Enabled = false;
                salesChartToolStripMenuItem.Enabled = false;

                //Bank Transactions

                bankManagementToolStripMenuItem.Enabled = false;
                newTransactionsToolStripMenuItem.Enabled = false;
                deleteTransactionsToolStripMenuItem.Enabled = false;
                transactionsReportToolStripMenuItem.Enabled = false;
                registeredBanksToolStripMenuItem.Enabled = false;
                //Expenses
                newExpenseToolStripMenuItem.Enabled = false;
                deleteExpenseToolStripMenuItem.Enabled = false;
                expensesReportToolStripMenuItem.Enabled = false;
                chartReportToolStripMenuItem.Enabled = false;

                //User Management
                userManagementToolStripMenuItem.Enabled = false;

                //Summary Reports
                summaryInformationToolStripMenuItem1.Enabled = false;
                dailySummaryToolStripMenuItem.Enabled = false;

                //Profit Chart
                profitChartToolStripMenuItem.Enabled = false;

                //Supplier Management

                supplierManagementToolStripMenuItem.Enabled = false;
                if (Class1.Decrypt(tb.Rows[0][0].ToString()) == "Administrator")
                {
                    //Purchasing
                    newPurchasingToolStripMenuItem1.Enabled = true;
                    purchasingReportToolStripMenuItem.Enabled = true;
                    deletePurchasingToolStripMenuItem.Enabled = true;
                    updateItemInfomationToolStripMenuItem.Enabled = true;
                    inventoryReportToolStripMenuItem.Enabled = true;


                    //Sales

                    newInvoiceToolStripMenuItem.Enabled = true;
                    salesInformationReportToolStripMenuItem.Enabled = true;
                    deleteBillingToolStripMenuItem.Enabled = true;
                    salesChartToolStripMenuItem.Enabled = true;

                    //Bank Transactions

                    bankManagementToolStripMenuItem.Enabled = true;
                    newTransactionsToolStripMenuItem.Enabled = true;
                    deleteTransactionsToolStripMenuItem.Enabled = true;
                    transactionsReportToolStripMenuItem.Enabled = true;
                    registeredBanksToolStripMenuItem.Enabled = true;
                    //Expenses
                    newExpenseToolStripMenuItem.Enabled = true;
                    deleteExpenseToolStripMenuItem.Enabled = true;
                    expensesReportToolStripMenuItem.Enabled = true;
                    chartReportToolStripMenuItem.Enabled = true;

                    //User Management
                    userManagementToolStripMenuItem.Enabled = true;

                    //Summary Reports
                    summaryInformationToolStripMenuItem1.Enabled = true;
                    dailySummaryToolStripMenuItem.Enabled = true;

                    //Profit Chart
                    profitChartToolStripMenuItem.Enabled = true;

                    //Supplier Management

                    supplierManagementToolStripMenuItem.Enabled = true;


                }
                else if (Class1.Decrypt(tb.Rows[0][0].ToString()) == "Sales Supervisor")
                {
                    newInvoiceToolStripMenuItem.Enabled = true;
                    salesInformationReportToolStripMenuItem.Enabled = true;
                    deleteBillingToolStripMenuItem.Enabled = true;
                    salesChartToolStripMenuItem.Enabled = true;
                    dailySummaryToolStripMenuItem.Enabled = true;
                    inventoryReportToolStripMenuItem.Enabled = true;
                }
                else if (Class1.Decrypt(tb.Rows[0][0].ToString()) == "Stock Supervisor")
                {
                    newPurchasingToolStripMenuItem1.Enabled = true;
                    purchasingReportToolStripMenuItem.Enabled = true;
                    deletePurchasingToolStripMenuItem.Enabled = true;
                    updateItemInfomationToolStripMenuItem.Enabled = true;
                    inventoryReportToolStripMenuItem.Enabled = true;
                }
                else if (Class1.Decrypt(tb.Rows[0][0].ToString()) == "Sales Agent")
                {
                    newInvoiceToolStripMenuItem.Enabled = true;
                    salesInformationReportToolStripMenuItem.Enabled = true;


                }
                else if (Class1.Decrypt(tb.Rows[0][0].ToString()) == "Stock Keeper")
                {
                    newPurchasingToolStripMenuItem1.Enabled = true;
                    purchasingReportToolStripMenuItem.Enabled = true;
                     
                }
                }

         

            CheckShift();
            if (role=="Administrator" || role=="Stock Supervisor")
            {
                query = "select * from Inventory where Quantity<=Alert";
                tb = db.Search(query);
                if (tb.Rows.Count > 0)
                {
                    lblreorder.Text = "Reorders Found";
                    lblreorder.ForeColor = Color.Red;
                }
                else
                {
                    lblreorder.Visible = false;

                } 
            }
            else
            {
                lblreorder.Visible = false;
            }
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Management ur = new User_Management();
            ur.MdiParent = this;
            ur.Show();
        }

        private void newExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expenses_Management er = new Expenses_Management();
            string[] row = { txtdate.Text, username, "0" };
            er.MdiParent = this;
            er.Info = row;
            er.Show();
        }

        private void deleteExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expenses_Management er = new Expenses_Management();
            string[] row = { txtdate.Text, username, "1" };
            er.MdiParent = this;
            er.Info = row;
            er.Show();
        }

        private void expensesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expenses_Information_Report er = new Expenses_Information_Report();
            er.MdiParent = this;
            er.Show();
        }

        private void bankManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Banks_Management br = new Banks_Management();
            br.MdiParent = this;
            br.Show();
        }

        private void bankTransactionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void newTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bank_Transactions_Management br = new Bank_Transactions_Management();
            string[] row = {txtdate.Text, username, "0" };
            br.Info = row;
            br.MdiParent = this;
            br.Show();
        }

        private void deleteTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bank_Transactions_Management br = new Bank_Transactions_Management();
            string[] row = { txtdate.Text, username, "1" };
            br.Info = row;
            br.MdiParent = this;
            br.Show();
        }

        private void salesChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales_Chart_Reports sr = new Sales_Chart_Reports();
            sr.MdiParent = this;
            sr.Show();
        }

        private void salesInformationReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales_Information_Report sr = new Sales_Information_Report();
            sr.MdiParent = this;
            sr.Show();
        }

        private void newInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Billing_Management br = new Billing_Management();
            string[] row = { username, txtdate.Text, "0" };
            br.Info = row;
            br.MdiParent = this;
            br.Show();
        }

        private void deleteBillingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Billing_Management br = new Billing_Management();
            string[] row = { username, txtdate.Text, "1" };
            br.Info = row;
            br.MdiParent = this;
            br.Show();
        }
        string query;
        MainClass db = new MainClass();
        DataTable tb;
        double expenses=0, sales = 0, purchasing = 0, bankdeposit = 0, bankwithdraw = 0;

        string name1, name2, name3, name4, name5;

        private void Main_Menu_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void cartesianChart2_DataClick(object sender, ChartPoint chartPoint)
        {
           
        }

        private void Main_Menu_Click(object sender, EventArgs e)
        {
            ShowCharts();
        }
      
        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void visibleChartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCharts();
        }

        private void ShowCharts()
        {
            //if (!backgroundWorker1.IsBusy)
            //{
            //    backgroundWorker1.RunWorkerAsync();
            //}
           // pieChart1.Visible = true;
            pieChart2.Visible = true;

            pieChart3.Visible = true;
            cartesianChart2.Visible = true;
            label1.Visible = true;
            lbl3.Visible = true;
            lblyear.Visible = true;
        }

        private void purchasingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartsVisibility();
        }

        private void ChartsVisibility()
        {
            //pieChart1.Visible = false;
            pieChart2.Visible = false;
            pieChart3.Visible = false;
            label1.Visible = false;
            lbl3.Visible = false;
            lblyear.Visible = false;
            cartesianChart2.Visible = false;
        }

        private void billingManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartsVisibility();
        }

        private void managementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartsVisibility();
        }

        private void menuStrip_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void menuStrip_Leave(object sender, EventArgs e)
        {
            ShowCharts();
        }

        private void menuStrip_MouseHover(object sender, EventArgs e)
        {
            ChartsVisibility();
        }

        private void Main_Menu_MouseHover(object sender, EventArgs e)
        { 
        }

        private void Main_Menu_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void newPurchasingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Purchasing_Management pr = new Purchasing_Management();
            string[] row = { txtdate.Text, username, "0" };
            pr.Info = row;
            pr.MdiParent = this;
            pr.Show();
        }

        private void deletePurchasingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchasing_Management pr = new Purchasing_Management();
            string[] row = { txtdate.Text, username, "1" };
            pr.Info = row;
            pr.MdiParent = this;
            pr.Show();
        }

        private void chartReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expenses_Chart ex = new Expenses_Chart();
            ex.MdiParent = this;
            ex.Show();
        }

        private void transactionsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bank_Transactions_Reports br = new Bank_Transactions_Reports();
            br.MdiParent = this;
            br.Show();
        }

        private void purchasingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchasing_Information_Reports pr = new Purchasing_Information_Reports();
            pr.MdiParent = this;
            pr.Show();
        }

        private void summaryInformationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Summary_Reports_Information sr = new Summary_Reports_Information();
            sr.Daily = "0";
            sr.MdiParent = this;
            sr.Show();
        }

        private void dailySummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Summary_Reports_Information sr = new Summary_Reports_Information();
            sr.Daily = "1";
            sr.MdiParent = this;
            sr.Show();
        }

        private void profitChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profit_Chart_Generator pr = new Profit_Chart_Generator();
            pr.MdiParent = this;
            pr.Show();
        }

        private void supplierManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier_Management sr = new Supplier_Management();
            sr.MdiParent = this;
            sr.Show();
        }

        private void registeredBanksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bank_Information_Reports br = new Bank_Information_Reports();
            br.MdiParent = this;
            br.Show();
        }

        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cashdraw_Close cr = new Cashdraw_Close();
            cr.Date = txtdate.Text;
           
            cr.ShowDialog();
        }

        private void updateItemInfomationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_Stock_Information up = new Update_Stock_Information();
            up.MdiParent = this;
            up.Show();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult msg2 = MessageBox.Show("Do you want to restart the System? Unsaved Data may lost", "Restart Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg2==DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult msg2 = MessageBox.Show("Do you want to Exit from the System? Unsaved Data may lost", "Shutdown Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg2 == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lblreorder_Click(object sender, EventArgs e)
        {
            Stock_Information_Reports sr = new Stock_Information_Reports();
            sr.MdiParent = this;
            sr.Show();
        }

        private void inventoryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_Information_Reports sr = new Stock_Information_Reports();
            sr.MdiParent = this;
            sr.Show();
        }

        double amount1 = 0, amount2 = 0, amount3 = 0, amount4 = 0, amount5 = 0;

        double yr1 = 0, yr2 = 0, yr3 = 0, yr4 = 0, yr5=0, pyr1 = 0, pyr2 = 0, pyr3 = 0, pyr4 = 0, pyr5=0;
        string year1, year2;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                PiechartCompleted();

                SecondPieChart();
                Barchart();
            }));
        }

        private void Barchart()
        {
            year1 = DateTime.Now.Year.ToString();
            year2 = DateTime.Now.AddYears(-1).Year.ToString();

            lbl3.Text = "Comparing Summary of " + year1 + " and " + year2;

            query = "select sum(subtotal) from Billing where Year(Date)='" + DateTime.Now.Year + "'";
            tb = db.Search(query);
            if (tb.Rows[0][0].ToString() != "")
            {
                yr1 = double.Parse(tb.Rows[0][0].ToString());
            }
            else
            {
                yr1 = 0;
            }
            query = "select sum(subtotal) from Billing where Year(Date)='" + DateTime.Now.AddYears(-1).Year + "'";
            tb = db.Search(query);
            if (tb.Rows[0][0].ToString() != "")
            {
                pyr1 = double.Parse(tb.Rows[0][0].ToString());
            }
            else
            {
                pyr1 = 0;
            }

            query = "select sum(Amount) from Expenses where Year(Date)='" + DateTime.Now.Year + "'";
            tb = db.Search(query);
            if (tb.Rows[0][0].ToString() != "")
            {
                yr2 = double.Parse(tb.Rows[0][0].ToString());
            }
            else
            {
                yr2 = 0;
            }
            query = "select sum(Amount) from Expenses where Year(Date)='" + DateTime.Now.AddYears(-1).Year + "'";
            tb = db.Search(query);
            if (tb.Rows[0][0].ToString() != "")
            {
                pyr2 = double.Parse(tb.Rows[0][0].ToString());
            }
            else
            {
                pyr2 = 0;
            }

            query = "select sum(subtotal) from Purchasing where Year(Date)='" + DateTime.Now.Year + "'";
            tb = db.Search(query);
            if (tb.Rows[0][0].ToString() != "")
            {
                yr3 = double.Parse(tb.Rows[0][0].ToString());
            }
            else
            {
                yr3 = 0;
            }
            query = "select sum(subtotal) from Purchasing where Year(Date)='" + DateTime.Now.AddYears(-1).Year + "'";
            tb = db.Search(query);
            if (tb.Rows[0][0].ToString() != "")
            {
                pyr3 = double.Parse(tb.Rows[0][0].ToString());
            }
            else
            {
                pyr3 = 0;
            }


            query = "select sum(Amount) from BankTransactions where Type='" + "Deposit" + "' and Year(Date)='" + DateTime.Now.Year + "'";
            tb = db.Search(query);
            if (tb.Rows[0][0].ToString() != "")
            {
                yr4 = double.Parse(tb.Rows[0][0].ToString());
            }
            else
            {
                yr4 = 0;
            }

            query = "select sum(Amount) from BankTransactions where Type='" + "Deposit" + "' and Year(Date)='" + DateTime.Now.AddYears(-1).Year + "'";
            tb = db.Search(query);
            if (tb.Rows[0][0].ToString() != "")
            {
                pyr4 = double.Parse(tb.Rows[0][0].ToString());
            }
            else
            {
                pyr4 = 0;
            }

            query = "select sum(Amount) from BankTransactions where Type='" + "Withdraw" + "' and Year(Date)='" + DateTime.Now.Year + "'";
            tb = db.Search(query);
            if (tb.Rows[0][0].ToString() != "")
            {
                yr5 = double.Parse(tb.Rows[0][0].ToString());
            }
            else
            {
                yr5= 0;
            }

            query = "select sum(Amount) from BankTransactions where Type='" + "Withdraw" + "' and Year(Date)='" + DateTime.Now.AddYears(-1).Year + "'";
            tb = db.Search(query);
            if (tb.Rows[0][0].ToString() != "")
            {
                pyr5 = double.Parse(tb.Rows[0][0].ToString());
            }
            else
            {
                pyr5 = 0;
            }

            cartesianChart2.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = year1,
                    Values = new ChartValues<double> { yr1, yr2, yr3, yr4, yr5 }
                }
            };

            //adding series will update and animate the chart automatically
            cartesianChart2.Series.Add(new ColumnSeries
            {
                Title = year2,
                Values = new ChartValues<double> { pyr1, pyr2, pyr3, pyr4, pyr5 }
            });

            //also adding values updates and animates the chart automatically
            cartesianChart2.Series[1].Values.Add(48d);

            cartesianChart2.AxisX.Add(new Axis
            {
                Title = "Category",
                Labels = new[] { "Sales", "Expenses", "Purchasing", "Bank Deposit", "Bank Withdrawal" }
            });

            cartesianChart2.AxisY.Add(new Axis
            {
                Title = "Recent Years Summary",
                LabelFormatter = value => value.ToString("N")
            });
        }

        private void SecondPieChart()
        {
            try
            {
                query = "select Inventory.ItemCode, sum(Billing.Quantity) as quantity from Billing, Inventory, ItemInformation where ItemInformation.ItemCode=Inventory.ItemCode and Inventory.ID=Billing.ItemID group by Inventory.ItemCode  order by quantity desc";
                tb = db.Search(query);
                if (tb.Rows.Count > 0)
                {
                    name1 = tb.Rows[0][0].ToString();
                    name2 = tb.Rows[1][0].ToString();
                    name3 = tb.Rows[2][0].ToString();
                    name4 = tb.Rows[3][0].ToString();
                    name5 = tb.Rows[4][0].ToString();

                    amount1 = double.Parse(tb.Rows[0][1].ToString());
                    amount2 = double.Parse(tb.Rows[1][1].ToString());
                    amount3 = double.Parse(tb.Rows[2][1].ToString());
                    amount4 = double.Parse(tb.Rows[3][1].ToString());
                    amount5 = double.Parse(tb.Rows[4][1].ToString());


                    query = "select description from ItemInformation where ItemCode='" + name1 + "'";
                    tb = db.Search(query);
                    name1 = tb.Rows[0][0].ToString();

                    query = "select description from ItemInformation where ItemCode='" + name2 + "'";
                    tb = db.Search(query);
                    name2 = tb.Rows[0][0].ToString();

                    query = "select description from ItemInformation where ItemCode='" + name3 + "'";
                    tb = db.Search(query);
                    name3 = tb.Rows[0][0].ToString();

                    query = "select description from ItemInformation where ItemCode='" + name4 + "'";
                    tb = db.Search(query);
                    name4 = tb.Rows[0][0].ToString();

                    query = "select description from ItemInformation where ItemCode='" + name5 + "'";
                    tb = db.Search(query);
                    name5 = tb.Rows[0][0].ToString();

                }


                Func<ChartPoint, string> labelPoint = chartPoint =>
                    string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

                pieChart2.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = name1,
                    Values = new ChartValues<double> {amount1},

                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = name2,
                    Values = new ChartValues<double> {amount2},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = name3,
                    Values = new ChartValues<double> {amount3},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = name4,
                    Values = new ChartValues<double> {amount4},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = name5,
                    Values = new ChartValues<double> {amount5},
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };

                pieChart2.LegendLocation = LegendLocation.Bottom;
            }
            catch  
            {

                
            }
        }

        private void PiechartCompleted()
        {
            query = "select sum(Amount) from expenses where Year(Date)='" + DateTime.Now.Year + "'";
            tb = db.Search(query);
            if (tb.Rows[0][0].ToString() != "")
            {
                expenses = double.Parse(tb.Rows[0][0].ToString());
            }
            else
            {
                expenses = 0;
            }
            query = "select sum(SubTotal) from Billing where Year(Date)='" + DateTime.Now.Year + "'";
            tb = db.Search(query);
            if (tb.Rows[0][0].ToString() != "")
            {
                sales = double.Parse(tb.Rows[0][0].ToString());
            }
            else
            {
                sales = 0;
            }
            query = "select sum(SubTotal) from Purchasing where Year(Date)='" + DateTime.Now.Year + "'";
            tb = db.Search(query);
            if (tb.Rows[0][0].ToString() != "")
            {
                purchasing = double.Parse(tb.Rows[0][0].ToString());
            }
            else
            {
                purchasing = 0;
            }

            query = "select sum(Amount) from BankTransactions where Type='" + "Deposit" + "' and Year(Date)='" + DateTime.Now.Year + "'";
            tb = db.Search(query);
            if (tb.Rows[0][0].ToString() != "")
            {
                bankdeposit = double.Parse(tb.Rows[0][0].ToString());
            }
            else
            {
                bankdeposit = 0;
            }
            query = "select sum(Amount) from BankTransactions where Type='" + "Withdraw" + "' and Year(Date)='" + DateTime.Now.Year + "'";
            tb = db.Search(query);
            if (tb.Rows[0][0].ToString() != "")
            {
                bankwithdraw = double.Parse(tb.Rows[0][0].ToString());
            }
            else
            {
                bankwithdraw = 0;
            }
            Piechart();
        }

        private void Piechart()
        {
            pieChart3.InnerRadius = 100;
            pieChart3.LegendLocation = LegendLocation.Right;

            pieChart3.Series = new SeriesCollection
            {
                new PieSeries
                {

                    Title = "Expenses",
                    Values = new ChartValues<double> {expenses},
                 
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Sales",
                    Values = new ChartValues<double> {sales},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Purchasing",
                    Values = new ChartValues<double> {purchasing},
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Bank Deposits",
                    Values = new ChartValues<double> {bankdeposit},
                    DataLabels = true
                },new PieSeries
                {
                    Title = "Bank Withdrawal",
                    Values = new ChartValues<double> {bankwithdraw},
                    DataLabels = true
                }
            };
            
        }
    }
}
