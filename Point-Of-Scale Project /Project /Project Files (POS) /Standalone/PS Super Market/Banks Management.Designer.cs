namespace PS_Super_Market
{
    partial class Banks_Management
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
            this.chksearch = new MaterialSkin.Controls.MaterialCheckBox();
            this.txtid = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbank = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtaccountno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtaccountname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chksearch
            // 
            this.chksearch.AutoSize = true;
            this.chksearch.Depth = 0;
            this.chksearch.Font = new System.Drawing.Font("Roboto", 10F);
            this.chksearch.Location = new System.Drawing.Point(343, 104);
            this.chksearch.Margin = new System.Windows.Forms.Padding(0);
            this.chksearch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chksearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.chksearch.Name = "chksearch";
            this.chksearch.Ripple = true;
            this.chksearch.Size = new System.Drawing.Size(73, 30);
            this.chksearch.TabIndex = 45;
            this.chksearch.Text = "Search";
            this.chksearch.UseVisualStyleBackColor = true;
            this.chksearch.CheckedChanged += new System.EventHandler(this.chksearch_CheckedChanged);
            // 
            // txtid
            // 
            this.txtid.Depth = 0;
            this.txtid.Hint = "";
            this.txtid.Location = new System.Drawing.Point(200, 111);
            this.txtid.MaxLength = 32767;
            this.txtid.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtid.Name = "txtid";
            this.txtid.PasswordChar = '\0';
            this.txtid.SelectedText = "";
            this.txtid.SelectionLength = 0;
            this.txtid.SelectionStart = 0;
            this.txtid.Size = new System.Drawing.Size(104, 23);
            this.txtid.TabIndex = 46;
            this.txtid.TabStop = false;
            this.txtid.UseSystemPasswordChar = false;
            this.txtid.Click += new System.EventHandler(this.txtid_Click);
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "ID";
            // 
            // txtbank
            // 
            this.txtbank.Depth = 0;
            this.txtbank.Hint = "";
            this.txtbank.Location = new System.Drawing.Point(200, 160);
            this.txtbank.MaxLength = 32767;
            this.txtbank.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtbank.Name = "txtbank";
            this.txtbank.PasswordChar = '\0';
            this.txtbank.SelectedText = "";
            this.txtbank.SelectionLength = 0;
            this.txtbank.SelectionStart = 0;
            this.txtbank.Size = new System.Drawing.Size(216, 23);
            this.txtbank.TabIndex = 1;
            this.txtbank.TabStop = false;
            this.txtbank.UseSystemPasswordChar = false;
            this.txtbank.Leave += new System.EventHandler(this.txtbank_Leave);
            // 
            // txtaccountno
            // 
            this.txtaccountno.Depth = 0;
            this.txtaccountno.Hint = "";
            this.txtaccountno.Location = new System.Drawing.Point(200, 189);
            this.txtaccountno.MaxLength = 32767;
            this.txtaccountno.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtaccountno.Name = "txtaccountno";
            this.txtaccountno.PasswordChar = '\0';
            this.txtaccountno.SelectedText = "";
            this.txtaccountno.SelectionLength = 0;
            this.txtaccountno.SelectionStart = 0;
            this.txtaccountno.Size = new System.Drawing.Size(216, 23);
            this.txtaccountno.TabIndex = 2;
            this.txtaccountno.TabStop = false;
            this.txtaccountno.UseSystemPasswordChar = false;
            this.txtaccountno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtaccountno_KeyPress);
            this.txtaccountno.Leave += new System.EventHandler(this.txtaccountno_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Identity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(139, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Account No";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(212, 221);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(190, 36);
            this.materialFlatButton1.TabIndex = 3;
            this.materialFlatButton1.Text = "Register Bank Account";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // txtaccountname
            // 
            this.txtaccountname.Depth = 0;
            this.txtaccountname.Hint = "";
            this.txtaccountname.Location = new System.Drawing.Point(200, 131);
            this.txtaccountname.MaxLength = 32767;
            this.txtaccountname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtaccountname.Name = "txtaccountname";
            this.txtaccountname.PasswordChar = '\0';
            this.txtaccountname.SelectedText = "";
            this.txtaccountname.SelectionLength = 0;
            this.txtaccountname.SelectionStart = 0;
            this.txtaccountname.Size = new System.Drawing.Size(216, 23);
            this.txtaccountname.TabIndex = 0;
            this.txtaccountname.TabStop = false;
            this.txtaccountname.UseSystemPasswordChar = false;
            this.txtaccountname.Leave += new System.EventHandler(this.txtaccountname_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-13, -23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 69);
            this.panel1.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(160, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bank Account Management";
            // 
            // Banks_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 310);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtaccountname);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtaccountno);
            this.Controls.Add(this.txtbank);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.chksearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Banks_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Banks_Management_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialCheckBox chksearch;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtid;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtbank;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtaccountno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtaccountname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}