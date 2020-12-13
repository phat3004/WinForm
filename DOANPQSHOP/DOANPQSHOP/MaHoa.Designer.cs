namespace DOANPQSHOP
{
    partial class MaHoa
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
            this.lLHelp = new System.Windows.Forms.LinkLabel();
            this.btOK = new System.Windows.Forms.Button();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lLHelp
            // 
            this.lLHelp.AutoSize = true;
            this.lLHelp.LinkColor = System.Drawing.Color.Red;
            this.lLHelp.Location = new System.Drawing.Point(296, 52);
            this.lLHelp.Name = "lLHelp";
            this.lLHelp.Size = new System.Drawing.Size(61, 17);
            this.lLHelp.TabIndex = 7;
            this.lLHelp.TabStop = true;
            this.lLHelp.Text = "Trợ giúp";
            this.lLHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLHelp_LinkClicked_1);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(171, 42);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(86, 36);
            this.btOK.TabIndex = 6;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click_1);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(129, 14);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '●';
            this.tbPass.Size = new System.Drawing.Size(322, 22);
            this.tbPass.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mật Khẩu Admin";
            // 
            // MaHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 85);
            this.Controls.Add(this.lLHelp);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.label1);
            this.Name = "MaHoa";
            this.Text = "MaHoa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lLHelp;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label1;
    }
}