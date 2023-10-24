namespace GUI_QLKS
{
    partial class frmSuDungDichVu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listUO = new System.Windows.Forms.ListView();
            this.idHoaDon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameDV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Donvitinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.thanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtTenDV_SDDV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHD_SDDV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbDichVu = new System.Windows.Forms.ComboBox();
            this.cbDanhMuc = new System.Windows.Forms.ComboBox();
            this.nbSL = new System.Windows.Forms.NumericUpDown();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbSL)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listUO);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 371);
            this.panel1.TabIndex = 0;
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
            this.listUO.Location = new System.Drawing.Point(0, 3);
            this.listUO.Name = "listUO";
            this.listUO.Size = new System.Drawing.Size(475, 365);
            this.listUO.TabIndex = 2;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(496, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 368);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtTenDV_SDDV);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txtHD_SDDV);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(276, 118);
            this.panel5.TabIndex = 8;
            // 
            // txtTenDV_SDDV
            // 
            this.txtTenDV_SDDV.Location = new System.Drawing.Point(119, 55);
            this.txtTenDV_SDDV.Name = "txtTenDV_SDDV";
            this.txtTenDV_SDDV.ReadOnly = true;
            this.txtTenDV_SDDV.Size = new System.Drawing.Size(95, 20);
            this.txtTenDV_SDDV.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên dịch vụ";
            // 
            // txtHD_SDDV
            // 
            this.txtHD_SDDV.Location = new System.Drawing.Point(119, 20);
            this.txtHD_SDDV.Name = "txtHD_SDDV";
            this.txtHD_SDDV.ReadOnly = true;
            this.txtHD_SDDV.Size = new System.Drawing.Size(95, 20);
            this.txtHD_SDDV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hoá đơn";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Red;
            this.txtTotal.Location = new System.Drawing.Point(160, 237);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(121, 41);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btnThem);
            this.panel4.Controls.Add(this.cbDichVu);
            this.panel4.Controls.Add(this.cbDanhMuc);
            this.panel4.Controls.Add(this.nbSL);
            this.panel4.Location = new System.Drawing.Point(3, 127);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(276, 104);
            this.panel4.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lượng";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(190, 27);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 48);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm món";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbDichVu
            // 
            this.cbDichVu.FormattingEnabled = true;
            this.cbDichVu.Location = new System.Drawing.Point(6, 42);
            this.cbDichVu.Name = "cbDichVu";
            this.cbDichVu.Size = new System.Drawing.Size(178, 21);
            this.cbDichVu.TabIndex = 1;
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.FormattingEnabled = true;
            this.cbDanhMuc.Location = new System.Drawing.Point(6, 15);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Size = new System.Drawing.Size(178, 21);
            this.cbDanhMuc.TabIndex = 0;
            this.cbDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cbDanhMuc_SelectedIndexChanged);
            // 
            // nbSL
            // 
            this.nbSL.Location = new System.Drawing.Point(89, 69);
            this.nbSL.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nbSL.Name = "nbSL";
            this.nbSL.Size = new System.Drawing.Size(95, 20);
            this.nbSL.TabIndex = 3;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // frmSuDungDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 390);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSuDungDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sử dụng dịch vụ";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbSL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nbSL;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbDichVu;
        private System.Windows.Forms.ComboBox cbDanhMuc;
        private System.Windows.Forms.ListView listUO;
        private System.Windows.Forms.ColumnHeader idHoaDon;
        private System.Windows.Forms.ColumnHeader NameDV;
        private System.Windows.Forms.ColumnHeader Count;
        private System.Windows.Forms.ColumnHeader Donvitinh;
        private System.Windows.Forms.ColumnHeader thanhTien;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenDV_SDDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHD_SDDV;
        private System.Windows.Forms.Label label1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}