using DAL_QLKS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLKS
{
    public partial class frmThanhToan : Form
    {
        ThuePhongDAL tp = new ThuePhongDAL();
        BillDAL bill = new BillDAL();
        public frmThanhToan()
        {
            InitializeComponent();
            
        }
        void load()
        {
            dtgvBillTong.DataSource = bill.getHoaDonByID(int.Parse(txtHD_TT.Text));
        }
        public void setID(int id)
        {
            txtHD_TT.Text = id.ToString();
            loadUOS(id);
            loadRent(id);
            addBinDing();
        }
        private void dtgvBillTong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 4 || e.ColumnIndex == 5) // Thay yourDateTimeColumnIndex bằng chỉ số cột datetime trong DataGridView
            {
                if (e.Value is DateTime)
                {
                    DateTime dateValue = (DateTime)e.Value;
                    e.Value = dateValue.ToString("dd/MM/yyyy HH:mm:ss"); // Thay đổi định dạng ngày giờ ở đây
                    e.FormattingApplied = true;
                }
            }
        }

        private void frmThanhToan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            frmQuanLy frm = new frmQuanLy();
            //frm.ShowDialog();
            frm.loadRoom();
            this.Close();
        }

        private void btnCO_Bill_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvBillTong.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dtgvBillTong.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                    Rent r = new Rent(ID, int.Parse(txtMP_Bill.Text));
                    if (tp.checkOut(r))
                    {
                        MessageBox.Show("Check out thành công");
                        load();
                    }
                    else
                    {
                        MessageBox.Show("Check out thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn hoá đơn muốn check out");
                }
            }

            catch { Exception ex; }
        }

        void addBinDing()
        {
            BindingSource source1 = new BindingSource();
            source1.DataSource = bill.getHoaDonByID(int.Parse(txtHD_TT.Text));
            dtgvBillTong.DataSource = source1;
            bingdingBill.BindingSource = source1;
            txtHD_TT.DataBindings.Add(new Binding("Text", dtgvBillTong.DataSource, "MAHOADON"));
            txtMP_Bill.DataBindings.Add(new Binding("Text", dtgvBillTong.DataSource, "MAPHONG"));
            nbDis.DataBindings.Add(new Binding("Text", dtgvBillTong.DataSource, "DISCOUNT"));
            txtTongTien.DataBindings.Add(new Binding("Text", dtgvBillTong.DataSource, "TONG"));
        }
        private void dtgvBillTong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dtgvBillTong.SelectedRows[0];
                txtHD_TT.Text = row.Cells[0].Value?.ToString();
                txtMP_Bill.Text = row.Cells[2].Value?.ToString();
                txtTongTien.Text = row.Cells[6].Value?.ToString();
                nbDis.Value = int.Parse(row.Cells[9].Value?.ToString());
            }
            catch { Exception ex; }
        }

        private void btnTT_Bill_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(string.Format("Bạn hãy check out phòng {0} trước khi thanh toán?",txtMP_Bill.Text), "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (txtTongTien.Text != "")
                {
                    if (dtgvBillTong.SelectedRows.Count > 0)
                    {
                        DataGridViewRow row = dtgvBillTong.SelectedRows[0];
                        int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                        Rent r = new Rent(ID, int.Parse(txtMP_Bill.Text));
                        //xoa
                        if (tp.ThanhToan(r))
                        {
                            MessageBox.Show("Thanh toán thành công");
                            load();
                        }
                        else
                        {
                            MessageBox.Show("Thanh toán khong thanh cong");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hãy chọn hoá đơn muốn thanh toán");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng check out!");
                }    
            }
        }

        private void btnDis_Click(object sender, EventArgs e)
        {
            if (dtgvBillTong.SelectedRows.Count > 0)
            {
                if (txtHD_TT.Text != "" && nbDis.Value >=0 && nbDis.Value <=100)
                {
                    DataGridViewRow row = dtgvBillTong.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    Bill b = new Bill(ID, float.Parse(nbDis.Value.ToString()));
                    if (bill.disCount(b))
                    {
                        MessageBox.Show("Giảm giá thành công");
                        load();
                    }
                    else
                    {
                        MessageBox.Show("Giảm giá không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ thông tin");
                }
            }
        }
        void loadUOS(int i)
        {
            listUO.Items.Clear();
            List<BillInfo> listBI = BillInfoDAL.Instance.getListBillInfoByBill(i);
            float totalPrice = 0;
            foreach (BillInfo billinfo in listBI)
            {
                ListViewItem listViewItem = new ListViewItem(billinfo.IdBill.ToString());
                listViewItem.SubItems.Add(billinfo.Name.ToString());
                listViewItem.SubItems.Add(billinfo.SoLuong.ToString());
                listViewItem.SubItems.Add(billinfo.DonViTinh.ToString());
                listViewItem.SubItems.Add(billinfo.DonGia.ToString());
                totalPrice += billinfo.TongTien;
                listUO.Items.Add(listViewItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txttotalUOS.Text = totalPrice.ToString();
        }
        void loadRent(int i)
        {
            listRent.Items.Clear();
            List<Cus_rent> listCusRent = CusRentInfoDAL.Instance.getListCusRentByBill(i);
            float totalPrice = 0;
            foreach (Cus_rent CusRent in listCusRent)
            {
                ListViewItem listViewItem2 = new ListViewItem(CusRent.Mhd.ToString());
                listViewItem2.SubItems.Add(CusRent.NameRoom.ToString());
                listViewItem2.SubItems.Add(CusRent.NameCus.ToString());
                listViewItem2.SubItems.Add(CusRent.CheckIn.ToString("dd/MM/yyyy"));
                listViewItem2.SubItems.Add(CusRent.CheckOut.ToString("dd/MM/yyyy"));
                listViewItem2.SubItems.Add(CusRent.Dongia.ToString());
                listViewItem2.SubItems.Add(CusRent.Ngayo.ToString());
                totalPrice += CusRent.Tong;
                listRent.Items.Add(listViewItem2);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTongPhong.Text = totalPrice.ToString();
        }

        private void btnCOBB_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvBillTong.SelectedRows.Count > 0 )
                {
                    if(txtTongTien.Text == "")
                    {
                        DataGridViewRow row = dtgvBillTong.SelectedRows[0];
                        int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                        Rent r = new Rent(ID, int.Parse(txtMP_Bill.Text));
                        if (tp.checkOutByBill(r))
                        {
                            MessageBox.Show("Check out thành công");
                            load();
                        }
                        else
                        {
                            MessageBox.Show("Check out thất bại");
                        }
                    }    
                    else
                    {
                        MessageBox.Show("Hoá đơn này đã được check Out");
                    }    
                }
                else
                {
                    MessageBox.Show("Hãy chọn hoá đơn muốn check out");
                }
            }

            catch { Exception ex; }
        }
    }
}
