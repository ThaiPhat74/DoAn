namespace GUI_QLKS
{
    partial class frmThue
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdKhong = new System.Windows.Forms.RadioButton();
            this.rdCo = new System.Windows.Forms.RadioButton();
            this.cbTTTT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHD_TP = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenPhong_TP = new System.Windows.Forms.TextBox();
            this.DTPCO = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.DTPCI = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLayPhong = new System.Windows.Forms.Button();
            this.btnTraPhong_TP = new System.Windows.Forms.Button();
            this.btnThuePhong = new System.Windows.Forms.Button();
            this.btnDC_TP = new System.Windows.Forms.Button();
            this.btnSDDV_TP = new System.Windows.Forms.Button();
            this.btnTT_TP = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvTP_TP = new System.Windows.Forms.DataGridView();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTP_TP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rdKhong);
            this.groupBox2.Controls.Add(this.rdCo);
            this.groupBox2.Controls.Add(this.cbTTTT);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtHD_TP);
            this.groupBox2.Controls.Add(this.txtNote);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMaPhong);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTenPhong_TP);
            this.groupBox2.Controls.Add(this.DTPCO);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.DTPCI);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lb);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.txtTenKhach);
            this.groupBox2.Controls.Add(this.txtMaKhach);
            this.groupBox2.Location = new System.Drawing.Point(5, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 362);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Thông tin khách";
            // 
            // rdKhong
            // 
            this.rdKhong.AutoSize = true;
            this.rdKhong.Checked = true;
            this.rdKhong.Location = new System.Drawing.Point(246, 84);
            this.rdKhong.Name = "rdKhong";
            this.rdKhong.Size = new System.Drawing.Size(102, 17);
            this.rdKhong.TabIndex = 27;
            this.rdKhong.TabStop = true;
            this.rdKhong.Text = "không thông tin ";
            this.rdKhong.UseVisualStyleBackColor = true;
            this.rdKhong.CheckedChanged += new System.EventHandler(this.rdKhong_CheckedChanged);
            // 
            // rdCo
            // 
            this.rdCo.AutoSize = true;
            this.rdCo.Location = new System.Drawing.Point(158, 84);
            this.rdCo.Name = "rdCo";
            this.rdCo.Size = new System.Drawing.Size(82, 17);
            this.rdCo.TabIndex = 26;
            this.rdCo.Text = "Có thông tin";
            this.rdCo.UseVisualStyleBackColor = true;
            this.rdCo.CheckedChanged += new System.EventHandler(this.rdCo_CheckedChanged);
            // 
            // cbTTTT
            // 
            this.cbTTTT.Enabled = false;
            this.cbTTTT.FormattingEnabled = true;
            this.cbTTTT.Location = new System.Drawing.Point(158, 287);
            this.cbTTTT.Name = "cbTTTT";
            this.cbTTTT.Size = new System.Drawing.Size(182, 21);
            this.cbTTTT.TabIndex = 25;
            this.cbTTTT.SelectedIndexChanged += new System.EventHandler(this.cbTTTT_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mã Hoá đơn";
            // 
            // txtHD_TP
            // 
            this.txtHD_TP.Location = new System.Drawing.Point(158, 17);
            this.txtHD_TP.Name = "txtHD_TP";
            this.txtHD_TP.ReadOnly = true;
            this.txtHD_TP.Size = new System.Drawing.Size(182, 20);
            this.txtHD_TP.TabIndex = 23;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(158, 323);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(182, 20);
            this.txtNote.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tên phòng";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(158, 53);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.ReadOnly = true;
            this.txtMaPhong.Size = new System.Drawing.Size(182, 20);
            this.txtMaPhong.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã khách";
            // 
            // txtTenPhong_TP
            // 
            this.txtTenPhong_TP.Location = new System.Drawing.Point(158, 147);
            this.txtTenPhong_TP.Name = "txtTenPhong_TP";
            this.txtTenPhong_TP.ReadOnly = true;
            this.txtTenPhong_TP.Size = new System.Drawing.Size(182, 20);
            this.txtTenPhong_TP.TabIndex = 19;
            // 
            // DTPCO
            // 
            this.DTPCO.Location = new System.Drawing.Point(158, 250);
            this.DTPCO.Name = "DTPCO";
            this.DTPCO.Size = new System.Drawing.Size(182, 20);
            this.DTPCO.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Mã Phòng";
            // 
            // DTPCI
            // 
            this.DTPCI.Location = new System.Drawing.Point(158, 215);
            this.DTPCI.Name = "DTPCI";
            this.DTPCI.Size = new System.Drawing.Size(182, 20);
            this.DTPCI.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 186);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Tên khách";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(31, 330);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(45, 13);
            this.lb.TabIndex = 14;
            this.lb.Text = "Ghi Chú";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(31, 222);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Giờ vào";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(31, 256);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Giờ ra";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(31, 295);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(109, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "Tình trạng thanh toán";
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhach.Location = new System.Drawing.Point(158, 179);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.ReadOnly = true;
            this.txtTenKhach.Size = new System.Drawing.Size(182, 20);
            this.txtTenKhach.TabIndex = 8;
            this.txtTenKhach.Text = "Nhập mã khách và ấn Enter";
            this.txtTenKhach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Location = new System.Drawing.Point(158, 111);
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(182, 20);
            this.txtMaKhach.TabIndex = 7;
            this.txtMaKhach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaKhach_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 546);
            this.panel1.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Location = new System.Drawing.Point(831, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 540);
            this.panel3.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLayPhong);
            this.groupBox1.Controls.Add(this.btnTraPhong_TP);
            this.groupBox1.Controls.Add(this.btnThuePhong);
            this.groupBox1.Controls.Add(this.btnDC_TP);
            this.groupBox1.Controls.Add(this.btnSDDV_TP);
            this.groupBox1.Controls.Add(this.btnTT_TP);
            this.groupBox1.Location = new System.Drawing.Point(5, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 166);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnLayPhong
            // 
            this.btnLayPhong.Location = new System.Drawing.Point(21, 100);
            this.btnLayPhong.Name = "btnLayPhong";
            this.btnLayPhong.Size = new System.Drawing.Size(112, 60);
            this.btnLayPhong.TabIndex = 25;
            this.btnLayPhong.Text = "Lấy phòng";
            this.btnLayPhong.UseVisualStyleBackColor = true;
            this.btnLayPhong.Click += new System.EventHandler(this.btnLayPhong_Click);
            // 
            // btnTraPhong_TP
            // 
            this.btnTraPhong_TP.Location = new System.Drawing.Point(268, 36);
            this.btnTraPhong_TP.Name = "btnTraPhong_TP";
            this.btnTraPhong_TP.Size = new System.Drawing.Size(103, 57);
            this.btnTraPhong_TP.TabIndex = 23;
            this.btnTraPhong_TP.Text = "Đặt phòng/Huỷ đặt phòng";
            this.btnTraPhong_TP.UseVisualStyleBackColor = true;
            this.btnTraPhong_TP.Click += new System.EventHandler(this.btnTraPhong_TP_Click);
            // 
            // btnThuePhong
            // 
            this.btnThuePhong.Location = new System.Drawing.Point(21, 34);
            this.btnThuePhong.Name = "btnThuePhong";
            this.btnThuePhong.Size = new System.Drawing.Size(112, 60);
            this.btnThuePhong.TabIndex = 21;
            this.btnThuePhong.Text = "Thuê phòng";
            this.btnThuePhong.UseVisualStyleBackColor = true;
            this.btnThuePhong.Click += new System.EventHandler(this.btnThuePhong_Click);
            // 
            // btnDC_TP
            // 
            this.btnDC_TP.Location = new System.Drawing.Point(268, 102);
            this.btnDC_TP.Name = "btnDC_TP";
            this.btnDC_TP.Size = new System.Drawing.Size(103, 58);
            this.btnDC_TP.TabIndex = 0;
            this.btnDC_TP.Text = "Sửa thuê phòng";
            this.btnDC_TP.UseVisualStyleBackColor = true;
            this.btnDC_TP.Click += new System.EventHandler(this.btnDC_TP_Click);
            // 
            // btnSDDV_TP
            // 
            this.btnSDDV_TP.Location = new System.Drawing.Point(150, 36);
            this.btnSDDV_TP.Name = "btnSDDV_TP";
            this.btnSDDV_TP.Size = new System.Drawing.Size(103, 57);
            this.btnSDDV_TP.TabIndex = 20;
            this.btnSDDV_TP.Text = "Sử dụng dịch vụ";
            this.btnSDDV_TP.UseVisualStyleBackColor = true;
            this.btnSDDV_TP.Click += new System.EventHandler(this.btnSDDV_TP_Click_1);
            // 
            // btnTT_TP
            // 
            this.btnTT_TP.Location = new System.Drawing.Point(150, 102);
            this.btnTT_TP.Name = "btnTT_TP";
            this.btnTT_TP.Size = new System.Drawing.Size(103, 58);
            this.btnTT_TP.TabIndex = 18;
            this.btnTT_TP.Text = "Thanh toán ";
            this.btnTT_TP.UseVisualStyleBackColor = true;
            this.btnTT_TP.Click += new System.EventHandler(this.btnTT_TP_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(597, 530);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "TroVe";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvTP_TP);
            this.panel2.Location = new System.Drawing.Point(8, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 543);
            this.panel2.TabIndex = 15;
            // 
            // dtgvTP_TP
            // 
            this.dtgvTP_TP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTP_TP.Location = new System.Drawing.Point(3, 7);
            this.dtgvTP_TP.Name = "dtgvTP_TP";
            this.dtgvTP_TP.Size = new System.Drawing.Size(811, 533);
            this.dtgvTP_TP.TabIndex = 0;
            this.dtgvTP_TP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTP_TP_CellClick);
            this.dtgvTP_TP.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgvTP_TP_CellFormatting);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // frmThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 558);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmThue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thuê phòng";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTP_TP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker DTPCO;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker DTPCI;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSDDV_TP;
        private System.Windows.Forms.DataGridView dtgvTP_TP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenPhong_TP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThuePhong;
        private System.Windows.Forms.Button btnDC_TP;
        private System.Windows.Forms.Button btnTT_TP;
        private System.Windows.Forms.Button btnTraPhong_TP;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox txtNote;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.TextBox txtHD_TP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTTTT;
        private System.Windows.Forms.Button btnLayPhong;
        private System.Windows.Forms.RadioButton rdKhong;
        private System.Windows.Forms.RadioButton rdCo;
        private System.Windows.Forms.Label label4;
    }
}