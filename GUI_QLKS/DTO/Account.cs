using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        private int _maTaiKhoan;
        private string _maNhanVien;
        private string _tenDangNhap;
        private string _matKhau;
        private string _phanQuyen;

        public int MaTaiKhoan { get => _maTaiKhoan; set => _maTaiKhoan = value; }
        public string MaNhanVien { get => _maNhanVien; set => _maNhanVien = value; }
        public string TenDangNhap { get => _tenDangNhap; set => _tenDangNhap = value; }
        public string MatKhau { get => _matKhau; set => _matKhau = value; }
        public string PhanQuyen { get => _phanQuyen; set => _phanQuyen = value; }

        public Account() { }
        public Account(int maTK, string maNV,string tenDN,string mk,string phanQuyen )
        {
            this.MaTaiKhoan= maTK;
            this.MaNhanVien = maNV;
            this.TenDangNhap= tenDN;
            this.MatKhau= mk;
            this.PhanQuyen= phanQuyen;
        }
        public Account( string maNV, string tenDN, string mk, string phanQuyen)
        {
            this.MaNhanVien = maNV;
            this.TenDangNhap = tenDN;
            this.MatKhau = mk;
            this.PhanQuyen = phanQuyen;
        }

        public Account(string tenDN,string mk)
        {
            this.TenDangNhap = tenDN;
            this.MatKhau = mk;  
        }
    }
}
