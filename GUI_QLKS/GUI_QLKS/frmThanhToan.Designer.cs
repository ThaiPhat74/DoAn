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
            this.dtgvBillTong = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHD_TT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillTong)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbDis)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvBillTong
            // 
            this.dtgvBillTong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBillTong.Location = new System.Drawing.Point(3, 3);
            this.dtgvBillTong.Name = "dtgvBillTong";
            this.dtgvBillTong.Size = new System.Drawing.Size(1051, 531);
            this.dtgvBillTong.TabIndex = 0;
            this.dtgvBillTong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBillTong_CellClick);
            this.dtgvBillTong.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgvBillTong_CellFormatting);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvBillTong);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 537);
            this.panel1.TabIndex = 1;
            // 
            // txtHD_TT
            // 
            this.txtHD_TT.Location = new System.Drawing.Point(93, 26);
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
            this.panel2.Location = new System.Drawing.Point(1075, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 531);
            this.panel2.TabIndex = 4;
            // 
            // txtTienGiam
            // 
            this.txtTienGiam.Location = new System.Drawing.Point(93, 202);
            this.txtTienGiam.Name = "txtTienGiam";
            this.txtTienGiam.ReadOnly = true;
            this.txtTienGiam.Size = new System.Drawing.Size(163, 20);
            this.txtTienGiam.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Giảm giá";
            // 
            // btnDis
            // 
            this.btnDis.Location = new System.Drawing.Point(3, 432);
            this.btnDis.Name = "btnDis";
            this.btnDis.Size = new System.Drawing.Size(82, 61);
            this.btnDis.TabIndex = 15;
            this.btnDis.Text = "Giảm giá";
            this.btnDis.UseVisualStyleBackColor = true;
            this.btnDis.Click += new System.EventHandler(this.btnDis_Click);
            // 
            // nbDis
            // 
            this.nbDis.Location = new System.Drawing.Point(93, 113);
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
            this.txtTongTien.Location = new System.Drawing.Point(93, 159);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(163, 20);
            this.txtTongTien.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tổng tiền";
            // 
            // txtMP_Bill
            // 
            this.txtMP_Bill.Location = new System.Drawing.Point(93, 69);
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
            this.btnCO_Bill.Location = new System.Drawing.Point(103, 432);
            this.btnCO_Bill.Name = "btnCO_Bill";
            this.btnCO_Bill.Size = new System.Drawing.Size(82, 61);
            this.btnCO_Bill.TabIndex = 7;
            this.btnCO_Bill.Text = "Check out";
            this.btnCO_Bill.UseVisualStyleBackColor = true;
            this.btnCO_Bill.Click += new System.EventHandler(this.btnCO_Bill_Click);
            // 
            // btnTT_Bill
            // 
            this.btnTT_Bill.Location = new System.Drawing.Point(205, 432);
            this.btnTT_Bill.Name = "btnTT_Bill";
            this.btnTT_Bill.Size = new System.Drawing.Size(80, 61);
            this.btnTT_Bill.TabIndex = 6;
            this.btnTT_Bill.Text = "Thanh toán ";
            this.btnTT_Bill.UseVisualStyleBackColor = true;
            this.btnTT_Bill.Click += new System.EventHandler(this.btnTT_Bill_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hướng dẫn";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(103, 278);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(163, 82);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Tiến hành giảm giá(Nếu có). Sau đó check out phòng và thanh toán";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
            this.ResumeLayout(false);

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
    }
}