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
            load();
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
            frm.ShowDialog();
            this.Close();
        }

        private void btnCO_Bill_Click(object sender, EventArgs e)
        {
            if (dtgvBillTong.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgvBillTong.SelectedRows[0];
                int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                Rent r = new Rent(ID, int.Parse(txtMP_Bill.Text));
                //xoa
                if (tp.checkOut(r))
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

        void addBinDing()
        {
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
                txtHD_TT.Text = row.Cells[0].Value.ToString();
                txtMP_Bill.Text = row.Cells[2].Value.ToString();
                txtTongTien.Text = row.Cells[6].Value.ToString();
                nbDis.Value = int.Parse(row.Cells[9].Value.ToString());
            }
            catch { Exception ex; }
        }

        private void btnTT_Bill_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(string.Format("Bạn hãy check out phòng {0} trước khi thanh toán?",txtMP_Bill.Text), "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK && txtTongTien.Text != "")
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
                    MessageBox.Show("Xin hãy nhập đầy đủ thông tin" +
                        "");
                }
            }
        }
    }
}
