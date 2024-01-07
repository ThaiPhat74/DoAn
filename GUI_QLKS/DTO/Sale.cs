using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sale
    {
        private int _maDoanhThu;
        private float _tongTien;
        private DateTime _ngay;

        public int MaDoanhThu { get => _maDoanhThu; set => _maDoanhThu = value; }
        public float TongTien { get => _tongTien; set => _tongTien = value; }
        public DateTime Ngay { get => _ngay; set => _ngay = value; }

        public Sale() { }   
        public Sale(int maDoanhThu, float tongTien, DateTime ngay)
        {
            this.MaDoanhThu = maDoanhThu;
            this.TongTien = tongTien;
            this.Ngay = ngay;
        }
        public Sale( float tongTien, DateTime ngay)
        {
            this.TongTien = tongTien;
            this.Ngay = ngay;
        }
    }
}
