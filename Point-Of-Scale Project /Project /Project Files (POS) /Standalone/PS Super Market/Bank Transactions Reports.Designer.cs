namespace PS_Super_Market
{
    partial class Bank_Transactions_Reports
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
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtto = new System.Windows.Forms.DateTimePicker();
            this.txtfrom = new System.Windows.Forms.DateTimePicker();
            this.chkwithdraw = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkdeposit = new MaterialSkin.Controls.MaterialCheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbankidentity = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(109, 206);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(144, 36);
            this.materialFlatButton1.TabIndex = 76;
            this.materialFlatButton1.Text = "Generate Report";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "End";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Start";
            // 
            // txtto
            // 
            this.txtto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtto.Location = new System.Drawing.Point(226, 177);
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(135, 20);
            this.txtto.TabIndex = 73;
            // 
            // txtfrom
            // 
            this.txtfrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfrom.Location = new System.Drawing.Point(21, 177);
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.Size = new System.Drawing.Size(135, 20);
            this.txtfrom.TabIndex = 72;
            // 
            // chkwithdraw
            // 
            this.chkwithdraw.AutoSize = true;
            this.chkwithdraw.Depth = 0;
            this.chkwithdraw.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkwithdraw.Location = new System.Drawing.Point(221, 79);
            this.chkwithdraw.Margin = new System.Windows.Forms.Padding(0);
            this.chkwithdraw.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkwithdraw.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkwithdraw.Name = "chkwithdraw";
            this.chkwithdraw.Ripple = true;
            this.chkwithdraw.Size = new System.Drawing.Size(140, 30);
            this.chkwithdraw.TabIndex = 69;
            this.chkwithdraw.Text = "Bank Withdrawals";
            this.chkwithdraw.UseVisualStyleBackColor = true;
            this.chkwithdraw.CheckedChanged += new System.EventHandler(this.chkwithdraw_CheckedChanged);
            // 
            // chkdeposit
            // 
            this.chkdeposit.AutoSize = true;
            this.chkdeposit.Depth = 0;
            this.chkdeposit.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkdeposit.Location = new System.Drawing.Point(21, 79);
            this.chkdeposit.Margin = new System.Windows.Forms.Padding(0);
            this.chkdeposit.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkdeposit.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkdeposit.Name = "chkdeposit";
            this.chkdeposit.Ripple = true;
            this.chkdeposit.Size = new System.Drawing.Size(118, 30);
            this.chkdeposit.TabIndex = 68;
            this.chkdeposit.Text = "Bank Deposits";
            this.chkdeposit.UseVisualStyleBackColor = true;
            this.chkdeposit.CheckedChanged += new System.EventHandler(this.chkdeposit_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Bank";
            // 
            // txtbankidentity
            // 
            this.txtbankidentity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtbankidentity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtbankidentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbankidentity.FormattingEnabled = true;
            this.txtbankidentity.Location = new System.Drawing.Point(21, 130);
            this.txtbankidentity.Name = "txtbankidentity";
            this.txtbankidentity.Size = new System.Drawing.Size(340, 28);
            this.txtbankidentity.TabIndex = 70;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 37);
            this.panel1.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bank Transactions Reports";
            // 
            // Bank_Transactions_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(401, 264);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtto);
            this.Controls.Add(this.txtfrom);
            this.Controls.Add(this.chkwithdraw);
            this.Controls.Add(this.chkdeposit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbankidentity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Bank_Transactions_Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Bank_Transactions_Reports_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtto;
        private System.Windows.Forms.DateTimePicker txtfrom;
        private MaterialSkin.Controls.MaterialCheckBox chkwithdraw;
        private MaterialSkin.Controls.MaterialCheckBox chkdeposit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtbankidentity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}