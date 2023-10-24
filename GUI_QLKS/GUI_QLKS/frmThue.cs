using DAL_QLKS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLKS
{
    public partial class frmThue : Form
    {
        ThuePhongDAL tp = new ThuePhongDAL();
        BillDAL b = new BillDAL ();
        UOServiceDAL uO = new UOServiceDAL ();
        public frmThue()
        {
            InitializeComponent();
            customDTPK();
            loadServiceType(cbTTTT);
        }
        void customDTPK()
        {
            DTPCI.Format = DateTimePickerFormat.Custom;
            DTPCI.CustomFormat = "dd/MM/yyyy - HH:mm:ss";
            DTPCO.Format = DateTimePickerFormat.Custom;
            DTPCO.CustomFormat = "dd/MM/yyyy - HH:mm:ss";
        }
        void loadServiceType(ComboBox cb)
        {
            List<Rent> ListStatus = ThuePhongDAL.Instance.LoadRentList();
            cb.DataSource = ListStatus;
            cb.DisplayMember = "Pay";
            
        }

        #region Events

        public void SetButtonID(int id,string ten)
        {
            txtMaPhong.Text = id.ToString();
            txtTenPhong_TP.Text = ten.ToString();
            showThue();
            //loadServiceType();
        }
        void showThue()
        {
            dtgvTP_TP.DataSource = tp.TimTheoID(int.Parse(txtMaPhong.Text));
            //addBinDing();
        }
        private void btnThuePhong_Click(object sender, EventArgs e)
        {
            if (txtMaKhach.Text != "" && txtMaPhong.Text != "" )
            {
                if(txtNote.Text == "")
                {
                    txtNote.Text = "None";
                }    
                Rent r = new Rent(int.Parse(txtMaKhach.Text),int.Parse(txtMaPhong.Text),DTPCI.Value,DTPCO.Value,cbTTTT.Text,txtNote.Text);

                if (tp.thuePhong(r))
                {
                    MessageBox.Show("Thuê phòng thành công");
                    showThue();
                }
                else
                {
                    MessageBox.Show("Thuê không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đủ thông tin");
            }
        }

        private void btnTT_TP_Click(object sender, EventArgs e)
        {
            if(txtHD_TP.Text != "")
            {
                this.Hide();
                frmThanhToan tt = new frmThanhToan();
                tt.setID(int.Parse(txtHD_TP.Text));
                tt.ShowDialog();
                this.Close();
            }    
            else
            {
                MessageBox.Show("Vui lòng chọn hoá đơn!");
            }    
        }

        private void dtgvTP_TP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dtgvTP_TP.SelectedRows[0];
                txtHD_TP.Text = row.Cells[0].Value.ToString();
                txtMaPhong.Text = row.Cells[1].Value.ToString();
                txtMaKhach.Text = row.Cells[2].Value.ToString();
                txtTenKhach.Text = row.Cells[4].Value.ToString();
                txtTenPhong_TP.Text = row.Cells[3].Value.ToString();
                DTPCI.Text = row.Cells[5].Value.ToString();
                DTPCO.Text = row.Cells[6].Value.ToString();
                cbTTTT.Text = row.Cells[7].Value.ToString();
                txtNote.Text = row.Cells[8].Value.ToString();
            }
            catch { Exception ex; }
        }
        void addBinDing()
        {
            txtHD_TP.DataBindings.Add(new Binding("Text", dtgvTP_TP.DataSource, "Mã hoá đơn"));
            txtMaPhong.DataBindings.Add(new Binding("Text", dtgvTP_TP.DataSource, "Mã phòng"));
            txtMaKhach.DataBindings.Add(new Binding("Text", dtgvTP_TP.DataSource, "Mã khách"));
            txtTenKhach.DataBindings.Add(new Binding("Text", dtgvTP_TP.DataSource, "Tên khách"));
        }
        private void btnSDDV_TP_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmSuDungDichVu sddv = new frmSuDungDichVu();
                sddv.setID(int.Parse(txtHD_TP.Text));
                sddv.ShowDialog();
                this.Close();
            }
            catch { Exception ex; }
        }
        private void dtgvTP_TP_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 5 || e.ColumnIndex == 6) // Thay yourDateTimeColumnIndex bằng chỉ số cột datetime trong DataGridView
            {
                if (e.Value is DateTime)
                {
                    DateTime dateValue = (DateTime)e.Value;
                    e.Value = dateValue.ToString("dd/MM/yyyy HH:mm:ss"); // Thay đổi định dạng ngày giờ ở đây
                    e.FormattingApplied = true;
                }
            }
        }

       
        CustomerDAL cus = new CustomerDAL();

        private void txtMaKhach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Ngăn chặn ký tự "Enter" hiển thị trong TextBox
                e.Handled = true;

                // Thực hiện sự kiện ở đây
                // Ví dụ: Gọi hàm để xử lý khi Enter được nhấn
                if (txtMaKhach.Text != "")
                {
                    string name;
                    name = CustomerDAL.Instance.idKhach(int.Parse(txtMaKhach.Text));
                    if (name != "")
                    {

                        txtTenKhach.Text = name;
                    }
                    else
                    {
                        MessageBox.Show("Khách chưa có, Bạn hãy đăng ký!");
                        txtTenKhach.Text = "";
                    }
                }   
            }
        }
        #endregion

        private void frmThue_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            frmQuanLy frm = new frmQuanLy();
            frm.ShowDialog();   
            this.Close();
        }

        private void cbTTTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pay;
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
            {
                return;
            }
            Rent r = cb.SelectedItem as Rent;
            pay = r.Pay;
            
        }
    }
}
