namespace PS_Super_Market
{
    partial class Supplier_Management
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtname = new System.Windows.Forms.ComboBox();
            this.txtcontactno = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.chksearch = new MaterialSkin.Controls.MaterialCheckBox();
            this.txtid = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(114, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Telephone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(130, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Name";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(257, 268);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(149, 36);
            this.materialFlatButton1.TabIndex = 4;
            this.materialFlatButton1.Text = "Register Supplier";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // txtname
            // 
            this.txtname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.FormattingEnabled = true;
            this.txtname.Location = new System.Drawing.Point(204, 121);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(246, 26);
            this.txtname.TabIndex = 0;
            this.txtname.Leave += new System.EventHandler(this.txtname_Leave);
            // 
            // txtcontactno
            // 
            this.txtcontactno.Location = new System.Drawing.Point(204, 239);
            this.txtcontactno.MaxLength = 10;
            this.txtcontactno.Name = "txtcontactno";
            this.txtcontactno.Size = new System.Drawing.Size(246, 20);
            this.txtcontactno.TabIndex = 3;
            this.txtcontactno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontactno_KeyPress);
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(204, 153);
            this.txtaddress.MaxLength = 50;
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(246, 54);
            this.txtaddress.TabIndex = 1;
            this.txtaddress.Leave += new System.EventHandler(this.txtaddress_Leave);
            // 
            // txtemail
            // 
            this.txtemail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtemail.Location = new System.Drawing.Point(204, 213);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(246, 20);
            this.txtemail.TabIndex = 2;
            // 
            // chksearch
            // 
            this.chksearch.AutoSize = true;
            this.chksearch.Depth = 0;
            this.chksearch.Font = new System.Drawing.Font("Roboto", 10F);
            this.chksearch.Location = new System.Drawing.Point(492, 82);
            this.chksearch.Margin = new System.Windows.Forms.Padding(0);
            this.chksearch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chksearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.chksearch.Name = "chksearch";
            this.chksearch.Ripple = true;
            this.chksearch.Size = new System.Drawing.Size(73, 30);
            this.chksearch.TabIndex = 5;
            this.chksearch.Text = "Search";
            this.chksearch.UseVisualStyleBackColor = true;
            this.chksearch.CheckedChanged += new System.EventHandler(this.chksearch_CheckedChanged);
            // 
            // txtid
            // 
            this.txtid.Depth = 0;
            this.txtid.Hint = "";
            this.txtid.Location = new System.Drawing.Point(492, 56);
            this.txtid.MaxLength = 32767;
            this.txtid.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtid.Name = "txtid";
            this.txtid.PasswordChar = '\0';
            this.txtid.SelectedText = "";
            this.txtid.SelectionLength = 0;
            this.txtid.SelectionStart = 0;
            this.txtid.Size = new System.Drawing.Size(75, 23);
            this.txtid.TabIndex = 6;
            this.txtid.TabStop = false;
            this.txtid.UseSystemPasswordChar = false;
            this.txtid.Click += new System.EventHandler(this.txtid_Click);
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 50);
            this.panel1.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Supplier Management";
            // 
            // Supplier_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 331);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtcontactno);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.chksearch);
            this.Controls.Add(this.txtid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Supplier_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Supplier_Management_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.ComboBox txtname;
        private System.Windows.Forms.TextBox txtcontactno;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtemail;
        private MaterialSkin.Controls.MaterialCheckBox chksearch;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}