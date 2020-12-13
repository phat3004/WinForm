namespace DOANPQSHOP
{
    partial class Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            this.btXoaHD = new System.Windows.Forms.Button();
            this.btSuaHD = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.tbTong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.càiĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gọiQuảnLíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gặpLỗiKhiSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khôngTìmĐượcSPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khôngThựcHiệnĐượcChứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemMãKhuyếnMãiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khácToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổimậtkhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKíVIPChoKháchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refeshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btInHD = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.btThemHD = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.cbTenHang = new System.Windows.Forms.ComboBox();
            this.tbLoaiHang = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tbMaHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btXoaHD
            // 
            this.btXoaHD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btXoaHD.Image = ((System.Drawing.Image)(resources.GetObject("btXoaHD.Image")));
            this.btXoaHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoaHD.Location = new System.Drawing.Point(6, 105);
            this.btXoaHD.Name = "btXoaHD";
            this.btXoaHD.Size = new System.Drawing.Size(198, 75);
            this.btXoaHD.TabIndex = 26;
            this.btXoaHD.Text = "Xoá Hoá Đơn";
            this.btXoaHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoaHD.UseVisualStyleBackColor = false;
            this.btXoaHD.Click += new System.EventHandler(this.btXoaHD_Click_1);
            // 
            // btSuaHD
            // 
            this.btSuaHD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSuaHD.Image = ((System.Drawing.Image)(resources.GetObject("btSuaHD.Image")));
            this.btSuaHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSuaHD.Location = new System.Drawing.Point(210, 105);
            this.btSuaHD.Name = "btSuaHD";
            this.btSuaHD.Size = new System.Drawing.Size(213, 75);
            this.btSuaHD.TabIndex = 23;
            this.btSuaHD.Text = "Sửa Hoá Đơn";
            this.btSuaHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSuaHD.UseVisualStyleBackColor = false;
            this.btSuaHD.Click += new System.EventHandler(this.btSuaHD_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.dgvHoaDon);
            this.groupBox3.Controls.Add(this.tbTong);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(481, 392);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hoá Đơn";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(447, 340);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "$";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.Pink;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(8, 21);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(465, 301);
            this.dgvHoaDon.TabIndex = 15;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick_1);
            // 
            // tbTong
            // 
            this.tbTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTong.Location = new System.Drawing.Point(62, 337);
            this.tbTong.Name = "tbTong";
            this.tbTong.Size = new System.Drawing.Size(411, 22);
            this.tbTong.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tổng";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.càiĐặtToolStripMenuItem,
            this.refeshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(957, 28);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(105, 24);
            this.toolStripMenuItem1.Text = "Trợ giúp (F1)";
            // 
            // càiĐặtToolStripMenuItem
            // 
            this.càiĐặtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.báoCáoToolStripMenuItem1,
            this.đổimậtkhẩuToolStripMenuItem,
            this.đăngKíVIPChoKháchToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.càiĐặtToolStripMenuItem.Name = "càiĐặtToolStripMenuItem";
            this.càiĐặtToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.càiĐặtToolStripMenuItem.Text = "Cài Đặt";
            // 
            // báoCáoToolStripMenuItem1
            // 
            this.báoCáoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gọiQuảnLíToolStripMenuItem,
            this.gặpLỗiKhiSửDụngToolStripMenuItem});
            this.báoCáoToolStripMenuItem1.Name = "báoCáoToolStripMenuItem1";
            this.báoCáoToolStripMenuItem1.Size = new System.Drawing.Size(236, 26);
            this.báoCáoToolStripMenuItem1.Text = "Báo Cáo";
            // 
            // gọiQuảnLíToolStripMenuItem
            // 
            this.gọiQuảnLíToolStripMenuItem.Name = "gọiQuảnLíToolStripMenuItem";
            this.gọiQuảnLíToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.gọiQuảnLíToolStripMenuItem.Text = "Gọi Quản Lí";
            this.gọiQuảnLíToolStripMenuItem.Click += new System.EventHandler(this.gọiQuảnLíToolStripMenuItem_Click_1);
            // 
            // gặpLỗiKhiSửDụngToolStripMenuItem
            // 
            this.gặpLỗiKhiSửDụngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khôngTìmĐượcSPToolStripMenuItem,
            this.khôngThựcHiệnĐượcChứcNăngToolStripMenuItem,
            this.xemMãKhuyếnMãiToolStripMenuItem,
            this.khácToolStripMenuItem});
            this.gặpLỗiKhiSửDụngToolStripMenuItem.Name = "gặpLỗiKhiSửDụngToolStripMenuItem";
            this.gặpLỗiKhiSửDụngToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.gặpLỗiKhiSửDụngToolStripMenuItem.Text = "Gặp Lỗi Khi Sử Dụng";
            this.gặpLỗiKhiSửDụngToolStripMenuItem.Click += new System.EventHandler(this.gặpLỗiKhiSửDụngToolStripMenuItem_Click);
            // 
            // khôngTìmĐượcSPToolStripMenuItem
            // 
            this.khôngTìmĐượcSPToolStripMenuItem.Name = "khôngTìmĐượcSPToolStripMenuItem";
            this.khôngTìmĐượcSPToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.khôngTìmĐượcSPToolStripMenuItem.Text = "Không Tìm Được SP";
            this.khôngTìmĐượcSPToolStripMenuItem.Click += new System.EventHandler(this.khôngTìmĐượcSPToolStripMenuItem_Click_1);
            // 
            // khôngThựcHiệnĐượcChứcNăngToolStripMenuItem
            // 
            this.khôngThựcHiệnĐượcChứcNăngToolStripMenuItem.Name = "khôngThựcHiệnĐượcChứcNăngToolStripMenuItem";
            this.khôngThựcHiệnĐượcChứcNăngToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.khôngThựcHiệnĐượcChứcNăngToolStripMenuItem.Text = "Không Thực Hiện Được Chức Năng";
            this.khôngThựcHiệnĐượcChứcNăngToolStripMenuItem.Click += new System.EventHandler(this.khôngThựcHiệnĐượcChứcNăngToolStripMenuItem_Click_1);
            // 
            // xemMãKhuyếnMãiToolStripMenuItem
            // 
            this.xemMãKhuyếnMãiToolStripMenuItem.Name = "xemMãKhuyếnMãiToolStripMenuItem";
            this.xemMãKhuyếnMãiToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.xemMãKhuyếnMãiToolStripMenuItem.Text = "Xem Mã Khuyến Mãi";
            this.xemMãKhuyếnMãiToolStripMenuItem.Click += new System.EventHandler(this.xemMãKhuyếnMãiToolStripMenuItem_Click_1);
            // 
            // khácToolStripMenuItem
            // 
            this.khácToolStripMenuItem.Name = "khácToolStripMenuItem";
            this.khácToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.khácToolStripMenuItem.Text = "Khác.....";
            this.khácToolStripMenuItem.Click += new System.EventHandler(this.khácToolStripMenuItem_Click_1);
            // 
            // đổimậtkhẩuToolStripMenuItem
            // 
            this.đổimậtkhẩuToolStripMenuItem.Name = "đổimậtkhẩuToolStripMenuItem";
            this.đổimậtkhẩuToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.đổimậtkhẩuToolStripMenuItem.Text = "Đổi Mật Khẩu";
            this.đổimậtkhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổimậtkhẩuToolStripMenuItem_Click_1);
            // 
            // đăngKíVIPChoKháchToolStripMenuItem
            // 
            this.đăngKíVIPChoKháchToolStripMenuItem.Name = "đăngKíVIPChoKháchToolStripMenuItem";
            this.đăngKíVIPChoKháchToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.đăngKíVIPChoKháchToolStripMenuItem.Text = "Đăng Kí VIP Cho Khách";
            this.đăngKíVIPChoKháchToolStripMenuItem.Click += new System.EventHandler(this.đăngKíVIPChoKháchToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // refeshToolStripMenuItem
            // 
            this.refeshToolStripMenuItem.Name = "refeshToolStripMenuItem";
            this.refeshToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.refeshToolStripMenuItem.Text = "Refresh (F5)";
            // 
            // btInHD
            // 
            this.btInHD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btInHD.Image = ((System.Drawing.Image)(resources.GetObject("btInHD.Image")));
            this.btInHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btInHD.Location = new System.Drawing.Point(210, 24);
            this.btInHD.Name = "btInHD";
            this.btInHD.Size = new System.Drawing.Size(213, 75);
            this.btInHD.TabIndex = 25;
            this.btInHD.Text = "In hoá đơn";
            this.btInHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btInHD.UseVisualStyleBackColor = false;
            this.btInHD.Click += new System.EventHandler(this.btInHD_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(362, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(228, 34);
            this.label14.TabIndex = 29;
            this.label14.Text = "Tên Nhân Viên";
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.BackColor = System.Drawing.Color.Transparent;
            this.lbTenNV.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNV.ForeColor = System.Drawing.Color.Navy;
            this.lbTenNV.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lbTenNV.Location = new System.Drawing.Point(596, 28);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(0, 36);
            this.lbTenNV.TabIndex = 28;
            // 
            // btThemHD
            // 
            this.btThemHD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btThemHD.Image = ((System.Drawing.Image)(resources.GetObject("btThemHD.Image")));
            this.btThemHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThemHD.Location = new System.Drawing.Point(6, 24);
            this.btThemHD.Name = "btThemHD";
            this.btThemHD.Size = new System.Drawing.Size(198, 75);
            this.btThemHD.TabIndex = 3;
            this.btThemHD.Text = "Thêm Hoá Đơn";
            this.btThemHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThemHD.UseVisualStyleBackColor = false;
            this.btThemHD.Click += new System.EventHandler(this.btThemHD_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Loại hàng";
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoLuong.Location = new System.Drawing.Point(104, 167);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(342, 22);
            this.tbSoLuong.TabIndex = 8;
            this.tbSoLuong.TextChanged += new System.EventHandler(this.tbSoLuong_TextChanged);
            // 
            // cbTenHang
            // 
            this.cbTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenHang.FormattingEnabled = true;
            this.cbTenHang.Location = new System.Drawing.Point(104, 69);
            this.cbTenHang.Name = "cbTenHang";
            this.cbTenHang.Size = new System.Drawing.Size(344, 24);
            this.cbTenHang.TabIndex = 6;
            this.cbTenHang.SelectedIndexChanged += new System.EventHandler(this.cbTenHang_SelectedIndexChanged_1);
            // 
            // tbLoaiHang
            // 
            this.tbLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoaiHang.Location = new System.Drawing.Point(286, 21);
            this.tbLoaiHang.Name = "tbLoaiHang";
            this.tbLoaiHang.Size = new System.Drawing.Size(162, 22);
            this.tbLoaiHang.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(469, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 401);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh Toán";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox7.Controls.Add(this.btXoaHD);
            this.groupBox7.Controls.Add(this.btInHD);
            this.groupBox7.Controls.Add(this.btSuaHD);
            this.groupBox7.Controls.Add(this.btThemHD);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(13, 199);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(439, 197);
            this.groupBox7.TabIndex = 25;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Chức Năng";
            // 
            // tbMaHD
            // 
            this.tbMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaHD.Location = new System.Drawing.Point(105, 23);
            this.tbMaHD.Name = "tbMaHD";
            this.tbMaHD.Size = new System.Drawing.Size(79, 22);
            this.tbMaHD.TabIndex = 22;
            this.tbMaHD.Text = "  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Mã Hoá Đơn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(429, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "$";
            // 
            // tbGia
            // 
            this.tbGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGia.Location = new System.Drawing.Point(104, 119);
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(344, 22);
            this.tbGia.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Giá";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.tbMaHD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbGia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbSoLuong);
            this.groupBox1.Controls.Add(this.cbTenHang);
            this.groupBox1.Controls.Add(this.tbLoaiHang);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-1, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 402);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mặt Hàng";
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(957, 462);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbTenNV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Bill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load_1);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Bill_KeyUp);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btXoaHD;
        private System.Windows.Forms.Button btSuaHD;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.TextBox tbTong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem càiĐặtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gọiQuảnLíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gặpLỗiKhiSửDụngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khôngTìmĐượcSPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khôngThựcHiệnĐượcChứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemMãKhuyếnMãiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khácToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổimậtkhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKíVIPChoKháchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refeshToolStripMenuItem;
        private System.Windows.Forms.Button btInHD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Button btThemHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.ComboBox cbTenHang;
        private System.Windows.Forms.TextBox tbLoaiHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox tbMaHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}