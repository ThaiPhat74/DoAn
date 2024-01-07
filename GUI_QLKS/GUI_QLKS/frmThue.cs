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
        BindingSource listRent = new BindingSource();
        ThuePhongDAL tp = new ThuePhongDAL();
        BillDAL b = new BillDAL();
        UOServiceDAL uO = new UOServiceDAL();
        RoomDAL room = new RoomDAL();
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

        public void SetButtonID(int id, string ten)
        {
            txtMaPhong.Text = id.ToString();
            txtTenPhong_TP.Text = ten.ToString();
            showThue();
            //loadServiceType();
        }
        void showThue()
        {
            listRent.DataSource = tp.TimTheoID(int.Parse(txtMaPhong.Text));
            dtgvTP_TP.DataSource = listRent.DataSource;
            if(rdCo.Checked )
            {
                txtMaKhach.ReadOnly = false;
            }
            else
            {
                txtMaKhach.ReadOnly= true;
            }    
            //if(listRent.Count >0)
            //{
            //    addBinDing();
            //}    
            //addBinDing();
        }
        private void btnThuePhong_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdCo.Checked)
                {
                    if (txtMaPhong.Text != "" && txtMaKhach.Text != "")
                    {
                        if (txtNote.Text == "")
                        {
                            txtNote.Text = "None";
                        }
                        Rent rent = new Rent(int.Parse(txtMaKhach.Text), int.Parse(txtMaPhong.Text), DTPCI.Value, DTPCO.Value, cbTTTT.Text, txtNote.Text);

                        if (tp.thuePhong(rent))
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
                else
                {
                    if (txtMaPhong.Text != "")
                    {
                        if (txtNote.Text == "")
                        {
                            txtNote.Text = "None";
                        }
                        Rent rentk = new Rent(int.Parse(txtMaPhong.Text), DTPCI.Value, DTPCO.Value, cbTTTT.Text, txtNote.Text);

                        if (tp.thuePhongKhongThongTin(rentk))
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
            }
            catch { Exception ex; }
        }

        private void btnTT_TP_Click(object sender, EventArgs e)
        {
            if (txtHD_TP.Text != "")
            {
                this.Hide();
                frmThanhToan tt = new frmThanhToan();
                tt.setID(int.Parse(txtHD_TP.Text));
                tt.ShowDialog();
                this.Close();
            }
            else
            {
                addBinDing();
            }
        }

        private void dtgvTP_TP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra xem có hàng nào được chọn không
                if (dtgvTP_TP.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dtgvTP_TP.SelectedRows[0];
                    txtHD_TP.Text = row.Cells[0].Value?.ToString();
                    txtMaPhong.Text = row.Cells[1].Value?.ToString();
                    txtMaKhach.Text = row.Cells[2].Value?.ToString();
                    txtTenKhach.Text = row.Cells[4].Value?.ToString();
                    txtTenPhong_TP.Text = row.Cells[3].Value?.ToString();
                    DTPCI.Text = row.Cells[5].Value?.ToString();
                    DTPCO.Text = row.Cells[6].Value?.ToString();
                    cbTTTT.Text = row.Cells[7].Value?.ToString();
                    txtNote.Text = row.Cells[8].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        void addBinDing()
        {
            try
            {
                txtHD_TP.DataBindings.Add(new Binding("Text", dtgvTP_TP.DataSource, "Mã hoá đơn"));
                txtMaPhong.DataBindings.Add(new Binding("Text", dtgvTP_TP.DataSource, "Mã phòng"));
                txtMaKhach.DataBindings.Add(new Binding("Text", dtgvTP_TP.DataSource, "Mã khách"));
                txtTenKhach.DataBindings.Add(new Binding("Text", dtgvTP_TP.DataSource, "Tên khách"));
            }
            catch { Exception ex; }
        }
        private void btnSDDV_TP_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtHD_TP.Text != "")
                {
                    this.Hide();
                    frmSuDungDichVu sddv = new frmSuDungDichVu();
                    sddv.setID(int.Parse(txtHD_TP.Text));
                    sddv.ShowDialog();
                    this.Close();
                }
                else
                {
                    addBinDing();
                }
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
                    e.Value = dateValue.ToString("dd/MM/yyyy HH:mm:ss");
                    e.FormattingApplied = true;
                }
            }
        }

        CustomerDAL cus = new CustomerDAL();

        private void txtMaKhach_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;

                    
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
                    else
                    {
                        txtTenKhach.Text = "Nhập mã khách phía trên và enter";
                    }
                }
            }
            catch { Exception ex; }
        }
        #endregion

        

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

        private void btnTraPhong_TP_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdCo.Checked)
                {
                    if (txtHD_TP.Text == "")
                    {
                        if (txtMaKhach.Text != "" && txtMaPhong.Text != "")
                        {
                            if (txtNote.Text == "")
                            {
                                txtNote.Text = "None";
                            }
                            Rent r = new Rent(int.Parse(txtMaKhach.Text), int.Parse(txtMaPhong.Text), DTPCI.Value, DTPCO.Value, cbTTTT.Text, txtNote.Text);

                            if (tp.bookPhong(r))
                            {
                                MessageBox.Show("Đặt phòng thành công");
                                showThue();
                            }
                            else
                            {
                                MessageBox.Show("Đặt không thành công");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Xin hãy nhập đủ thông tin");
                        }
                    }
                    else
                    {
                        if (dtgvTP_TP.SelectedRows.Count > 0)
                        {
                            DataGridViewRow row = dtgvTP_TP.SelectedRows[0];
                            int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                            //xoa
                            if (tp.CancelBook(ID))
                            {
                                MessageBox.Show("Xoá phòng thành công");
                                showThue();
                            }
                            else
                            {
                                MessageBox.Show("Xoá không thành công");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Hãy chọn phòng muốn xoá");
                        }
                        MessageBox.Show("Huỷ đặt phòng!");
                    }
                }
                else
                {
                    if (txtHD_TP.Text == "")
                    {
                        if (txtMaPhong.Text != "")
                        {
                            if (txtNote.Text == "")
                            {
                                txtNote.Text = "None";
                            }
                            Rent r = new Rent(42, int.Parse(txtMaPhong.Text), DTPCI.Value, DTPCO.Value, cbTTTT.Text, txtNote.Text);

                            if (tp.bookPhong(r))
                            {
                                MessageBox.Show("Đặt phòng thành công");
                                showThue();
                            }
                            else
                            {
                                MessageBox.Show("Đặt không thành công");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Xin hãy nhập đủ thông tin");
                        }
                    }
                    else
                    {
                        if (dtgvTP_TP.SelectedRows.Count > 0)
                        {
                            DataGridViewRow row = dtgvTP_TP.SelectedRows[0];
                            int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                            //xoa
                            if (tp.CancelBook(ID))
                            {
                                MessageBox.Show("Xoá phòng thành công");
                                showThue();
                            }
                            else
                            {
                                MessageBox.Show("Xoá không thành công");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Hãy chọn phòng muốn xoá");
                        }
                        MessageBox.Show("Huỷ đặt phòng!");
                    }
                }    
            }
            catch { Exception ex; }
            
        }

        private void btnDC_TP_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdCo.Checked)
                {
                    if (dtgvTP_TP.SelectedRows.Count > 0)
                    {
                        if (txtHD_TP.Text != "" && txtMaKhach.Text != "" && txtMaPhong.Text != "" && DTPCI.Value <= DTPCO.Value)
                        {
                            DataGridViewRow row = dtgvTP_TP.SelectedRows[0];
                            int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                            Rent r = new Rent(ID, int.Parse(txtMaKhach.Text), int.Parse(txtMaPhong.Text), DTPCI.Value, DTPCO.Value, cbTTTT.Text, txtNote.Text);
                            if (tp.UpdatebookPhong(r))
                            {
                                MessageBox.Show("Sửa thuê phòng thành công");
                                showThue();
                            }
                            else
                            {
                                MessageBox.Show("Sửa thuê phòng thất bại");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Xin hãy nhập đủ thông tin");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hãy chọn hoá đơn bạn muốn sửa");
                    }
                }
                else
                {
                    if (dtgvTP_TP.SelectedRows.Count > 0)
                    {
                        if (txtHD_TP.Text != "" && txtMaKhach.Text != "" && txtMaPhong.Text != "" && DTPCI.Value <= DTPCO.Value)
                        {
                            DataGridViewRow row = dtgvTP_TP.SelectedRows[0];
                            int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                            Rent r = new Rent(ID, 42, int.Parse(txtMaPhong.Text), DTPCI.Value, DTPCO.Value, cbTTTT.Text, txtNote.Text);
                            if (tp.UpdatebookPhong(r))
                            {
                                MessageBox.Show("Sửa thuê phòng thành công");
                                showThue();
                            }
                            else
                            {
                                MessageBox.Show("Sửa thuê phòng thất bại");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Xin hãy nhập đủ thông tin");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hãy chọn hoá đơn bạn muốn sửa");
                    }
                }    
            }
           catch { Exception ex; }
        }

        private void btnLayPhong_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dtgvTP_TP.SelectedRows[0];
                int ID = int.Parse(txtMaPhong.Text);
                Room r = new Room(ID);

                if (room.LayPhong(ID))
                {
                    MessageBox.Show("Check in thành công");
                    showThue();
                }
                else
                {
                    MessageBox.Show("Check in thất bại");
                }
            }
            catch { Exception ex; }
        }

        private void rdCo_CheckedChanged(object sender, EventArgs e)
        {
            txtMaKhach.ReadOnly = false;
        }

        private void rdKhong_CheckedChanged(object sender, EventArgs e)
        {
            txtMaKhach.ReadOnly = true;
        }

        
    }
}
