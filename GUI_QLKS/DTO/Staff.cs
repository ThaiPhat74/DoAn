using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Staff
    {
        private string _maNV;
        private int _maTK;
        private string _hoTen;
        private string _diaChi;
        private string _sdt;
        private DateTime _ns;
        private string _cmnd;
        private string _chucVu;

        public string MaNV { get => _maNV; set => _maNV = value; }
        public int MaTK { get => _maTK; set => _maTK = value; }
        public string HoTen { get => _hoTen; set => _hoTen = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public string Sdt { get => _sdt; set => _sdt = value; }
        public DateTime Ns { get => _ns; set => _ns = value; }
        public string Cmnd { get => _cmnd; set => _cmnd = value; }
        public string ChucVu { get => _chucVu; set => _chucVu = value; }

        public Staff() { }  

        public Staff(string maNV, int maTK, string hoTen, string diaChi, string sdt, DateTime ns, string cmnd, string chucVu)
        {
            this.MaNV = maNV;
            this.MaTK = maTK;
            this.HoTen = hoTen;
            this.DiaChi = diaChi;
            this.Sdt = sdt;
            this.Ns = ns;
            this.Cmnd = cmnd;
            this.ChucVu = chucVu;
        }
        public Staff(string maNV, string hoTen, string diaChi, string sdt, DateTime ns, string cmnd, string chucVu)
        {
            this.MaNV = maNV;
            this.HoTen = hoTen;
            this.DiaChi = diaChi;
            this.Sdt = sdt;
            this.Ns = ns;
            this.Cmnd = cmnd;
            this.ChucVu = chucVu;
        }
    }
}
