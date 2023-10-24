
using DTO;
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

namespace GUI_QLKS
{
    public partial class frmQuanLy : Form
    {
        RoomDAL r = new RoomDAL();
        public frmQuanLy()
        {
            InitializeComponent();
            loadRoom();
            LoadComboboxRoom(cbRoomFrom);
            LoadComboboxRoom(cbRoomTo);
        }

        #region method
        public void loadRoom()
        {
            flpnPhong.Controls.Clear();
            List<Room> roomList = RoomDAL.Instance.LoadRoomList();

            foreach (Room item in roomList)
            {
                Button btn = new Button() { Width = RoomDAL.TableWidth, Height = RoomDAL.TableHeight };
                btn.Text = "Phòng " +  item.Ten + Environment.NewLine  + item.TrangThai;
                btn.Click+= btn_Click; 
                btn.Tag = item;
                btn.TextAlign = ContentAlignment.MiddleCenter;


                switch (item.TrangThai.Trim())
                {
                    case "Co":
                        btn.BackColor = Color.LightPink;
                        break;
                    case "Book":
                        btn.BackColor = Color.LightGreen;
                        break;
                    default:
                        btn.BackColor = Color.LightBlue;
                        break;
                }
                
                flpnPhong.Controls.Add(btn);
            }
        }
        void LoadComboboxRoom(ComboBox cb)
        {
            cb.DataSource = RoomDAL.Instance.LoadRoomList();
            cb.DisplayMember = "Ten";
        }
        #endregion


        #region Events


        void btn_Click(object sender, EventArgs e)
        {
            int id = ((sender as Button).Tag as Room).ID;

            string ten = ((sender as Button).Tag as Room).Ten;

            this.Hide();
            frmThue frmThue = new frmThue();
            frmThue.SetButtonID(id,ten);
            frmThue.ShowDialog();

            this.Close();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fadmin admin = new fadmin();
            admin.ShowDialog();
            this.Close();
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            frmLog f = new frmLog();
            lbTenDangNhap.Text = f.Ten();
            loadRoom();
        }

        private void quảnLýThuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLyThue thue = new frmQuanLyThue();
            thue.ShowDialog();
            this.Close();
        }

       
        #endregion

        private void frmQuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnResetRoom_Click(object sender, EventArgs e)
        {
            loadRoom();
        }

        private void btnChuyenPhong_Click(object sender, EventArgs e)
        {
            int id1 = (cbRoomFrom.SelectedItem as Room).ID;
            int id2 = (cbRoomTo.SelectedItem as Room).ID;
            if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển phòng {0} qua phòng {1}", (cbRoomFrom.SelectedItem as Room).Ten, (cbRoomTo.SelectedItem as Room).Ten),"Thông báo",MessageBoxButtons.OKCancel)==System.Windows.Forms.DialogResult.OK)
            {
                RoomDAL.Instance.DoiPhong(id1, id2);
                loadRoom();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLog log = new frmLog();
            log.ShowDialog();
            this.Close();
        }
    }
}
