using DTO;
using DAL_QLKS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLKS
{
    #region frm
    public partial class fadmin : Form
    {
        #region DoiTuong
        RoomDAL r = new RoomDAL();
        RoomTypeDAL RoomTypeDAL = new RoomTypeDAL();
        ServiceDAL service = new ServiceDAL();
        ServiceTypeDAL serviceType = new ServiceTypeDAL();
        AccountDAL acc = new AccountDAL();
        StaffDAL staff = new StaffDAL();
        CustomerDAL customer = new CustomerDAL();
        #endregion
        public fadmin()
        {
            InitializeComponent();
            LoadData();
            customDTPK();
            loadRoomStatus(cbTTTP_Phong);
        }
        void LoadData()
        {
            dtgvRoom.DataSource = r.getPhong();
            dtgvLoai_LoaiPhong.DataSource = RoomTypeDAL.getLoaiPhong();
            dtgvDV.DataSource = service.getDV();
            dtgvKDV.DataSource = serviceType.getLDV();
            dtgvTK.DataSource = acc.getTaiKhoan();
            dtgvNV.DataSource = staff.getStaff();
            dtgvKhach.DataSource = customer.getKhach();
        }

        
        private void fadmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmQuanLy f = new frmQuanLy();
            this.Hide();
            f.ShowDialog();
            f = null;
            this.Close();
        }
        void customDTPK()
        {
            dtpkNS_KH.Format = DateTimePickerFormat.Custom;
            dtpkNS_KH.CustomFormat = "dd/MM/yyyy";
            dtpkNSNV_NV.Format = DateTimePickerFormat.Custom;
            dtpkNSNV_NV.CustomFormat = "dd/MM/yyyy";
        }
        #endregion
        #region phong
        void loadRoomStatus(ComboBox cb)
        {
            List<Room> ListRoomStatus = RoomDAL.Instance.LoadStatusRoom();
            cb.DataSource = ListRoomStatus;
            cb.DisplayMember = "trangThai";

        }
        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            if (txtTenPhong_Phong.Text != "" && cbTTTP_Phong.Text != "" && txtIDLoaiPhong_Phong.Text != "")
            {
                Room ph = new Room(0, int.Parse(txtIDLoaiPhong_Phong.Text.Trim()), txtTenPhong_Phong.Text.Trim(), cbTTTP_Phong.Text.Trim(), chboxTTP_Phong.Visible);
                if (r.themPhong(ph))
                {
                    MessageBox.Show("Thêm phòng thành công");
                    dtgvRoom.DataSource = r.getPhong();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đủ thông tin");
            }
        }
        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            if (dtgvRoom.SelectedRows.Count > 0)
            {
                if (txtTenPhong_Phong.Text != "" && cbTTTP_Phong.Text != "" && txtIDLoaiPhong_Phong.Text !="" && txtIdPhong_Phong.Text !="" )
                {
                    DataGridViewRow row = dtgvRoom.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    Room ph = new Room(ID, int.Parse(txtIDLoaiPhong_Phong.Text.Trim()), txtTenPhong_Phong.Text.Trim(), cbTTTP_Phong.Text.Trim(), chboxTTP_Phong.Checked);
                    if (r.suaPhong(ph))
                    {
                        MessageBox.Show("Sửa phòng thành công");
                        dtgvRoom.DataSource = r.getPhong();
                    }
                    else
                    {
                        MessageBox.Show("Sua phòng thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đủ thông tin");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn phòng bạn muốn sửa");
            }
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Nếu xoá thông tin phòng, bạn sẽ xoá tất cả thông tin liên quan.\nBạn có thật sự muốn xoá không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (dtgvRoom.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dtgvRoom.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    //xoa
                    if (r.xoaPhong(ID))
                    {
                        MessageBox.Show("Xoá phòng thành công");
                        dtgvRoom.DataSource = r.getPhong();
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
            }
        }

        private void btnXemPhong_Click(object sender, EventArgs e)
        {
            dtgvRoom.DataSource = r.getPhong();
        }

        private void dtgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dtgvRoom.SelectedRows[0];
                txtIdPhong_Phong.Text = row.Cells[0].Value.ToString();
                txtIDLoaiPhong_Phong.Text = row.Cells[1].Value.ToString();
                txtTenPhong_Phong.Text = row.Cells[2].Value.ToString();
                cbTTTP_Phong.Text = row.Cells[4].Value.ToString();
                chboxTTP_Phong.Visible = row.Cells[3].Visible;
            }
            catch { Exception ex; }
        }
        private void btnTìmPhong_Click(object sender, EventArgs e)
        {
            if (txtTim_Phong.Text != "")
                dtgvRoom.DataSource = r.TimTheoTen(txtTim_Phong.Text.Trim());
            else
                dtgvRoom.DataSource = r.getPhong();
        }
        #endregion

        #region LoaiPhong
        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            if (txtTenLoai_LoaiPhong.Text != "" && txtMoTa_LP.Text != "" && txtSoGiuong_LP.Text != "" && txtTienGio_LP.Text != "" && txtTienNgay_LP.Text != "")
            {
                RoomType rt = new RoomType(0, txtTenLoai_LoaiPhong.Text.Trim(), txtMoTa_LP.Text.Trim(), int.Parse(txtSoGiuong_LP.Text.Trim()), float.Parse(txtTienGio_LP.Text.Trim()), float.Parse(txtTienNgay_LP.Text.Trim()));
                
                if (RoomTypeDAL.themLoaiPhong(rt))
                {
                    MessageBox.Show("Thêm loại phòng thành công");
                    dtgvLoai_LoaiPhong.DataSource = RoomTypeDAL.getLoaiPhong();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đủ thông tin");
            }
        }

        private void btnSuaLoai_Click(object sender, EventArgs e)
        {
            if (dtgvLoai_LoaiPhong.SelectedRows.Count > 0)
            {
                if (txtTenLoai_LoaiPhong.Text != "" && txtMoTa_LP.Text != "" && txtSoGiuong_LP.Text != "" && txtTienGio_LP.Text != "" && txtTienNgay_LP.Text != "" && txtIdLoai.Text != "")
                {
                    DataGridViewRow row = dtgvLoai_LoaiPhong.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    RoomType rt = new RoomType(int.Parse(txtIdLoai.Text.Trim()), txtTenLoai_LoaiPhong.Text.Trim(), txtMoTa_LP.Text.Trim(), int.Parse(txtSoGiuong_LP.Text.Trim()), float.Parse(txtTienGio_LP.Text.Trim()), float.Parse(txtTienNgay_LP.Text.Trim()));
                    if (RoomTypeDAL.suaLoaiPhong(rt))
                    {
                        MessageBox.Show("Sửa loại phòng thành công");
                        dtgvLoai_LoaiPhong.DataSource = RoomTypeDAL.getLoaiPhong();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ thông tin");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sửa");
            }
        }

        private void btnXoaLoai_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Nếu xoá thông tin loại phòng, bạn sẽ xoá tất cả thông tin liên quan.\nBạn có thật sự muốn xoá không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (dtgvLoai_LoaiPhong.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dtgvLoai_LoaiPhong.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    //xoa
                    if (RoomTypeDAL.xoaLoaiPhong(ID))
                    {
                        MessageBox.Show("Xoá loại phòng thành công");
                        dtgvLoai_LoaiPhong.DataSource = RoomTypeDAL.getLoaiPhong();
                    }
                    else
                    {
                        MessageBox.Show("Xoá thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn loại phòng muốn xoá");
                }
            }
        }

        private void dtgvLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dtgvLoai_LoaiPhong.SelectedRows[0];
                txtIdLoai.Text = row.Cells[0].Value.ToString();
                txtTenLoai_LoaiPhong.Text = row.Cells[1].Value.ToString();
                txtMoTa_LP.Text = row.Cells[2].Value.ToString();
                txtSoGiuong_LP.Text = row.Cells[3].Value.ToString();
                txtTienGio_LP.Text = row.Cells[4].Value.ToString();
                txtTienNgay_LP.Text = row.Cells[5].Value.ToString();
            }
            catch { Exception ex; }
        }
        private void btnXemLoai_Click(object sender, EventArgs e)
        {
            if (txtTenLoai_LoaiPhong.Text != "")
                dtgvLoai_LoaiPhong.DataSource = RoomTypeDAL.TimTheoTen(txtTenLoai_LoaiPhong.Text.Trim());
            else
                dtgvLoai_LoaiPhong.DataSource = RoomTypeDAL.getLoaiPhong();
        }
        #endregion

        #region DichVu
        private void dtgvDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dtgvDV.SelectedRows[0];
                txtIdDV_DV.Text = row.Cells[0].Value.ToString();
                txtTen_DV.Text = row.Cells[1].Value.ToString();
                txtidLoai_DV.Text = row.Cells[2].Value.ToString();
                txtDonVi_DV.Text = row.Cells[4].Value.ToString();
                txtDonGia_DV.Text = row.Cells[5].Value.ToString();
            }
            catch { Exception ex; }
        }
        private void btnThemDV_Click(object sender, EventArgs e)
        {
            if (txtidLoai_DV.Text != "" && txtTen_DV.Text != "" && txtDonVi_DV.Text != "" && txtDonGia_DV.Text != "")
            {
                Service s = new Service(0, int.Parse(txtidLoai_DV.Text.Trim()), txtTen_DV.Text.Trim(), txtDonVi_DV.Text.Trim(), (float)(Convert.ToDouble(txtDonGia_DV.Text.Trim())));

                if (service.themDichVu(s))
                {
                    MessageBox.Show("Thêm dịch vụ thành công");
                    dtgvDV.DataSource = service.getDV();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đủ thông tin");
            }
        }
        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            if (dtgvDV.SelectedRows.Count > 0)
            {
                if (txtIdDV_DV.Text != "" && txtidLoai_DV.Text != "" && txtTen_DV.Text != "" && txtDonVi_DV.Text != "" && txtDonGia_DV.Text != "")
                {
                    DataGridViewRow row = dtgvDV.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                    Service s = new Service(ID, int.Parse(txtidLoai_DV.Text.Trim()), txtTen_DV.Text.Trim(), txtDonVi_DV.Text.Trim(), float.Parse(txtDonGia_DV.Text.Trim()));

                    if (service.suaDichVu(s))
                    {
                        MessageBox.Show("Sửa dịch vụ thành công");
                        dtgvDV.DataSource = service.getDV();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ thông tin");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sửa");
            }
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Nếu xoá thông tin loại phòng, bạn sẽ xoá tất cả thông tin liên quan.\nBạn có thật sự muốn xoá không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (dtgvDV.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dtgvDV.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    //xoa
                    if (service.xoaDichVu(ID))
                    {
                        MessageBox.Show("Xoá dịch vụ thành công");
                        dtgvDV.DataSource = service.getDV();
                    }
                    else
                    {
                        MessageBox.Show("Xoá thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn thành viên muốn xoá");
                }
            }
        }
        private void btnXem_DV_Click(object sender, EventArgs e)
        {
            if (txtTen_DV.Text != "")
                dtgvDV.DataSource = service.TimTheoTen(txtTen_DV.Text.Trim());
            else
                dtgvDV.DataSource = service.getDV();
        }
        
        #endregion

        #region LoaiDichVu
        private void dtgvKDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dtgvKDV.SelectedRows[0];
                txtIDLoaiDV_LDV.Text = row.Cells[0].Value.ToString();
                txtTenKdv_LDV.Text = row.Cells[1].Value.ToString();
            }
            catch { Exception ex; }
        }
        private void btnThemKDV_Click(object sender, EventArgs e)
        {
            if (txtTenKdv_LDV.Text != "")
            {
                ServiceType ldv = new ServiceType(0, txtTenKdv_LDV.Text.Trim());

                if (serviceType.themLoaiDichVu(ldv))
                {
                    MessageBox.Show("Thêm loại dịch vụ thành công");
                    dtgvKDV.DataSource = serviceType.getLDV();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đủ thông tin");
            }
        }
        private void btnSuaKDV_Click(object sender, EventArgs e)
        {
            if (dtgvKDV.SelectedRows.Count > 0)
            {
                if (txtTenKdv_LDV.Text != "")
                {
                    DataGridViewRow row = dtgvKDV.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                    ServiceType ldv = new ServiceType(ID, txtTenKdv_LDV.Text.Trim());

                    if (serviceType.suaLoaiDichVu(ldv))
                    {
                        MessageBox.Show("Sửa loại dịch vụ thành công");
                        dtgvKDV.DataSource = serviceType.getLDV();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đủ thông tin");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sửa");
            }
        }

        private void btnXoaKDV_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Nếu xoá thông tin loại phòng, bạn sẽ xoá tất cả thông tin liên quan.\nBạn có thật sự muốn xoá không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (dtgvKDV.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dtgvKDV.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    //xoa
                    if (serviceType.XoaloaiDichVu(ID))
                    {
                        MessageBox.Show("Xoá loại kiểu dịch vụ thành công");
                        dtgvKDV.DataSource = serviceType.getLDV();
                    }
                    else
                    {
                        MessageBox.Show("Xoá thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Chọn thành viên muốn xoá");
                }
            }
        }

        private void btnXemKDV_Click(object sender, EventArgs e)
        {
            if (txtTenKdv_LDV.Text != "")
                dtgvKDV.DataSource = serviceType.TimTheoTen(txtTenKdv_LDV.Text.Trim());
            else
                dtgvKDV.DataSource = serviceType.getLDV();
        }
        #endregion

        #region TaiKhoan
        private void dtgvTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dtgvTK.SelectedRows[0];
                txtIdTK_TK.Text = row.Cells[0].Value.ToString();
                txtAcc_TK.Text = row.Cells[2].Value.ToString();
                txtPass_TK.Text = row.Cells[3].Value.ToString();
                txtPQTK_TK.Text = row.Cells[4].Value.ToString();
                txtMaNV_TK.Text = row.Cells[1].Value.ToString();
            }
            catch { Exception ex; }
        }
        private void btnThemTK_Click(object sender, EventArgs e)
        {
            if (txtAcc_TK.Text != "" && txtPass_TK.Text != "" && txtPQTK_TK.Text != "" && txtMaNV_TK.Text != "")
            {
                Account a = new Account(0, txtMaNV_TK.Text.Trim(), txtAcc_TK.Text.Trim(), txtPass_TK.Text.Trim(), txtPQTK_TK.Text.Trim());
                if (acc.themTaiKhoan(a))
                {
                    MessageBox.Show("Thêm tài khoản thành công");
                    dtgvTK.DataSource = acc.getTaiKhoan();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đủ thông tin");
            }
        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            if (dtgvTK.SelectedRows.Count > 0)
            {
                if (txtAcc_TK.Text != "" && txtPass_TK.Text != "" && txtPQTK_TK.Text != "" && txtMaNV_TK.Text != "" && txtIdTK_TK.Text != "")
                {
                    DataGridViewRow row = dtgvTK.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                    Account a = new Account(ID, txtMaNV_TK.Text.Trim(), txtAcc_TK.Text.Trim(), txtPass_TK.Text.Trim(), txtPQTK_TK.Text.Trim());

                    if (acc.suaTaiKhoan(a))
                    {
                        MessageBox.Show("Sửa tài khoản thành công");
                        dtgvTK.DataSource = acc.getTaiKhoan();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đủ thông tin");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sửa");
            }
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Nếu xoá thông tin loại phòng, bạn sẽ xoá tất cả thông tin liên quan.\nBạn có thật sự muốn xoá không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (dtgvTK.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dtgvTK.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    //xoa
                    if (acc.xoaTaiKhoan(ID))
                    {
                        MessageBox.Show("Xoá tài khoản thành công");
                        dtgvTK.DataSource = acc.getTaiKhoan();
                    }
                    else
                    {
                        MessageBox.Show("Xoá không thành công");
                        
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn thành viên muốn xoá");
                }
            }
         }

        private void btnXemTK_Click(object sender, EventArgs e)
        {
            if (txtAcc_TK.Text != "")
                dtgvTK.DataSource = acc.TimTaiKhoan(txtAcc_TK.Text.Trim());
            else
                dtgvTK.DataSource = acc.getTaiKhoan();
        }
        #endregion

        #region NhanVien
        private void dtgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow r = dtgvNV.SelectedRows[0];
                txtIDNV_NV.Text = r.Cells[0].Value.ToString();
                txtTKNV_NV.Text = r.Cells[1].Value.ToString();
                txtHoTenNV_NV.Text = r.Cells[2].Value.ToString();
                txtDiaChiNV_NV.Text = r.Cells[3].Value.ToString();
                txtSDTNV_NV.Text = r.Cells[4].Value.ToString();
                dtpkNSNV_NV.Text = r.Cells[5].Value.ToString();
                txtCMNDNV_NV.Text = r.Cells[6].Value.ToString();
                txtCVNV_NV.Text = r.Cells[7].Value.ToString();
            }
            catch { Exception ex; }
        }
        private void btnThem_NV_Click(object sender, EventArgs e)
        {
            if (txtHoTenNV_NV.Text != "" && txtDiaChiNV_NV.Text != "" && txtCVNV_NV.Text != "" && txtIDNV_NV.Text != "" && txtSDTNV_NV.Text != ""
                && txtCMNDNV_NV.Text != "")
            {
                Staff s = new Staff(txtIDNV_NV.Text.Trim(), txtHoTenNV_NV.Text.Trim(), txtDiaChiNV_NV.Text.Trim(), txtSDTNV_NV.Text.Trim(), dtpkNSNV_NV.Value, txtCMNDNV_NV.Text.Trim(), txtCVNV_NV.Text.Trim());
                if (staff.themNhanVien(s))
                {
                    MessageBox.Show("Thêm nhân viên thành công");
                    dtgvNV.DataSource = staff.getStaff();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đủ thông tin");
            }
        }

        private void btnSua_NV_Click(object sender, EventArgs e)
        {
            if (dtgvNV.SelectedRows.Count > 0)
            {
                if (txtHoTenNV_NV.Text != "" && txtDiaChiNV_NV.Text != "" && txtCVNV_NV.Text != "" && txtIDNV_NV.Text != "" && txtSDTNV_NV.Text != ""
                 && txtCMNDNV_NV.Text != "")
                {
                    DataGridViewRow row = dtgvNV.SelectedRows[0];
                    string ID = row.Cells[0].Value.ToString();
                    Staff s = new Staff(ID, int.Parse(txtTKNV_NV.Text.Trim()), txtHoTenNV_NV.Text.Trim(), txtDiaChiNV_NV.Text.Trim(), txtSDTNV_NV.Text.Trim(), dtpkNSNV_NV.Value, txtCMNDNV_NV.Text.Trim(), txtCVNV_NV.Text.Trim());
                    if (staff.suaNhanVien(s))
                    {
                        MessageBox.Show("Sửa nhân viên thành công");
                        dtgvNV.DataSource = staff.getStaff();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đủ thông tin");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sửa");
            }
        }

        private void btnXoa_NV_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Nếu xoá thông tin loại phòng, bạn sẽ xoá tất cả thông tin liên quan.\nBạn có thật sự muốn xoá không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (dtgvNV.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dtgvNV.SelectedRows[0];
                    string ID = row.Cells[0].Value.ToString();

                    //xoa
                    if (staff.xoaNhanVien(ID))
                    {
                        MessageBox.Show("Xoá nhân viên thành công");
                        dtgvNV.DataSource = staff.getStaff();
                    }
                    else
                    {
                        MessageBox.Show("Xoá không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn thành viên muốn xoá");
                }
            }
        }

        private void btnXem_NV_Click(object sender, EventArgs e)
        {
            if (txtHoTenNV_NV.Text != "")
                dtgvNV.DataSource = staff.TimNhanVien(txtHoTenNV_NV.Text.Trim());
            else
                dtgvNV.DataSource = staff.getStaff();
        }
        private void dtgvNV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 5) // Thay yourDateTimeColumnIndex bằng chỉ số cột datetime trong DataGridView
            {
                if (e.Value is DateTime)
                {
                    DateTime dateValue = (DateTime)e.Value;
                    e.Value = dateValue.ToString("dd/MM/yyyy"); // Thay đổi định dạng ngày giờ ở đây
                    e.FormattingApplied = true;
                }
            }
        }
        #endregion

        #region Khach
        private void dtgvKhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow r = dtgvKhach.SelectedRows[0];
                txtMaKH_KH.Text = r.Cells[0].Value.ToString();
                txtHoTen_KH.Text = r.Cells[1].Value.ToString();
                txtSDT_KH.Text = r.Cells[2].Value.ToString();
                txtCMND_KH.Text = r.Cells[3].Value.ToString();
                dtpkNS_KH.Text = r.Cells[4].Value.ToString();
            }
            catch { Exception ex; }
        }

        private void btnThem_KH_Click(object sender, EventArgs e)
        {
            if (txtHoTen_KH.Text != "" && txtSDT_KH.Text != "" && txtCMND_KH.Text != "")
            {
                Customer c = new Customer(0, txtHoTen_KH.Text.Trim(), txtSDT_KH.Text.Trim(), txtCMND_KH.Text.Trim(),
                  dtpkNS_KH.Value);

                if (customer.themKhach(c))
                {
                    MessageBox.Show("Thêm khách hàng thành công");
                    dtgvKhach.DataSource = customer.getKhach();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đủ thông tin");
            }
        }

        private void btnSua_KH_Click(object sender, EventArgs e)
        {
            if (dtgvKhach.SelectedRows.Count > 0)
            {
                if (txtHoTen_KH.Text != "" && txtSDT_KH.Text != "" && txtCMND_KH.Text != "")
                {
                    DataGridViewRow row = dtgvKhach.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                    Customer c = new Customer(ID, txtHoTen_KH.Text.Trim(), txtSDT_KH.Text.Trim(), txtCMND_KH.Text.Trim(), dtpkNS_KH.Value);
                    if (customer.suaKhach(c))
                    {
                        MessageBox.Show("Sửa khách thành công");
                        dtgvKhach.DataSource = customer.getKhach();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đủ thông tin");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sửa");
            }
        }

        private void btnXoa_KH_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Nếu xoá thông tin loại phòng, bạn sẽ xoá tất cả thông tin liên quan.\nBạn có thật sự muốn xoá không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (dtgvKhach.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dtgvKhach.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    //xoa
                    if (customer.xoaKhach(ID))
                    {
                        MessageBox.Show("Xoá khách thành công");
                        dtgvKhach.DataSource = customer.getKhach();
                    }
                    else
                    {
                        MessageBox.Show("Xoá không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn thành viên muốn xoá");
                }
            }
        }

        private void btnXem_KH_Click(object sender, EventArgs e)
        {
            if (txtHoTen_KH.Text != "")
                dtgvKhach.DataSource = customer.TimKhach(txtHoTen_KH.Text.Trim());
            else
                dtgvKhach.DataSource = customer.getKhach();
        }
        private void dtgvKhach_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 4) // Thay yourDateTimeColumnIndex bằng chỉ số cột datetime trong DataGridView
            {
                if (e.Value is DateTime)
                {
                    DateTime dateValue = (DateTime)e.Value;
                    e.Value = dateValue.ToString("dd/MM/yyyy"); // Thay đổi định dạng ngày giờ ở đây
                    e.FormattingApplied = true;
                }
            }
        }
        #endregion
    }
}