using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UOService
    {
        private int _maHD;
        private int _maDV;
        private int _soLuong;

        public int MaHD { get => _maHD; set => _maHD = value; }
        public int MaDV { get => _maDV; set => _maDV = value; }
        public int SoLuong { get => _soLuong; set => _soLuong = value; }

        public UOService() { }
        public UOService(int maHD, int maDV, int soLuong)
        {
            this.MaHD = maHD;
            this.MaDV = maDV;
            this.SoLuong = soLuong;
        }
        public UOService(DataRow r)
        {
            this.MaHD = (int)r["MAHOADON"];
            this.MaDV = (int)r["MADICHVU"];
            this.SoLuong = (int)r["SOLUONG"];
        }
    }
}
