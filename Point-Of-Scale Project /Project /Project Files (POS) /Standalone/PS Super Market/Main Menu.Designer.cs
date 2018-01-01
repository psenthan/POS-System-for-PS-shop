namespace PS_Super_Market
{
    partial class Main_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchasingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPurchasingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPurchasingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.purchasingReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePurchasingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateItemInfomationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBillingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesInformationReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBillingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankTransactionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registeredBanksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expensesManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newExpenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteExpenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expensesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryInformationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dailySummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profitChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visibleChartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.label1 = new System.Windows.Forms.Label();
            this.lblyear = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl3 = new System.Windows.Forms.Label();
            this.cachedExpenses_Chart_Report1 = new PS_Super_Market.CachedExpenses_Chart_Report();
            this.cartesianChart2 = new LiveCharts.WinForms.CartesianChart();
            this.pieChart2 = new LiveCharts.WinForms.PieChart();
            this.pieChart3 = new LiveCharts.WinForms.PieChart();
            this.lblreorder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Black;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.purchasingToolStripMenuItem,
            this.billingManagementToolStripMenuItem,
            this.managementToolStripMenuItem,
            this.visibleChartsToolStripMenuItem,
            this.cashdrawToolStripMenuItem,
            this.lblreorder});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(98, 704);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.Layout += new System.Windows.Forms.LayoutEventHandler(this.menuStrip_Layout);
            this.menuStrip.Leave += new System.EventHandler(this.menuStrip_Leave);
            this.menuStrip.MouseHover += new System.EventHandler(this.menuStrip_MouseHover);
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.applicationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(85, 19);
            this.applicationToolStripMenuItem.Text = "App";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // purchasingToolStripMenuItem
            // 
            this.purchasingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPurchasingToolStripMenuItem,
            this.deletePurchasingToolStripMenuItem,
            this.updateItemInfomationToolStripMenuItem,
            this.reportsToolStripMenuItem2});
            this.purchasingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasingToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.purchasingToolStripMenuItem.Name = "purchasingToolStripMenuItem";
            this.purchasingToolStripMenuItem.Size = new System.Drawing.Size(85, 19);
            this.purchasingToolStripMenuItem.Text = "Buy Goods";
            this.purchasingToolStripMenuItem.Click += new System.EventHandler(this.purchasingToolStripMenuItem_Click);
            // 
            // newPurchasingToolStripMenuItem
            // 
            this.newPurchasingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPurchasingToolStripMenuItem1,
            this.purchasingReportToolStripMenuItem});
            this.newPurchasingToolStripMenuItem.Name = "newPurchasingToolStripMenuItem";
            this.newPurchasingToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.newPurchasingToolStripMenuItem.Text = "New Purchasing";
            // 
            // newPurchasingToolStripMenuItem1
            // 
            this.newPurchasingToolStripMenuItem1.Name = "newPurchasingToolStripMenuItem1";
            this.newPurchasingToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.newPurchasingToolStripMenuItem1.Text = "New Purchasing";
            this.newPurchasingToolStripMenuItem1.Click += new System.EventHandler(this.newPurchasingToolStripMenuItem1_Click);
            // 
            // purchasingReportToolStripMenuItem
            // 
            this.purchasingReportToolStripMenuItem.Name = "purchasingReportToolStripMenuItem";
            this.purchasingReportToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.purchasingReportToolStripMenuItem.Text = "Purchasing Report";
            this.purchasingReportToolStripMenuItem.Click += new System.EventHandler(this.purchasingReportToolStripMenuItem_Click);
            // 
            // deletePurchasingToolStripMenuItem
            // 
            this.deletePurchasingToolStripMenuItem.Name = "deletePurchasingToolStripMenuItem";
            this.deletePurchasingToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.deletePurchasingToolStripMenuItem.Text = "Delete Purchasing";
            this.deletePurchasingToolStripMenuItem.Click += new System.EventHandler(this.deletePurchasingToolStripMenuItem_Click);
            // 
            // updateItemInfomationToolStripMenuItem
            // 
            this.updateItemInfomationToolStripMenuItem.Name = "updateItemInfomationToolStripMenuItem";
            this.updateItemInfomationToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.updateItemInfomationToolStripMenuItem.Text = "Update Item Infomation";
            this.updateItemInfomationToolStripMenuItem.Click += new System.EventHandler(this.updateItemInfomationToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem2
            // 
            this.reportsToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryReportToolStripMenuItem});
            this.reportsToolStripMenuItem2.Name = "reportsToolStripMenuItem2";
            this.reportsToolStripMenuItem2.Size = new System.Drawing.Size(210, 22);
            this.reportsToolStripMenuItem2.Text = "Reports";
            // 
            // inventoryReportToolStripMenuItem
            // 
            this.inventoryReportToolStripMenuItem.Name = "inventoryReportToolStripMenuItem";
            this.inventoryReportToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.inventoryReportToolStripMenuItem.Text = "Inventory Report";
            this.inventoryReportToolStripMenuItem.Click += new System.EventHandler(this.inventoryReportToolStripMenuItem_Click);
            // 
            // billingManagementToolStripMenuItem
            // 
            this.billingManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBillingToolStripMenuItem,
            this.deleteBillingToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.billingManagementToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingManagementToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.billingManagementToolStripMenuItem.Name = "billingManagementToolStripMenuItem";
            this.billingManagementToolStripMenuItem.Size = new System.Drawing.Size(85, 19);
            this.billingManagementToolStripMenuItem.Text = "Invoice";
            this.billingManagementToolStripMenuItem.Click += new System.EventHandler(this.billingManagementToolStripMenuItem_Click);
            // 
            // newBillingToolStripMenuItem
            // 
            this.newBillingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newInvoiceToolStripMenuItem,
            this.salesInformationReportToolStripMenuItem});
            this.newBillingToolStripMenuItem.Name = "newBillingToolStripMenuItem";
            this.newBillingToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.newBillingToolStripMenuItem.Text = "New Billing";
            // 
            // newInvoiceToolStripMenuItem
            // 
            this.newInvoiceToolStripMenuItem.Name = "newInvoiceToolStripMenuItem";
            this.newInvoiceToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.newInvoiceToolStripMenuItem.Text = "New Invoice";
            this.newInvoiceToolStripMenuItem.Click += new System.EventHandler(this.newInvoiceToolStripMenuItem_Click);
            // 
            // salesInformationReportToolStripMenuItem
            // 
            this.salesInformationReportToolStripMenuItem.Name = "salesInformationReportToolStripMenuItem";
            this.salesInformationReportToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.salesInformationReportToolStripMenuItem.Text = "Sales Information Report";
            this.salesInformationReportToolStripMenuItem.Click += new System.EventHandler(this.salesInformationReportToolStripMenuItem_Click);
            // 
            // deleteBillingToolStripMenuItem
            // 
            this.deleteBillingToolStripMenuItem.Name = "deleteBillingToolStripMenuItem";
            this.deleteBillingToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.deleteBillingToolStripMenuItem.Text = "Delete Billing";
            this.deleteBillingToolStripMenuItem.Click += new System.EventHandler(this.deleteBillingToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesChartToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // salesChartToolStripMenuItem
            // 
            this.salesChartToolStripMenuItem.Name = "salesChartToolStripMenuItem";
            this.salesChartToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.salesChartToolStripMenuItem.Text = "Sales Chart";
            this.salesChartToolStripMenuItem.Click += new System.EventHandler(this.salesChartToolStripMenuItem_Click);
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bankTransactionsToolStripMenuItem,
            this.expensesManagementToolStripMenuItem,
            this.userManagementToolStripMenuItem,
            this.summaryInformationToolStripMenuItem,
            this.chartInformationToolStripMenuItem,
            this.managementToolStripMenuItem1});
            this.managementToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managementToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(85, 19);
            this.managementToolStripMenuItem.Text = "Internal";
            this.managementToolStripMenuItem.Click += new System.EventHandler(this.managementToolStripMenuItem_Click);
            // 
            // bankTransactionsToolStripMenuItem
            // 
            this.bankTransactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bankManagementToolStripMenuItem,
            this.bankTransactionsToolStripMenuItem1,
            this.reportsToolStripMenuItem1});
            this.bankTransactionsToolStripMenuItem.Name = "bankTransactionsToolStripMenuItem";
            this.bankTransactionsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.bankTransactionsToolStripMenuItem.Text = "Bank Transactions";
            // 
            // bankManagementToolStripMenuItem
            // 
            this.bankManagementToolStripMenuItem.Name = "bankManagementToolStripMenuItem";
            this.bankManagementToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.bankManagementToolStripMenuItem.Text = "Bank Management";
            this.bankManagementToolStripMenuItem.Click += new System.EventHandler(this.bankManagementToolStripMenuItem_Click);
            // 
            // bankTransactionsToolStripMenuItem1
            // 
            this.bankTransactionsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTransactionsToolStripMenuItem,
            this.deleteTransactionsToolStripMenuItem,
            this.transactionsReportToolStripMenuItem});
            this.bankTransactionsToolStripMenuItem1.Name = "bankTransactionsToolStripMenuItem1";
            this.bankTransactionsToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.bankTransactionsToolStripMenuItem1.Text = "Bank Transactions";
            this.bankTransactionsToolStripMenuItem1.Click += new System.EventHandler(this.bankTransactionsToolStripMenuItem1_Click);
            // 
            // newTransactionsToolStripMenuItem
            // 
            this.newTransactionsToolStripMenuItem.Name = "newTransactionsToolStripMenuItem";
            this.newTransactionsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.newTransactionsToolStripMenuItem.Text = "New Transactions";
            this.newTransactionsToolStripMenuItem.Click += new System.EventHandler(this.newTransactionsToolStripMenuItem_Click);
            // 
            // deleteTransactionsToolStripMenuItem
            // 
            this.deleteTransactionsToolStripMenuItem.Name = "deleteTransactionsToolStripMenuItem";
            this.deleteTransactionsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.deleteTransactionsToolStripMenuItem.Text = "Delete Transactions";
            this.deleteTransactionsToolStripMenuItem.Click += new System.EventHandler(this.deleteTransactionsToolStripMenuItem_Click);
            // 
            // transactionsReportToolStripMenuItem
            // 
            this.transactionsReportToolStripMenuItem.Name = "transactionsReportToolStripMenuItem";
            this.transactionsReportToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.transactionsReportToolStripMenuItem.Text = "Transactions Report";
            this.transactionsReportToolStripMenuItem.Click += new System.EventHandler(this.transactionsReportToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem1
            // 
            this.reportsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registeredBanksToolStripMenuItem});
            this.reportsToolStripMenuItem1.Name = "reportsToolStripMenuItem1";
            this.reportsToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.reportsToolStripMenuItem1.Text = "Reports";
            // 
            // registeredBanksToolStripMenuItem
            // 
            this.registeredBanksToolStripMenuItem.Name = "registeredBanksToolStripMenuItem";
            this.registeredBanksToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.registeredBanksToolStripMenuItem.Text = "Registered Banks";
            this.registeredBanksToolStripMenuItem.Click += new System.EventHandler(this.registeredBanksToolStripMenuItem_Click);
            // 
            // expensesManagementToolStripMenuItem
            // 
            this.expensesManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newExpenseToolStripMenuItem,
            this.deleteExpenseToolStripMenuItem,
            this.expensesReportToolStripMenuItem,
            this.chartReportToolStripMenuItem});
            this.expensesManagementToolStripMenuItem.Name = "expensesManagementToolStripMenuItem";
            this.expensesManagementToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.expensesManagementToolStripMenuItem.Text = "Expenses Management";
            // 
            // newExpenseToolStripMenuItem
            // 
            this.newExpenseToolStripMenuItem.Name = "newExpenseToolStripMenuItem";
            this.newExpenseToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.newExpenseToolStripMenuItem.Text = "New Expense";
            this.newExpenseToolStripMenuItem.Click += new System.EventHandler(this.newExpenseToolStripMenuItem_Click);
            // 
            // deleteExpenseToolStripMenuItem
            // 
            this.deleteExpenseToolStripMenuItem.Name = "deleteExpenseToolStripMenuItem";
            this.deleteExpenseToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.deleteExpenseToolStripMenuItem.Text = "Delete Expense";
            this.deleteExpenseToolStripMenuItem.Click += new System.EventHandler(this.deleteExpenseToolStripMenuItem_Click);
            // 
            // expensesReportToolStripMenuItem
            // 
            this.expensesReportToolStripMenuItem.Name = "expensesReportToolStripMenuItem";
            this.expensesReportToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.expensesReportToolStripMenuItem.Text = "Expenses Report";
            this.expensesReportToolStripMenuItem.Click += new System.EventHandler(this.expensesReportToolStripMenuItem_Click);
            // 
            // chartReportToolStripMenuItem
            // 
            this.chartReportToolStripMenuItem.Name = "chartReportToolStripMenuItem";
            this.chartReportToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.chartReportToolStripMenuItem.Text = "Chart Report";
            this.chartReportToolStripMenuItem.Click += new System.EventHandler(this.chartReportToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.userManagementToolStripMenuItem.Text = "User Management";
            this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
            // 
            // summaryInformationToolStripMenuItem
            // 
            this.summaryInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryInformationToolStripMenuItem1,
            this.dailySummaryToolStripMenuItem});
            this.summaryInformationToolStripMenuItem.Name = "summaryInformationToolStripMenuItem";
            this.summaryInformationToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.summaryInformationToolStripMenuItem.Text = "Summary Information";
            // 
            // summaryInformationToolStripMenuItem1
            // 
            this.summaryInformationToolStripMenuItem1.Name = "summaryInformationToolStripMenuItem1";
            this.summaryInformationToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.summaryInformationToolStripMenuItem1.Text = "Summary Information";
            this.summaryInformationToolStripMenuItem1.Click += new System.EventHandler(this.summaryInformationToolStripMenuItem1_Click);
            // 
            // dailySummaryToolStripMenuItem
            // 
            this.dailySummaryToolStripMenuItem.Name = "dailySummaryToolStripMenuItem";
            this.dailySummaryToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.dailySummaryToolStripMenuItem.Text = "Daily Summary";
            this.dailySummaryToolStripMenuItem.Click += new System.EventHandler(this.dailySummaryToolStripMenuItem_Click);
            // 
            // chartInformationToolStripMenuItem
            // 
            this.chartInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profitChartToolStripMenuItem});
            this.chartInformationToolStripMenuItem.Name = "chartInformationToolStripMenuItem";
            this.chartInformationToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.chartInformationToolStripMenuItem.Text = "Chart Information";
            // 
            // profitChartToolStripMenuItem
            // 
            this.profitChartToolStripMenuItem.Name = "profitChartToolStripMenuItem";
            this.profitChartToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.profitChartToolStripMenuItem.Text = "Profit Chart";
            this.profitChartToolStripMenuItem.Click += new System.EventHandler(this.profitChartToolStripMenuItem_Click);
            // 
            // managementToolStripMenuItem1
            // 
            this.managementToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supplierManagementToolStripMenuItem});
            this.managementToolStripMenuItem1.Name = "managementToolStripMenuItem1";
            this.managementToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
            this.managementToolStripMenuItem1.Text = "Management";
            // 
            // supplierManagementToolStripMenuItem
            // 
            this.supplierManagementToolStripMenuItem.Name = "supplierManagementToolStripMenuItem";
            this.supplierManagementToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.supplierManagementToolStripMenuItem.Text = "Supplier Management";
            this.supplierManagementToolStripMenuItem.Click += new System.EventHandler(this.supplierManagementToolStripMenuItem_Click);
            // 
            // visibleChartsToolStripMenuItem
            // 
            this.visibleChartsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visibleChartsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.visibleChartsToolStripMenuItem.Name = "visibleChartsToolStripMenuItem";
            this.visibleChartsToolStripMenuItem.Size = new System.Drawing.Size(85, 19);
            this.visibleChartsToolStripMenuItem.Text = "Show Chats";
            this.visibleChartsToolStripMenuItem.Click += new System.EventHandler(this.visibleChartsToolStripMenuItem_Click);
            // 
            // cashdrawToolStripMenuItem
            // 
            this.cashdrawToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.endToolStripMenuItem});
            this.cashdrawToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashdrawToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cashdrawToolStripMenuItem.Name = "cashdrawToolStripMenuItem";
            this.cashdrawToolStripMenuItem.Size = new System.Drawing.Size(85, 19);
            this.cashdrawToolStripMenuItem.Text = "Cashdraw";
            // 
            // endToolStripMenuItem
            // 
            this.endToolStripMenuItem.Name = "endToolStripMenuItem";
            this.endToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.endToolStripMenuItem.Text = "End";
            this.endToolStripMenuItem.Click += new System.EventHandler(this.endToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(98, 682);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1256, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // txtdate
            // 
            this.txtdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdate.Enabled = false;
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdate.Location = new System.Drawing.Point(2081, 1056);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(115, 20);
            this.txtdate.TabIndex = 4;
            // 
            // pieChart1
            // 
            this.pieChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pieChart1.BackColor = System.Drawing.Color.White;
            this.pieChart1.Location = new System.Drawing.Point(1585, 0);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(623, 368);
            this.pieChart1.TabIndex = 8;
            this.pieChart1.Text = "This Year Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(545, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Top 5 Selling Products";
            // 
            // lblyear
            // 
            this.lblyear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblyear.AutoSize = true;
            this.lblyear.BackColor = System.Drawing.Color.White;
            this.lblyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyear.Location = new System.Drawing.Point(2088, 9);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(108, 16);
            this.lblyear.TabIndex = 10;
            this.lblyear.Text = "2017 Summary";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.White;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(1098, 392);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(270, 16);
            this.lbl3.TabIndex = 13;
            this.lbl3.Text = "Comparing Summary of 2016 and 2017";
            // 
            // cartesianChart2
            // 
            this.cartesianChart2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChart2.BackColor = System.Drawing.Color.White;
            this.cartesianChart2.Location = new System.Drawing.Point(89, 362);
            this.cartesianChart2.Name = "cartesianChart2";
            this.cartesianChart2.Size = new System.Drawing.Size(1272, 317);
            this.cartesianChart2.TabIndex = 17;
            this.cartesianChart2.Text = "cartesianChart2";
            // 
            // pieChart2
            // 
            this.pieChart2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pieChart2.BackColor = System.Drawing.Color.White;
            this.pieChart2.Location = new System.Drawing.Point(85, 0);
            this.pieChart2.Name = "pieChart2";
            this.pieChart2.Size = new System.Drawing.Size(650, 368);
            this.pieChart2.TabIndex = 16;
            this.pieChart2.Text = "Top 5 Selling Products";
            // 
            // pieChart3
            // 
            this.pieChart3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pieChart3.BackColor = System.Drawing.Color.White;
            this.pieChart3.Location = new System.Drawing.Point(731, 0);
            this.pieChart3.Name = "pieChart3";
            this.pieChart3.Size = new System.Drawing.Size(623, 361);
            this.pieChart3.TabIndex = 15;
            this.pieChart3.Text = "This Year Information";
            // 
            // lblreorder
            // 
            this.lblreorder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreorder.ForeColor = System.Drawing.Color.Green;
            this.lblreorder.Name = "lblreorder";
            this.lblreorder.Size = new System.Drawing.Size(85, 19);
            this.lblreorder.Text = "Re-Order";
            this.lblreorder.Click += new System.EventHandler(this.lblreorder_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 704);
            this.Controls.Add(this.cartesianChart2);
            this.Controls.Add(this.pieChart2);
            this.Controls.Add(this.pieChart3);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lblyear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pieChart1);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main_Menu";
            this.Text = "Main_Menu";
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            this.Click += new System.EventHandler(this.Main_Menu_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_Menu_MouseClick);
            this.MouseHover += new System.EventHandler(this.Main_Menu_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_Menu_MouseMove);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchasingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPurchasingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPurchasingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem purchasingReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePurchasingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateItemInfomationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBillingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesInformationReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBillingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankTransactionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expensesManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newExpenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expensesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteExpenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTransactionsToolStripMenuItem;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblyear;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.ToolStripMenuItem visibleChartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registeredBanksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryInformationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dailySummaryToolStripMenuItem;
        private CachedExpenses_Chart_Report cachedExpenses_Chart_Report1;
        private System.Windows.Forms.ToolStripMenuItem chartInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profitChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem supplierManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem inventoryReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashdrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endToolStripMenuItem;
        private LiveCharts.WinForms.CartesianChart cartesianChart2;
        private LiveCharts.WinForms.PieChart pieChart2;
        private LiveCharts.WinForms.PieChart pieChart3;
        private System.Windows.Forms.ToolStripMenuItem lblreorder;
    }
}



