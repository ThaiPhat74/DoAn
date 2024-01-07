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
    public partial class frmLog : Form
    {
        public frmLog()
        {
            InitializeComponent();
        }

        private void frmLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if(MessageBox.Show("Bạn có muốn thoát","Thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            //{
            //    e.Cancel = true;
            //}    
        }
        public bool Login(string user,string pass)
        {
                
            return AccountDAL.Instance.Login(user,pass);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Login(txtAcc.Text,txtPass.Text))
            {
                this.Hide();
                frmQuanLy fql = new frmQuanLy();
                fql.setName(txtAcc.Text.Trim());
                fql.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel);
            //if(result == DialogResult.OK) 
            //{
            //    Application.Exit();
            //}
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnLogin_Click(sender, null);
        }
    }
}
