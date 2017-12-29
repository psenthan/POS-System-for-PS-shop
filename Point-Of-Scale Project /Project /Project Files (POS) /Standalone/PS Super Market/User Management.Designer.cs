namespace PS_Super_Market
{
    partial class User_Management
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
            this.txtrole = new System.Windows.Forms.ComboBox();
            this.txtusername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtpassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.chkactive = new MaterialSkin.Controls.MaterialCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtrole
            // 
            this.txtrole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtrole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtrole.FormattingEnabled = true;
            this.txtrole.Items.AddRange(new object[] {
            "Administrator",
            "Sales Supervisor",
            "Stock Supervisor",
            "Sales Agent",
            "Stock Keeper"});
            this.txtrole.Location = new System.Drawing.Point(632, 365);
            this.txtrole.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtrole.Name = "txtrole";
            this.txtrole.Size = new System.Drawing.Size(497, 39);
            this.txtrole.TabIndex = 3;
            // 
            // txtusername
            // 
            this.txtusername.Depth = 0;
            this.txtusername.Hint = "";
            this.txtusername.Location = new System.Drawing.Point(632, 157);
            this.txtusername.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtusername.MaxLength = 32767;
            this.txtusername.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.SelectedText = "";
            this.txtusername.SelectionLength = 0;
            this.txtusername.SelectionStart = 0;
            this.txtusername.Size = new System.Drawing.Size(504, 50);
            this.txtusername.TabIndex = 0;
            this.txtusername.TabStop = false;
            this.txtusername.UseSystemPasswordChar = false;
            this.txtusername.Click += new System.EventHandler(this.txtusername_Click);
            this.txtusername.Leave += new System.EventHandler(this.txtusername_Leave);
            // 
            // txtpassword
            // 
            this.txtpassword.Depth = 0;
            this.txtpassword.Hint = "";
            this.txtpassword.Location = new System.Drawing.Point(632, 227);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtpassword.MaxLength = 32767;
            this.txtpassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '\0';
            this.txtpassword.SelectedText = "";
            this.txtpassword.SelectionLength = 0;
            this.txtpassword.SelectionStart = 0;
            this.txtpassword.Size = new System.Drawing.Size(504, 50);
            this.txtpassword.TabIndex = 1;
            this.txtpassword.TabStop = false;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // txtname
            // 
            this.txtname.Depth = 0;
            this.txtname.Hint = "";
            this.txtname.Location = new System.Drawing.Point(632, 296);
            this.txtname.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtname.MaxLength = 32767;
            this.txtname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.SelectedText = "";
            this.txtname.SelectionLength = 0;
            this.txtname.SelectionStart = 0;
            this.txtname.Size = new System.Drawing.Size(504, 50);
            this.txtname.TabIndex = 2;
            this.txtname.TabStop = false;
            this.txtname.UseSystemPasswordChar = false;
            this.txtname.Leave += new System.EventHandler(this.txtname_Leave);
            // 
            // chkactive
            // 
            this.chkactive.AutoSize = true;
            this.chkactive.Depth = 0;
            this.chkactive.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkactive.Location = new System.Drawing.Point(632, 422);
            this.chkactive.Margin = new System.Windows.Forms.Padding(0);
            this.chkactive.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkactive.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkactive.Name = "chkactive";
            this.chkactive.Ripple = true;
            this.chkactive.Size = new System.Drawing.Size(212, 30);
            this.chkactive.TabIndex = 4;
            this.chkactive.Text = "Active User";
            this.chkactive.UseVisualStyleBackColor = true;
            this.chkactive.CheckedChanged += new System.EventHandler(this.materialCheckBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 250);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 320);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(408, 384);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Role";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-16, -19);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1664, 148);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(592, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(401, 63);
            this.label5.TabIndex = 3;
            this.label5.Text = "User Management";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(675, 508);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(11, 14, 11, 14);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(343, 36);
            this.materialFlatButton1.TabIndex = 5;
            this.materialFlatButton1.Text = "Create Username";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // User_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1560, 789);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkactive);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtrole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "User_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.User_Management_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtrole;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtusername;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtpassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtname;
        private MaterialSkin.Controls.MaterialCheckBox chkactive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}