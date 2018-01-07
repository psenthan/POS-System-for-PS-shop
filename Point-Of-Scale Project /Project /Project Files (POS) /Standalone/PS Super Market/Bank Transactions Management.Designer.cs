namespace PS_Super_Market
{
    partial class Bank_Transactions_Management
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.chksearch = new MaterialSkin.Controls.MaterialCheckBox();
            this.txtbankidentity = new System.Windows.Forms.ComboBox();
            this.txtbankname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtaccountno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtamount = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.chkdeposit = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkwithdraw = new MaterialSkin.Controls.MaterialCheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(507, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Tra. ID";
            // 
            // txtid
            // 
            this.txtid.Depth = 0;
            this.txtid.Hint = "";
            this.txtid.Location = new System.Drawing.Point(560, 12);
            this.txtid.MaxLength = 32767;
            this.txtid.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtid.Name = "txtid";
            this.txtid.PasswordChar = '\0';
            this.txtid.SelectedText = "";
            this.txtid.SelectionLength = 0;
            this.txtid.SelectionStart = 0;
            this.txtid.Size = new System.Drawing.Size(73, 23);
            this.txtid.TabIndex = 10;
            this.txtid.TabStop = false;
            this.txtid.UseSystemPasswordChar = false;
            this.txtid.Click += new System.EventHandler(this.txtid_Click);
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // chksearch
            // 
            this.chksearch.AutoSize = true;
            this.chksearch.Depth = 0;
            this.chksearch.Font = new System.Drawing.Font("Roboto", 10F);
            this.chksearch.Location = new System.Drawing.Point(549, 38);
            this.chksearch.Margin = new System.Windows.Forms.Padding(0);
            this.chksearch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chksearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.chksearch.Name = "chksearch";
            this.chksearch.Ripple = true;
            this.chksearch.Size = new System.Drawing.Size(84, 30);
            this.chksearch.TabIndex = 9;
            this.chksearch.Text = "Find Info";
            this.chksearch.UseVisualStyleBackColor = true;
            this.chksearch.CheckedChanged += new System.EventHandler(this.chksearch_CheckedChanged);
            // 
            // txtbankidentity
            // 
            this.txtbankidentity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtbankidentity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtbankidentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbankidentity.FormattingEnabled = true;
            this.txtbankidentity.Location = new System.Drawing.Point(205, 132);
            this.txtbankidentity.Name = "txtbankidentity";
            this.txtbankidentity.Size = new System.Drawing.Size(293, 28);
            this.txtbankidentity.TabIndex = 2;
            this.txtbankidentity.SelectedIndexChanged += new System.EventHandler(this.txtbankidentity_SelectedIndexChanged);
            this.txtbankidentity.TextChanged += new System.EventHandler(this.txtbankidentity_TextChanged);
            this.txtbankidentity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbankidentity_KeyPress);
            // 
            // txtbankname
            // 
            this.txtbankname.Depth = 0;
            this.txtbankname.Hint = "";
            this.txtbankname.Location = new System.Drawing.Point(205, 163);
            this.txtbankname.MaxLength = 32767;
            this.txtbankname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtbankname.Name = "txtbankname";
            this.txtbankname.PasswordChar = '\0';
            this.txtbankname.SelectedText = "";
            this.txtbankname.SelectionLength = 0;
            this.txtbankname.SelectionStart = 0;
            this.txtbankname.Size = new System.Drawing.Size(167, 23);
            this.txtbankname.TabIndex = 7;
            this.txtbankname.TabStop = false;
            this.txtbankname.UseSystemPasswordChar = false;
            this.txtbankname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbankname_KeyPress);
            // 
            // txtaccountno
            // 
            this.txtaccountno.Depth = 0;
            this.txtaccountno.Hint = "";
            this.txtaccountno.Location = new System.Drawing.Point(378, 163);
            this.txtaccountno.MaxLength = 32767;
            this.txtaccountno.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtaccountno.Name = "txtaccountno";
            this.txtaccountno.PasswordChar = '\0';
            this.txtaccountno.SelectedText = "";
            this.txtaccountno.SelectionLength = 0;
            this.txtaccountno.SelectionStart = 0;
            this.txtaccountno.Size = new System.Drawing.Size(120, 23);
            this.txtaccountno.TabIndex = 8;
            this.txtaccountno.TabStop = false;
            this.txtaccountno.UseSystemPasswordChar = false;
            this.txtaccountno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtaccountno_KeyPress);
            // 
            // txtamount
            // 
            this.txtamount.Depth = 0;
            this.txtamount.Hint = "";
            this.txtamount.Location = new System.Drawing.Point(205, 192);
            this.txtamount.MaxLength = 32767;
            this.txtamount.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtamount.Name = "txtamount";
            this.txtamount.PasswordChar = '\0';
            this.txtamount.SelectedText = "";
            this.txtamount.SelectionLength = 0;
            this.txtamount.SelectionStart = 0;
            this.txtamount.Size = new System.Drawing.Size(167, 23);
            this.txtamount.TabIndex = 3;
            this.txtamount.TabStop = false;
            this.txtamount.UseSystemPasswordChar = false;
            this.txtamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtamount_KeyPress);
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(205, 221);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(293, 60);
            this.txtdescription.TabIndex = 4;
            this.txtdescription.Leave += new System.EventHandler(this.txtdescription_Leave);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(205, 290);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(91, 36);
            this.materialFlatButton1.TabIndex = 5;
            this.materialFlatButton1.Text = "Complete";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(403, 290);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(75, 36);
            this.materialFlatButton2.TabIndex = 6;
            this.materialFlatButton2.Text = "Remove";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Identity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Bank Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(150, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(128, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Description";
            // 
            // txtdate
            // 
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdate.Location = new System.Drawing.Point(10, 322);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(96, 20);
            this.txtdate.TabIndex = 59;
            // 
            // chkdeposit
            // 
            this.chkdeposit.AutoSize = true;
            this.chkdeposit.Depth = 0;
            this.chkdeposit.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkdeposit.Location = new System.Drawing.Point(205, 96);
            this.chkdeposit.Margin = new System.Windows.Forms.Padding(0);
            this.chkdeposit.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkdeposit.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkdeposit.Name = "chkdeposit";
            this.chkdeposit.Ripple = true;
            this.chkdeposit.Size = new System.Drawing.Size(125, 30);
            this.chkdeposit.TabIndex = 0;
            this.chkdeposit.Text = "Make a Deposit";
            this.chkdeposit.UseVisualStyleBackColor = true;
            this.chkdeposit.CheckedChanged += new System.EventHandler(this.chkdeposit_CheckedChanged);
            // 
            // chkwithdraw
            // 
            this.chkwithdraw.AutoSize = true;
            this.chkwithdraw.Depth = 0;
            this.chkwithdraw.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkwithdraw.Location = new System.Drawing.Point(351, 96);
            this.chkwithdraw.Margin = new System.Windows.Forms.Padding(0);
            this.chkwithdraw.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkwithdraw.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkwithdraw.Name = "chkwithdraw";
            this.chkwithdraw.Ripple = true;
            this.chkwithdraw.Size = new System.Drawing.Size(147, 30);
            this.chkwithdraw.TabIndex = 1;
            this.chkwithdraw.Text = "Make a Withdrawal";
            this.chkwithdraw.UseVisualStyleBackColor = true;
            this.chkwithdraw.CheckedChanged += new System.EventHandler(this.chkwithdraw_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-32, -22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 69);
            this.panel1.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bank Transactions Management";
            // 
            // Bank_Transactions_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(642, 354);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkwithdraw);
            this.Controls.Add(this.chkdeposit);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.txtaccountno);
            this.Controls.Add(this.txtbankname);
            this.Controls.Add(this.txtbankidentity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.chksearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Bank_Transactions_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Bank_Transactions_Management_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtid;
        private MaterialSkin.Controls.MaterialCheckBox chksearch;
        private System.Windows.Forms.ComboBox txtbankidentity;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtbankname;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtaccountno;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtamount;
        private System.Windows.Forms.TextBox txtdescription;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txtdate;
        private MaterialSkin.Controls.MaterialCheckBox chkdeposit;
        private MaterialSkin.Controls.MaterialCheckBox chkwithdraw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}