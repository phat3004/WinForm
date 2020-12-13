namespace DOANPQSHOP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSQL = new System.Windows.Forms.TextBox();
            this.btEsc = new System.Windows.Forms.Button();
            this.btQL = new System.Windows.Forms.Button();
            this.btKH = new System.Windows.Forms.Button();
            this.btNV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(13, 86);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(91, 17);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Trợ giúp (F1)";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 620);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "SQL Server";
            // 
            // tbSQL
            // 
            this.tbSQL.Location = new System.Drawing.Point(108, 615);
            this.tbSQL.Name = "tbSQL";
            this.tbSQL.Size = new System.Drawing.Size(153, 22);
            this.tbSQL.TabIndex = 13;
            this.tbSQL.Text = "LAPTOP-I149IRGB";
            // 
            // btEsc
            // 
            this.btEsc.BackColor = System.Drawing.Color.Transparent;
            this.btEsc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btEsc.Location = new System.Drawing.Point(16, 25);
            this.btEsc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEsc.Name = "btEsc";
            this.btEsc.Size = new System.Drawing.Size(81, 37);
            this.btEsc.TabIndex = 12;
            this.btEsc.Text = "Thoát";
            this.btEsc.UseVisualStyleBackColor = false;
            this.btEsc.Click += new System.EventHandler(this.btEsc_Click);
            // 
            // btQL
            // 
            this.btQL.Font = new System.Drawing.Font("Algerian", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQL.Location = new System.Drawing.Point(672, 11);
            this.btQL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btQL.Name = "btQL";
            this.btQL.Size = new System.Drawing.Size(176, 172);
            this.btQL.TabIndex = 11;
            this.btQL.Text = "QUẢN LÍ";
            this.btQL.UseVisualStyleBackColor = true;
            this.btQL.Click += new System.EventHandler(this.btQL_Click);
            // 
            // btKH
            // 
            this.btKH.Font = new System.Drawing.Font("Algerian", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKH.Location = new System.Drawing.Point(672, 438);
            this.btKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btKH.Name = "btKH";
            this.btKH.Size = new System.Drawing.Size(176, 199);
            this.btKH.TabIndex = 10;
            this.btKH.Text = "KHÁCH HÀNG";
            this.btKH.UseVisualStyleBackColor = true;
            this.btKH.Click += new System.EventHandler(this.btKH_Click);
            // 
            // btNV
            // 
            this.btNV.Font = new System.Drawing.Font("Algerian", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNV.Location = new System.Drawing.Point(672, 210);
            this.btNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNV.Name = "btNV";
            this.btNV.Size = new System.Drawing.Size(176, 201);
            this.btNV.TabIndex = 9;
            this.btNV.Text = "NHÂN VIÊN";
            this.btNV.UseVisualStyleBackColor = true;
            this.btNV.Click += new System.EventHandler(this.btNV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btEsc;
            this.ClientSize = new System.Drawing.Size(860, 656);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSQL);
            this.Controls.Add(this.btEsc);
            this.Controls.Add(this.btQL);
            this.Controls.Add(this.btKH);
            this.Controls.Add(this.btNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSQL;
        private System.Windows.Forms.Button btEsc;
        private System.Windows.Forms.Button btQL;
        private System.Windows.Forms.Button btKH;
        private System.Windows.Forms.Button btNV;
    }
}

