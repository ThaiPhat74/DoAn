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
            if(MessageBox.Show("Bạn có muốn thoát","Thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtAcc.Text;
            string passWord = txtPass.Text;
            if (Login(userName,passWord))
            {
                this.Hide();
                frmQuanLy fql = new frmQuanLy();
                fql.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }    
        }
        bool Login(string userName,string passWord)
        {
            return AccountDAL.Instance.Login(userName,passWord);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK) 
            {
                Application.Exit();
            }
        }
        public string Ten()
        {
            string t = txtAcc.Text;
            return t;
        }
    }
}
