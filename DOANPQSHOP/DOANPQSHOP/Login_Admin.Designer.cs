namespace DOANPQSHOP
{
    partial class Login_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Admin));
            this.LlbEsc = new System.Windows.Forms.LinkLabel();
            this.lLQuen = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMk = new System.Windows.Forms.TextBox();
            this.tbTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LlbEsc
            // 
            this.LlbEsc.AutoSize = true;
            this.LlbEsc.BackColor = System.Drawing.Color.Transparent;
            this.LlbEsc.LinkColor = System.Drawing.Color.Red;
            this.LlbEsc.Location = new System.Drawing.Point(291, 146);
            this.LlbEsc.Name = "LlbEsc";
            this.LlbEsc.Size = new System.Drawing.Size(45, 17);
            this.LlbEsc.TabIndex = 26;
            this.LlbEsc.TabStop = true;
            this.LlbEsc.Text = "Thoát";
            this.LlbEsc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlbEsc_LinkClicked_1);
            // 
            // lLQuen
            // 
            this.lLQuen.AutoSize = true;
            this.lLQuen.BackColor = System.Drawing.Color.Transparent;
            this.lLQuen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLQuen.Location = new System.Drawing.Point(290, 116);
            this.lLQuen.Name = "lLQuen";
            this.lLQuen.Size = new System.Drawing.Size(54, 20);
            this.lLQuen.TabIndex = 25;
            this.lLQuen.TabStop = true;
            this.lLQuen.Text = "Quên ";
            this.lLQuen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLQuen_LinkClicked_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 24;
            // 
            // tbMk
            // 
            this.tbMk.Location = new System.Drawing.Point(129, 79);
            this.tbMk.Name = "tbMk";
            this.tbMk.PasswordChar = '●';
            this.tbMk.Size = new System.Drawing.Size(222, 22);
            this.tbMk.TabIndex = 23;
            this.tbMk.Text = "Admin115161";
            // 
            // tbTK
            // 
            this.tbTK.Location = new System.Drawing.Point(129, 28);
            this.tbTK.Name = "tbTK";
            this.tbTK.Size = new System.Drawing.Size(222, 22);
            this.tbTK.TabIndex = 22;
            this.tbTK.Text = "admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tài khoản";
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(114, 128);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(110, 35);
            this.btOk.TabIndex = 19;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click_1);
            // 
            // Login_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(380, 196);
            this.Controls.Add(this.LlbEsc);
            this.Controls.Add(this.lLQuen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMk);
            this.Controls.Add(this.tbTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Login_Admin";
            this.Text = "Login_Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LlbEsc;
        private System.Windows.Forms.LinkLabel lLQuen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMk;
        private System.Windows.Forms.TextBox tbTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btOk;
    }
}