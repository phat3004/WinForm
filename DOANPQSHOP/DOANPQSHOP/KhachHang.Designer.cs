namespace DOANPQSHOP
{
    partial class KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pt1 = new System.Windows.Forms.PictureBox();
            this.btTim = new System.Windows.Forms.Button();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSP_KH = new System.Windows.Forms.DataGridView();
            this.Ten_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btRe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pt1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP_KH)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pt1
            // 
            this.pt1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pt1.BackgroundImage")));
            this.pt1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pt1.Location = new System.Drawing.Point(248, 21);
            this.pt1.Name = "pt1";
            this.pt1.Size = new System.Drawing.Size(684, 668);
            this.pt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt1.TabIndex = 0;
            this.pt1.TabStop = false;
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(479, 20);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(100, 52);
            this.btTim.TabIndex = 9;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // tbTen
            // 
            this.tbTen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbTen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbTen.Location = new System.Drawing.Point(164, 35);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(292, 22);
            this.tbTen.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên Sản Phẩm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSP_KH);
            this.groupBox1.Controls.Add(this.lb1);
            this.groupBox1.Controls.Add(this.pt1);
            this.groupBox1.Location = new System.Drawing.Point(4, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 706);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sản Phẩm";
            // 
            // dgvSP_KH
            // 
            this.dgvSP_KH.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSP_KH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSP_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSP_KH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten_SP,
            this.Gia});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSP_KH.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSP_KH.Location = new System.Drawing.Point(8, 21);
            this.dgvSP_KH.Name = "dgvSP_KH";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSP_KH.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSP_KH.RowTemplate.Height = 24;
            this.dgvSP_KH.Size = new System.Drawing.Size(241, 668);
            this.dgvSP_KH.TabIndex = 7;
            this.dgvSP_KH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSP_KH_CellClick);
            // 
            // Ten_SP
            // 
            this.Ten_SP.DataPropertyName = "TenHang";
            this.Ten_SP.HeaderText = "Tên Sản Phẩm";
            this.Ten_SP.Name = "Ten_SP";
            this.Ten_SP.Width = 150;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá ";
            this.Gia.Name = "Gia";
            this.Gia.Width = 50;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BackColor = System.Drawing.Color.Transparent;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(271, 645);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(0, 25);
            this.lb1.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tbTen);
            this.groupBox3.Controls.Add(this.btTim);
            this.groupBox3.Location = new System.Drawing.Point(12, 711);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(594, 79);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm Kiếm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btThoat);
            this.groupBox2.Controls.Add(this.btRe);
            this.groupBox2.Location = new System.Drawing.Point(612, 711);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 79);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(185, 17);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(139, 47);
            this.btThoat.TabIndex = 1;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btRe
            // 
            this.btRe.Location = new System.Drawing.Point(16, 18);
            this.btRe.Name = "btRe";
            this.btRe.Size = new System.Drawing.Size(139, 47);
            this.btRe.TabIndex = 0;
            this.btRe.Text = "Restart";
            this.btRe.UseVisualStyleBackColor = true;
            this.btRe.Click += new System.EventHandler(this.btRe_Click);
            // 
            // KhachHang
            // 
            this.AcceptButton = this.btTim;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(948, 796);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KhachHang_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pt1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP_KH)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pt1;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.DataGridView dgvSP_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btRe;
    }
}