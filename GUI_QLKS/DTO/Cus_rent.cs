using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Cus_rent
    {
        private int _mhd;
        private string _nameRoom;
        private string _nameCus;
        private DateTime _checkIn;
        private DateTime _checkOut;
        private float _dongia;
        private int _ngayo;
        private float _tong;

        public int Mhd { get => _mhd; set => _mhd = value; }
        public string NameRoom { get => _nameRoom; set => _nameRoom = value; }
        public string NameCus { get => _nameCus; set => _nameCus = value; }
        public DateTime CheckIn { get => _checkIn; set => _checkIn = value; }
        public DateTime CheckOut { get => _checkOut; set => _checkOut = value; }
        public float Dongia { get => _dongia; set => _dongia = value; }
        public int Ngayo { get => _ngayo; set => _ngayo = value; }
        public float Tong { get => _tong; set => _tong = value; }

        public Cus_rent() { }

        public Cus_rent(DataRow r)
        {
            this.Mhd = (int)r["MAHOADON"];
            this.NameRoom = r["TEN"].ToString();
            this.NameCus = r["HOTEN"].ToString();
            this.CheckIn = (DateTime)r["CHECK_IN"];
            this.CheckOut = (DateTime)r["CHECK_OUT"];
            this.Dongia = (float)Convert.ToDouble(r["TINHTHEONGAY"].ToString());
            this.Ngayo = (int)r["NGAYO"];
            this.Tong = (float)Convert.ToDouble(r["TONGTIEN"].ToString());
        }
    }
}
