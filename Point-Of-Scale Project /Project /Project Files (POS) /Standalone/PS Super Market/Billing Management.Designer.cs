namespace PS_Super_Market
{
    partial class Billing_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing_Management));
            this.txtcustomername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtemail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtcontact = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chksendemail = new System.Windows.Forms.CheckBox();
            this.txtinvoiceno = new System.Windows.Forms.TextBox();
            this.chksearch = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtitemcode = new System.Windows.Forms.ComboBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.txtcostprice = new System.Windows.Forms.TextBox();
            this.txtsellprice = new System.Windows.Forms.TextBox();
            this.chkshowcost = new System.Windows.Forms.CheckBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtinvoicetotal = new System.Windows.Forms.TextBox();
            this.txttransport = new System.Windows.Forms.TextBox();
            this.txttotalofinvoice = new System.Windows.Forms.TextBox();
            this.txtpayments = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.chkreturn = new System.Windows.Forms.CheckBox();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcustomername
            // 
            this.txtcustomername.Depth = 0;
            this.txtcustomername.ForeColor = System.Drawing.Color.Navy;
            this.txtcustomername.Hint = "";
            this.txtcustomername.Location = new System.Drawing.Point(110, 3);
            this.txtcustomername.MaxLength = 32767;
            this.txtcustomername.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcustomername.Name = "txtcustomername";
            this.txtcustomername.PasswordChar = '\0';
            this.txtcustomername.SelectedText = "";
            this.txtcustomername.SelectionLength = 0;
            this.txtcustomername.SelectionStart = 0;
            this.txtcustomername.Size = new System.Drawing.Size(237, 23);
            this.txtcustomername.TabIndex = 0;
            this.txtcustomername.TabStop = false;
            this.txtcustomername.UseSystemPasswordChar = false;
            this.txtcustomername.Leave += new System.EventHandler(this.txtcustomername_Leave);
            this.txtcustomername.TextChanged += new System.EventHandler(this.txtcustomername_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.Depth = 0;
            this.txtemail.Hint = "";
            this.txtemail.Location = new System.Drawing.Point(110, 32);
            this.txtemail.MaxLength = 32767;
            this.txtemail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.SelectedText = "";
            this.txtemail.SelectionLength = 0;
            this.txtemail.SelectionStart = 0;
            this.txtemail.Size = new System.Drawing.Size(237, 23);
            this.txtemail.TabIndex = 1;
            this.txtemail.TabStop = false;
            this.txtemail.UseSystemPasswordChar = false;
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // txtcontact
            // 
            this.txtcontact.Depth = 0;
            this.txtcontact.Hint = "";
            this.txtcontact.Location = new System.Drawing.Point(110, 61);
            this.txtcontact.MaxLength = 10;
            this.txtcontact.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.PasswordChar = '\0';
            this.txtcontact.SelectedText = "";
            this.txtcontact.SelectionLength = 0;
            this.txtcontact.SelectionStart = 0;
            this.txtcontact.Size = new System.Drawing.Size(237, 23);
            this.txtcontact.TabIndex = 3;
            this.txtcontact.TabStop = false;
            this.txtcontact.UseSystemPasswordChar = false;
            this.txtcontact.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcontact_KeyDown);
            this.txtcontact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontact_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(7, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Customer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 75;
            this.label1.Text = "Email Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(7, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Contact No";
            // 
            // chksendemail
            // 
            this.chksendemail.AutoSize = true;
            this.chksendemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chksendemail.ForeColor = System.Drawing.Color.Navy;
            this.chksendemail.Location = new System.Drawing.Point(353, 38);
            this.chksendemail.Name = "chksendemail";
            this.chksendemail.Size = new System.Drawing.Size(102, 17);
            this.chksendemail.TabIndex = 2;
            this.chksendemail.Text = "Email Invoice";
            this.chksendemail.UseVisualStyleBackColor = true;
            this.chksendemail.CheckedChanged += new System.EventHandler(this.chksendemail_CheckedChanged);
            // 
            // txtinvoiceno
            // 
            this.txtinvoiceno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinvoiceno.Location = new System.Drawing.Point(704, 17);
            this.txtinvoiceno.Name = "txtinvoiceno";
            this.txtinvoiceno.Size = new System.Drawing.Size(112, 22);
            this.txtinvoiceno.TabIndex = 22;
            this.txtinvoiceno.TextChanged += new System.EventHandler(this.txtinvoiceno_TextChanged);
            this.txtinvoiceno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinvoiceno_KeyPress);
            // 
            // chksearch
            // 
            this.chksearch.AutoSize = true;
            this.chksearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chksearch.ForeColor = System.Drawing.Color.Navy;
            this.chksearch.Location = new System.Drawing.Point(704, 42);
            this.chksearch.Name = "chksearch";
            this.chksearch.Size = new System.Drawing.Size(112, 17);
            this.chksearch.TabIndex = 21;
            this.chksearch.Text = "Search Invoice";
            this.chksearch.UseVisualStyleBackColor = true;
            this.chksearch.CheckedChanged += new System.EventHandler(this.chksearch_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(629, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "Invoice No";
            // 
            // txtitemcode
            // 
            this.txtitemcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtitemcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtitemcode.FormattingEnabled = true;
            this.txtitemcode.Location = new System.Drawing.Point(10, 116);
            this.txtitemcode.Name = "txtitemcode";
            this.txtitemcode.Size = new System.Drawing.Size(145, 21);
            this.txtitemcode.TabIndex = 4;
            this.txtitemcode.SelectedIndexChanged += new System.EventHandler(this.txtitemcode_SelectedIndexChanged);
            this.txtitemcode.TextChanged += new System.EventHandler(this.txtitemcode_TextChanged);
            this.txtitemcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtitemcode_KeyDown);
            this.txtitemcode.Leave += new System.EventHandler(this.txtitemcode_Leave);
            // 
            // txtdescription
            // 
            this.txtdescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescription.Location = new System.Drawing.Point(161, 116);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(225, 22);
            this.txtdescription.TabIndex = 5;
            this.txtdescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdescription_KeyPress);
            // 
            // txtcostprice
            // 
            this.txtcostprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcostprice.Location = new System.Drawing.Point(392, 116);
            this.txtcostprice.Name = "txtcostprice";
            this.txtcostprice.Size = new System.Drawing.Size(77, 22);
            this.txtcostprice.TabIndex = 6;
            this.txtcostprice.UseSystemPasswordChar = true;
            this.txtcostprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcostprice_KeyPress);
            // 
            // txtsellprice
            // 
            this.txtsellprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsellprice.Location = new System.Drawing.Point(475, 116);
            this.txtsellprice.Name = "txtsellprice";
            this.txtsellprice.Size = new System.Drawing.Size(58, 22);
            this.txtsellprice.TabIndex = 7;
            this.txtsellprice.Text = "0";
            this.txtsellprice.TextChanged += new System.EventHandler(this.txtsellprice_TextChanged);
            this.txtsellprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsellprice_KeyPress);
            // 
            // chkshowcost
            // 
            this.chkshowcost.AutoSize = true;
            this.chkshowcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkshowcost.ForeColor = System.Drawing.Color.Navy;
            this.chkshowcost.Location = new System.Drawing.Point(392, 99);
            this.chkshowcost.Name = "chkshowcost";
            this.chkshowcost.Size = new System.Drawing.Size(53, 17);
            this.chkshowcost.TabIndex = 83;
            this.chkshowcost.Text = "View";
            this.chkshowcost.UseVisualStyleBackColor = true;
            this.chkshowcost.CheckedChanged += new System.EventHandler(this.chkshowcost_CheckedChanged);
            // 
            // txtdiscount
            // 
            this.txtdiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscount.Location = new System.Drawing.Point(603, 116);
            this.txtdiscount.MaxLength = 3;
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(39, 22);
            this.txtdiscount.TabIndex = 9;
            this.txtdiscount.Text = "0";
            this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_TextChanged);
            this.txtdiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdiscount_KeyPress);
            this.txtdiscount.Leave += new System.EventHandler(this.txtdiscount_Leave);
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubtotal.Location = new System.Drawing.Point(648, 116);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(93, 22);
            this.txtsubtotal.TabIndex = 10;
            this.txtsubtotal.Text = "0";
            this.txtsubtotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsubtotal_KeyPress);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(748, 116);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(52, 23);
            this.btnadd.TabIndex = 11;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtinvoicetotal
            // 
            this.txtinvoicetotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinvoicetotal.Location = new System.Drawing.Point(707, 145);
            this.txtinvoicetotal.Name = "txtinvoicetotal";
            this.txtinvoicetotal.Size = new System.Drawing.Size(93, 22);
            this.txtinvoicetotal.TabIndex = 12;
            this.txtinvoicetotal.Text = "0";
            this.txtinvoicetotal.TextChanged += new System.EventHandler(this.txtinvoicetotal_TextChanged);
            this.txtinvoicetotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinvoicetotal_KeyPress);
            // 
            // txttransport
            // 
            this.txttransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttransport.Location = new System.Drawing.Point(707, 173);
            this.txttransport.Name = "txttransport";
            this.txttransport.Size = new System.Drawing.Size(93, 22);
            this.txttransport.TabIndex = 13;
            this.txttransport.Text = "0";
            this.txttransport.TextChanged += new System.EventHandler(this.txttransport_TextChanged);
            this.txttransport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttransport_KeyPress);
            this.txttransport.Leave += new System.EventHandler(this.txttransport_Leave);
            // 
            // txttotalofinvoice
            // 
            this.txttotalofinvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalofinvoice.Location = new System.Drawing.Point(707, 201);
            this.txttotalofinvoice.Name = "txttotalofinvoice";
            this.txttotalofinvoice.Size = new System.Drawing.Size(93, 22);
            this.txttotalofinvoice.TabIndex = 14;
            this.txttotalofinvoice.Text = "0";
            this.txttotalofinvoice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttotalofinvoice_KeyPress);
            // 
            // txtpayments
            // 
            this.txtpayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpayments.Location = new System.Drawing.Point(707, 229);
            this.txtpayments.Name = "txtpayments";
            this.txtpayments.Size = new System.Drawing.Size(93, 22);
            this.txtpayments.TabIndex = 15;
            this.txtpayments.TextChanged += new System.EventHandler(this.txtpayments_TextChanged);
            this.txtpayments.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpayments_KeyPress);
            this.txtpayments.Leave += new System.EventHandler(this.txtpayments_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(593, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Invoice Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(593, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 75;
            this.label6.Text = "Transport Charge";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(593, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 75;
            this.label7.Text = "Total to Pay";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(593, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 75;
            this.label8.Text = "Payments";
            // 
            // txtbalance
            // 
            this.txtbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbalance.Location = new System.Drawing.Point(707, 257);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(93, 22);
            this.txtbalance.TabIndex = 16;
            this.txtbalance.Text = "0";
            this.txtbalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbalance_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(593, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 75;
            this.label9.Text = "Balance";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(10, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(577, 260);
            this.dataGridView1.TabIndex = 88;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item Code";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Description";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Sell Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Quantity";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Discount";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Sub Total";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Type";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(7, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 75;
            this.label10.Text = "Item Code";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(161, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 75;
            this.label11.Text = "Description";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(472, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 75;
            this.label12.Text = "Sell Price";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label13.Location = new System.Drawing.Point(616, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 13);
            this.label13.TabIndex = 75;
            this.label13.Text = "%";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label14.Location = new System.Drawing.Point(645, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 75;
            this.label14.Text = "Sub Total";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(596, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 35);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(707, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 35);
            this.button2.TabIndex = 20;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(596, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 35);
            this.button3.TabIndex = 18;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(707, 285);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 35);
            this.button4.TabIndex = 17;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(539, 116);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(58, 22);
            this.txtquantity.TabIndex = 8;
            this.txtquantity.Text = "1";
            this.txtquantity.TextChanged += new System.EventHandler(this.txtquantity_TextChanged);
            this.txtquantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquantity_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label15.Location = new System.Drawing.Point(536, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 75;
            this.label15.Text = "Quantity";
            // 
            // chkreturn
            // 
            this.chkreturn.AutoSize = true;
            this.chkreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkreturn.ForeColor = System.Drawing.Color.Navy;
            this.chkreturn.Location = new System.Drawing.Point(91, 99);
            this.chkreturn.Name = "chkreturn";
            this.chkreturn.Size = new System.Drawing.Size(64, 17);
            this.chkreturn.TabIndex = 89;
            this.chkreturn.Text = "Return";
            this.chkreturn.UseVisualStyleBackColor = true;
            this.chkreturn.CheckedChanged += new System.EventHandler(this.chkreturn_CheckedChanged);
            // 
            // txtdate
            // 
            this.txtdate.Enabled = false;
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdate.Location = new System.Drawing.Point(707, 383);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(92, 20);
            this.txtdate.TabIndex = 90;
            // 
            // Billing_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(828, 415);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.chkreturn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbalance);
            this.Controls.Add(this.txtpayments);
            this.Controls.Add(this.txttotalofinvoice);
            this.Controls.Add(this.txttransport);
            this.Controls.Add(this.txtinvoicetotal);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.chkshowcost);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.txtsellprice);
            this.Controls.Add(this.txtcostprice);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.txtitemcode);
            this.Controls.Add(this.chksearch);
            this.Controls.Add(this.txtinvoiceno);
            this.Controls.Add(this.chksendemail);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtcustomername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Billing_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Billing_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField txtcustomername;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtemail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtcontact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chksendemail;
        private System.Windows.Forms.TextBox txtinvoiceno;
        private System.Windows.Forms.CheckBox chksearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtitemcode;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.TextBox txtcostprice;
        private System.Windows.Forms.TextBox txtsellprice;
        private System.Windows.Forms.CheckBox chkshowcost;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtinvoicetotal;
        private System.Windows.Forms.TextBox txttransport;
        private System.Windows.Forms.TextBox txttotalofinvoice;
        private System.Windows.Forms.TextBox txtpayments;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbalance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.CheckBox chkreturn;
        private System.Windows.Forms.DateTimePicker txtdate;
    }
}