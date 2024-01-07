namespace GUI_QLKS
{
    partial class frmThanhToan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThanhToan));
            this.dtgvBillTong = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHD_TT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCOBB = new System.Windows.Forms.Button();
            this.txttotalUOS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTongPhong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTienGiam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDis = new System.Windows.Forms.Button();
            this.nbDis = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMP_Bill = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCO_Bill = new System.Windows.Forms.Button();
            this.btnTT_Bill = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bingdingBill = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.listUO = new System.Windows.Forms.ListView();
            this.idHoaDon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameDV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Donvitinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.thanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.listRent = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillTong)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbDis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bingdingBill)).BeginInit();
            this.bingdingBill.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvBillTong
            // 
            this.dtgvBillTong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBillTong.Location = new System.Drawing.Point(3, 3);
            this.dtgvBillTong.Name = "dtgvBillTong";
            this.dtgvBillTong.Size = new System.Drawing.Size(1002, 173);
            this.dtgvBillTong.TabIndex = 0;
            this.dtgvBillTong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBillTong_CellClick);
            this.dtgvBillTong.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgvBillTong_CellFormatting);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvBillTong);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 179);
            this.panel1.TabIndex = 1;
            // 
            // txtHD_TT
            // 
            this.txtHD_TT.Location = new System.Drawing.Point(103, 26);
            this.txtHD_TT.Name = "txtHD_TT";
            this.txtHD_TT.ReadOnly = true;
            this.txtHD_TT.Size = new System.Drawing.Size(163, 20);
            this.txtHD_TT.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã hoá đơn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCOBB);
            this.panel2.Controls.Add(this.txttotalUOS);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtTongPhong);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtTienGiam);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnDis);
            this.panel2.Controls.Add(this.nbDis);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtTongTien);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtMP_Bill);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnCO_Bill);
            this.panel2.Controls.Add(this.btnTT_Bill);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.txtHD_TT);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1017, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 535);
            this.panel2.TabIndex = 4;
            // 
            // btnCOBB
            // 
            this.btnCOBB.Location = new System.Drawing.Point(161, 417);
            this.btnCOBB.Name = "btnCOBB";
            this.btnCOBB.Size = new System.Drawing.Size(82, 46);
            this.btnCOBB.TabIndex = 22;
            this.btnCOBB.Text = "Check out trên bill";
            this.btnCOBB.UseVisualStyleBackColor = true;
            this.btnCOBB.Click += new System.EventHandler(this.btnCOBB_Click);
            // 
            // txttotalUOS
            // 
            this.txttotalUOS.Location = new System.Drawing.Point(103, 199);
            this.txttotalUOS.Name = "txttotalUOS";
            this.txttotalUOS.ReadOnly = true;
            this.txttotalUOS.Size = new System.Drawing.Size(163, 20);
            this.txttotalUOS.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tổng tiền dịch vụ";
            // 
            // txtTongPhong
            // 
            this.txtTongPhong.Location = new System.Drawing.Point(103, 156);
            this.txtTongPhong.Name = "txtTongPhong";
            this.txtTongPhong.ReadOnly = true;
            this.txtTongPhong.Size = new System.Drawing.Size(163, 20);
            this.txtTongPhong.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tổng tiền phòng";
            // 
            // txtTienGiam
            // 
            this.txtTienGiam.Location = new System.Drawing.Point(103, 291);
            this.txtTienGiam.Name = "txtTienGiam";
            this.txtTienGiam.ReadOnly = true;
            this.txtTienGiam.Size = new System.Drawing.Size(163, 20);
            this.txtTienGiam.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Giảm giá";
            // 
            // btnDis
            // 
            this.btnDis.Location = new System.Drawing.Point(54, 475);
            this.btnDis.Name = "btnDis";
            this.btnDis.Size = new System.Drawing.Size(82, 46);
            this.btnDis.TabIndex = 15;
            this.btnDis.Text = "Giảm giá";
            this.btnDis.UseVisualStyleBackColor = true;
            this.btnDis.Click += new System.EventHandler(this.btnDis_Click);
            // 
            // nbDis
            // 
            this.nbDis.Location = new System.Drawing.Point(103, 113);
            this.nbDis.Name = "nbDis";
            this.nbDis.Size = new System.Drawing.Size(163, 20);
            this.nbDis.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Giảm giá";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(103, 245);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(163, 20);
            this.txtTongTien.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tổng tiền";
            // 
            // txtMP_Bill
            // 
            this.txtMP_Bill.Location = new System.Drawing.Point(103, 69);
            this.txtMP_Bill.Name = "txtMP_Bill";
            this.txtMP_Bill.ReadOnly = true;
            this.txtMP_Bill.Size = new System.Drawing.Size(163, 20);
            this.txtMP_Bill.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mã Phòng";
            // 
            // btnCO_Bill
            // 
            this.btnCO_Bill.Location = new System.Drawing.Point(54, 417);
            this.btnCO_Bill.Name = "btnCO_Bill";
            this.btnCO_Bill.Size = new System.Drawing.Size(82, 46);
            this.btnCO_Bill.TabIndex = 7;
            this.btnCO_Bill.Text = "Check out bây giờ";
            this.btnCO_Bill.UseVisualStyleBackColor = true;
            this.btnCO_Bill.Click += new System.EventHandler(this.btnCO_Bill_Click);
            // 
            // btnTT_Bill
            // 
            this.btnTT_Bill.Location = new System.Drawing.Point(163, 475);
            this.btnTT_Bill.Name = "btnTT_Bill";
            this.btnTT_Bill.Size = new System.Drawing.Size(80, 46);
            this.btnTT_Bill.TabIndex = 6;
            this.btnTT_Bill.Text = "Thanh toán ";
            this.btnTT_Bill.UseVisualStyleBackColor = true;
            this.btnTT_Bill.Click += new System.EventHandler(this.btnTT_Bill_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hướng dẫn";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(103, 329);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(163, 82);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Tiến hành giảm giá(Nếu có). Sau đó check out phòng và thanh toán";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bingdingBill
            // 
            this.bingdingBill.AddNewItem = null;
            this.bingdingBill.CountItem = this.bindingNavigatorCountItem;
            this.bingdingBill.DeleteItem = null;
            this.bingdingBill.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bingdingBill.Location = new System.Drawing.Point(0, 0);
            this.bingdingBill.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bingdingBill.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bingdingBill.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bingdingBill.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bingdingBill.Name = "bingdingBill";
            this.bingdingBill.PositionItem = this.bindingNavigatorPositionItem;
            this.bingdingBill.Size = new System.Drawing.Size(1333, 25);
            this.bingdingBill.TabIndex = 5;
            this.bingdingBill.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(12, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1312, 541);
            this.panel3.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.listUO);
            this.panel5.Location = new System.Drawing.Point(583, 185);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(425, 346);
            this.panel5.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Thông tin sử dụng dịch vụ";
            // 
            // listUO
            // 
            this.listUO.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idHoaDon,
            this.NameDV,
            this.Count,
            this.Donvitinh,
            this.thanhTien});
            this.listUO.GridLines = true;
            this.listUO.HideSelection = false;
            this.listUO.Location = new System.Drawing.Point(3, 34);
            this.listUO.Name = "listUO";
            this.listUO.Size = new System.Drawing.Size(419, 309);
            this.listUO.TabIndex = 3;
            this.listUO.UseCompatibleStateImageBehavior = false;
            this.listUO.View = System.Windows.Forms.View.Details;
            // 
            // idHoaDon
            // 
            this.idHoaDon.Text = "Mã hoá đơn";
            this.idHoaDon.Width = 70;
            // 
            // NameDV
            // 
            this.NameDV.Text = "Tên dịch vụ";
            this.NameDV.Width = 100;
            // 
            // Count
            // 
            this.Count.Text = "Số lượng";
            this.Count.Width = 93;
            // 
            // Donvitinh
            // 
            this.Donvitinh.Text = "Đơn vị tính";
            this.Donvitinh.Width = 81;
            // 
            // thanhTien
            // 
            this.thanhTien.Text = "Đơn giá";
            this.thanhTien.Width = 64;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.listRent);
            this.panel4.Location = new System.Drawing.Point(6, 185);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(571, 349);
            this.panel4.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Thông tin thuê phòng";
            // 
            // listRent
            // 
            this.listRent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listRent.GridLines = true;
            this.listRent.HideSelection = false;
            this.listRent.Location = new System.Drawing.Point(3, 34);
            this.listRent.Name = "listRent";
            this.listRent.Size = new System.Drawing.Size(565, 312);
            this.listRent.TabIndex = 4;
            this.listRent.UseCompatibleStateImageBehavior = false;
            this.listRent.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã hoá đơn";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên phòng";
            this.columnHeader2.Width = 64;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên khách";
            this.columnHeader6.Width = 78;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Giờ vào";
            this.columnHeader7.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giờ ra";
            this.columnHeader3.Width = 69;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn giá";
            this.columnHeader4.Width = 81;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số ngày ở";
            this.columnHeader5.Width = 64;
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 574);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.bingdingBill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmThanhToan_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillTong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbDis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bingdingBill)).EndInit();
            this.bingdingBill.ResumeLayout(false);
            this.bingdingBill.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvBillTong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtHD_TT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTT_Bill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCO_Bill;
        private System.Windows.Forms.TextBox txtMP_Bill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nbDis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDis;
        private System.Windows.Forms.TextBox txtTienGiam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingNavigator bingdingBill;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView listUO;
        private System.Windows.Forms.ColumnHeader idHoaDon;
        private System.Windows.Forms.ColumnHeader NameDV;
        private System.Windows.Forms.ColumnHeader Count;
        private System.Windows.Forms.ColumnHeader Donvitinh;
        private System.Windows.Forms.ColumnHeader thanhTien;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView listRent;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txttotalUOS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTongPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCOBB;
    }
}