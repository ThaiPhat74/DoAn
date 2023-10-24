using DAL_QLKS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI_QLKS
{
    public partial class frmQuanLyThue : Form
    {
        public frmQuanLyThue()
        {
            InitializeComponent();
            load();
            customDTPK();
        }
        ThuePhongDAL thue = new ThuePhongDAL();
        BillDAL bill = new BillDAL();
        SaleDAL sale = new SaleDAL();   
        UOServiceDAL uos = new UOServiceDAL();

        void customDTPK()
        {
            
            dtpkNgayIn_Bill.Format = DateTimePickerFormat.Custom;
            dtpkNgayIn_Bill.CustomFormat = "dd/MM/yyyy";
            dtpkFrom.Format = DateTimePickerFormat.Custom;
            dtpkFrom.CustomFormat = "dd/MM/yyyy";
            dtpkTo.Format = DateTimePickerFormat.Custom;
            dtpkTo.CustomFormat = "dd/MM/yyyy";
            dtpkCI_TP.Format = DateTimePickerFormat.Custom;
            dtpkCI_TP.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            dtpkCO_TP.Format = DateTimePickerFormat.Custom;
            dtpkCO_TP.CustomFormat = "dd/MM/yyyy hh:mm:ss";
        }
        
        private void frmQuanLyThue_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmQuanLy f = new frmQuanLy();
            this.Hide();
            f.ShowDialog();
            f = null;
            this.Close();
        }

        void load()
        {
            dtgvThue.DataSource = thue.getRent();
            dtgvBill.DataSource = bill.getAllHoaDon();
            dtgvSale.DataSource = sale.getDoanhThu();
            dtgvUODV.DataSource = uos.getUOService();
            
        }
        #region ThongKe
        private void btnTK_Click(object sender, EventArgs e)
        {
            dtgvSale.DataSource = sale.ThongKeAdenB(dtpkFrom.Value,dtpkTo.Value);

        }
        private void dtgvSale_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 2) // Thay yourDateTimeColumnIndex bằng chỉ số cột datetime trong DataGridView
            {
                if (e.Value is DateTime)
                {
                    DateTime dateValue = (DateTime)e.Value;
                    e.Value = dateValue.ToString("dd/MM/yyyy HH:mm:ss"); // Thay đổi định dạng ngày giờ ở đây
                    e.FormattingApplied = true;
                }
            }
        }
        #endregion

        #region HoaDon
        private void dtgvBill_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 3) // Thay yourDateTimeColumnIndex bằng chỉ số cột datetime trong DataGridView
            {
                if (e.Value is DateTime)
                {
                    DateTime dateValue = (DateTime)e.Value;
                    e.Value = dateValue.ToString("dd/MM/yyyy HH:mm:ss"); // Thay đổi định dạng ngày giờ ở đây
                    e.FormattingApplied = true;
                }
            }
        }
        private void btnTim_Bill_Click(object sender, EventArgs e)
        {
            if (txtTim_Bill.Text != "")
                dtgvBill.DataSource = bill.getHoaDonByID2(int.Parse(txtTim_Bill.Text));
            else
                dtgvBill.DataSource = bill.getAllHoaDon();
        }

        #endregion

        #region ThuePhong
        private void dtgvThue_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 3 || e.ColumnIndex == 4) // Thay yourDateTimeColumnIndex bằng chỉ số cột datetime trong DataGridView
            {
                if (e.Value is DateTime)
                {
                    DateTime dateValue = (DateTime)e.Value;
                    e.Value = dateValue.ToString("dd/MM/yyyy HH:mm:ss"); // Thay đổi định dạng ngày giờ ở đây
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnTim_TP_Click(object sender, EventArgs e)
        {
            if (txtTimTP.Text != "")
                dtgvThue.DataSource = thue.TimTheoTen2(txtTimTP.Text);
            else
                dtgvThue.DataSource = thue.getRent();
        }


        #endregion

        #region SuDungDichVu
        private void btnTim_SDDV_Click(object sender, EventArgs e)
        {
            if (txtTim_SDDV.Text != "")
                dtgvUODV.DataSource = uos.getUOSByID(txtTim_SDDV.Text);
            else
                dtgvUODV.DataSource = uos.getUOService();
        }
        #endregion

        private void dtgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dtgvBill.SelectedRows[0];
                txtIdBill.Text = row.Cells[0].Value.ToString();
                txtMDT_Bill.Text = row.Cells[1].Value.ToString();
                txtMaDN.Text = row.Cells[2].Value.ToString();
                dtpkNgayIn_Bill.Text = row.Cells[3].Value.ToString();
                txtNote_Bill.Text = row.Cells[4].Value.ToString();
                txtTongTien_Bill.Text = row.Cells[5].Value.ToString();
                ckbTT.Visible = row.Cells[6].Visible;
                txtDiscount.Text = row.Cells[7].Value.ToString();
            }
            catch { Exception ex; }
        }

        private void btnDel_Bill_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Nếu xoá thông tin hoá đơn, bạn sẽ xoá tất cả thông tin liên quan.\nBạn có thật sự muốn xoá không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (dtgvBill.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dtgvBill.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    //xoa
                    if (bill.xoaHd(ID))
                    {
                        MessageBox.Show("Xoá hoá đơn thành công");
                        dtgvBill.DataSource = bill.getAllHoaDon();
                    }
                    else
                    {
                        MessageBox.Show("Xoá không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn hoá đơn muốn xoá");
                }
            }
        }

        private void frmQuanLyThue_Load(object sender, EventArgs e)
        {
        }
    }
}
