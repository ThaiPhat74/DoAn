using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Bill
    {
        private int _idBill;
        private DateTime _ngayIn;
        private float _tongTien;
        private int _idPhong;
        private int _idDT;
        private string _note;
        private int _idTK;
        private float _discount;

        public int IdBill { get => _idBill; set => _idBill = value; }
        public DateTime NgayIn { get => _ngayIn; set => _ngayIn = value; }
        public float TongTien { get => _tongTien; set => _tongTien = value; }
        public int IdPhong { get => _idPhong; set => _idPhong = value; }
        public int IdDT { get => _idDT; set => _idDT = value; }
        public string Note { get => _note; set => _note = value; }
        public int IdTK { get => _idTK; set => _idTK = value; }
        public float Discount { get => _discount; set => _discount = value; }

        public Bill() { }

        public Bill(int id, int idphong, int iddt, int idtk, DateTime ngayin, string note, float tong, float discount)
        {
            this.IdBill = id;
            this.IdDT = iddt;
            this.IdPhong = idphong;
            this.IdTK = idtk;
            this.NgayIn = ngayin;
            this.TongTien = tong;
            this.Note = note;
            this.Discount = discount;
        }
        public Bill(DataRow r)
        {
            this._idBill = (int)r["MAHOADON"];
            this._idPhong = (int)r["MAPHONG"];
            this._idDT = (int)r["MADOANHTHU"];
            this._idTK = (int)r["MATAIKHOAN"];
            this._ngayIn = (DateTime)r["NGAYIN"];
            this._note = (string)r["GHICHU"];
            this._discount = (float)Convert.ToDouble(r["DISCOUNT"].ToString());
            this._tongTien = (float)r["TONG"];
        }
        public Bill(int id,float dis)
        {
            this.IdBill = id;
            this.Discount = dis;
        }
    }
}
