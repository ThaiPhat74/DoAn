using DAL_QLKS;
using DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLKS
{
    public partial class frmSuDungDichVu : Form
    {
        UOServiceDAL uod = new UOServiceDAL();
        BillDAL b = new BillDAL();
        public frmSuDungDichVu()
        {
            InitializeComponent();
            loadServiceType();
        }

        void load(int i)
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
            txtTotal.Text = totalPrice.ToString("c",culture);
        }
        public void setID(int id)
        {
            txtHD_SDDV.Text = id.ToString();
            load(id);
        }
        void loadServiceType()
        {
            List<ServiceType> ListServiceTypes = ServiceTypeDAL.Instance.GetlistST();
            cbDanhMuc.DataSource = ListServiceTypes;
            cbDanhMuc.DisplayMember = "Name";
        }
        void loadServiceByServiceTypeID(int ID)
        {
            List<Service> ListService = ServiceDAL.Instance.ListServiceByServiceType(ID);
            cbDichVu.DataSource = ListService;
            cbDichVu.DisplayMember= "TEN";
        }
       
        private void cbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
            {
                return;
            }
            ServiceType serviceType = cb.SelectedItem as ServiceType;
            id = serviceType.Mldv;
            loadServiceByServiceTypeID(id);

            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int idDV = (cbDichVu.SelectedItem as Service).Mdv;
            if (txtHD_SDDV.Text != ""  && nbSL.Value != 0 )
            {
                UOService uos = new UOService(int.Parse(txtHD_SDDV.Text), idDV, (int)nbSL.Value);

                if (uod.ThemUOS(uos))
                {
                    MessageBox.Show("Thêm dịch vụ thành công");
                    load(int.Parse(txtHD_SDDV.Text));
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

        private void frmSuDungDichVu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            frmQuanLy frm = new frmQuanLy();
            this.Close();
            frm.loadRoom();
        }

        
    }
}
