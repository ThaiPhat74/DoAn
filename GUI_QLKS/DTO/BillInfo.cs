using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

 namespace DTO
{
    public class BillInfo
    {
        private int _idBill;
        private string _name;
        private int _soLuong;
        private string _donViTinh;
        private float _donGia;
        private float _tongTien;

        public int IdBill { get => _idBill; set => _idBill = value; }
        public string Name { get => _name; set => _name = value; }
        public int SoLuong { get => _soLuong; set => _soLuong = value; }
        public string DonViTinh { get => _donViTinh; set => _donViTinh = value; }
        public float DonGia { get => _donGia; set => _donGia = value; }
        public float TongTien { get => _tongTien; set => _tongTien = value; }
        
        public BillInfo() { }   
        public BillInfo(int idBill,string name, int soluong, string donvitinh,float dongia,float tongia = 0)
        {
            this.IdBill= idBill;
            this.Name = name;
            this.SoLuong= soluong;
            this.DonViTinh= donvitinh;
            this.DonGia= dongia;
        }
        public BillInfo(DataRow r)
        {
            this.IdBill = (int)r["MAHOADON"];
            this.Name = r["TEN"].ToString();
            this.SoLuong = (int)r["SOLUONG"];
            this.DonViTinh = r["DONVITINH"].ToString();
            this.DonGia = (float)Convert.ToDouble(r["THANHTIEN"].ToString());
            this.TongTien = (float)Convert.ToDouble(r["TongTien"].ToString());
        }
    }
}
