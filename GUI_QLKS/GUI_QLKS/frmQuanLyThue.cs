using DAL_QLKS;
using DAO;
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
        void load()
        {
            BindingSource source1 = new BindingSource();
            source1.DataSource = thue.getRent();
            dtgvThue.DataSource = source1;
            bindingRent.BindingSource = source1;


            BindingSource source2 = new BindingSource();
            source2.DataSource = bill.getAllHoaDon();
            dtgvBill.DataSource = source2;
            bindingBill.BindingSource = source2;


            BindingSource source3 = new BindingSource();
            source3.DataSource = sale.getDoanhThu();
            dtgvSale.DataSource = source3;
            bingdingReport.BindingSource = source3;


            BindingSource source4 = new BindingSource();
            source4.DataSource = uos.getUOService();
            dtgvUODV.DataSource = source4;
            bindingUOS.BindingSource = source4;

        }
        #region ThongKe
        private void btnTK_Click(object sender, EventArgs e)
        {
            LoadFullReport(dtpkFrom.Value, dtpkTo.Value);
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

        private DataTable GetFulReport(DateTime from, DateTime to)
        {
            return SaleDAL.Instance.ThongKeAdenB(from, to);
        }

        private void LoadFullReport(DateTime from, DateTime to)
        {
            this.dtpkFrom.Value = from;
            this.dtpkTo.Value = to;
            DataTable table = GetFulReport(from, to);
            BindingSource source = new BindingSource();
            //ChangePrice(table);
            source.DataSource = table;
            dtgvSale.DataSource = source;
            bingdingReport.BindingSource = source;
            DrawChart(source);
            GC.Collect();
        }
        private void DrawChart(BindingSource source)
        {
            reportChar.DataSource = source;
            reportChar.DataBind();
            reportChar.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM";
            foreach (DataPoint item in reportChar.Series[0].Points)
            {
                if (item.YValues[0] == 0)
                {
                    item.Label = " ";
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
            if (txtTimTP.Text != "" && txtTimTP_id.Text =="")
                dtgvThue.DataSource = thue.TimTheoTen2(txtTimTP.Text);
            else if (txtTimTP_id.Text != "" && txtTimTP.Text == "")
                dtgvThue.DataSource = thue.TimTheoIdBill(int.Parse(txtTimTP_id.Text));
            else
                dtgvThue.DataSource = thue.getRent();
        }


        #endregion

        #region SuDungDichVu
        private void btnTim_SDDV_Click(object sender, EventArgs e)
        {
            if (txtTim_SDDV.Text != "" && txtTimSDDV_ID.Text == "")
                dtgvUODV.DataSource = uos.getUOSByName(txtTim_SDDV.Text);
            else if (txtTimSDDV_ID.Text != "" && txtTim_SDDV.Text == "")
                dtgvUODV.DataSource = uos.getUOSByID(int.Parse(txtTimSDDV_ID.Text));
            else
                dtgvUODV.DataSource = uos.getUOService();
        }
        #endregion

        private void dtgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dtgvBill.SelectedRows[0];
                txtIdBill.Text = row.Cells[0].Value?.ToString();
                txtMDT_Bill.Text = row.Cells[1].Value?.ToString();
                txtMaDN.Text = row.Cells[2].Value?.ToString();
                dtpkNgayIn_Bill.Text = row.Cells[3].Value?.ToString();
                txtNote_Bill.Text = row.Cells[4].Value?.ToString();
                txtTongTien_Bill.Text = row.Cells[5].Value?.ToString();
                ckbTT.Visible = row.Cells[6].Visible;
                txtDiscount.Text = row.Cells[7].Value?.ToString();
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

        private void btnExcel_Click(object sender, EventArgs e)
        {
            saveReport.FileName = "Doanh thu tháng " + dtpkFrom.Value + '-' + dtpkTo.Value;
            if (saveReport.ShowDialog() == DialogResult.Cancel)
                return;
            else
            {
                bool check;
                try
                {
                    switch (saveReport.FilterIndex)
                    {
                        case 2:
                            check = ExportToExcel.Instance.Export(dtgvSale, saveReport.FileName, ModeExportToExcel.XLSX);
                            break;
                        case 3:
                            check = ExportToExcel.Instance.Export(dtgvSale, saveReport.FileName, ModeExportToExcel.PDF);
                            break;
                        default:
                            check = ExportToExcel.Instance.Export(dtgvSale, saveReport.FileName, ModeExportToExcel.XLS);
                            break;
                    }
                    if (check)
                        MessageBox.Show("Xuất thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Lỗi xuất thất bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    MessageBox.Show("Lỗi (Cần cài đặt Office)", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       
    }
}
