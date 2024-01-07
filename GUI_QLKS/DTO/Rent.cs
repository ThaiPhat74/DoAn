using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Rent
    {
        private int iDKhach;
        private int iDPhong;
        private int iDHD;
        private DateTime cI;
        private DateTime cO;
        private string pay;
        private string note;

        public int IDKhach { get => iDKhach; set => iDKhach=value; }
        public int IDPhong { get => iDPhong; set => iDPhong=value; }
        public DateTime CI { get => cI; set => cI=value; }
        public DateTime CO { get => cO; set => cO=value; }
        public string Pay { get => pay; set => pay=value; }
        public string Note { get => note; set => note = value; }
        public int IDHD { get => iDHD; set => iDHD = value; }

        public Rent() { }
        public Rent(int idHD,int idKhach,int idPhong,DateTime ci,DateTime co,string pay,string note) 
        {
            this.IDHD = idHD;
            this.IDKhach=idKhach;
            this.IDPhong=idPhong;
            this.CI=ci;
            this.CO=co;
            this.pay=pay;  
            this.note=note;
        }
        public Rent( int idKhach, int idPhong, DateTime ci, DateTime co, string pay, string note)
        {
            this.IDKhach = idKhach;
            this.IDPhong = idPhong;
            this.CI = ci;
            this.CO = co;
            this.pay = pay;
            this.note = note;
        }
        public Rent( int idPhong, DateTime ci, DateTime co, string pay, string note)
        {
            this.IDPhong = idPhong;
            this.CI = ci;
            this.CO = co;
            this.pay = pay;
            this.note = note;
        }
        public Rent(DataRow r)
        {
            this.IDHD = (int)r["MAHOADON"];
            this.IDKhach=(int)r["MAKHACH"];
            this.IDPhong=(int)r["MAPHONG"];
            this.CI=(DateTime)r["CHECK_IN"];
            var dateCheckInTemp = r["CHECK_IN"];
            if (dateCheckInTemp != null)
            {
                this.CI=(DateTime)dateCheckInTemp;
            }
            var dateCheckOutTemp = r["CHECK_OUT"];
            if(dateCheckOutTemp != null) 
            {
                this.CO = (DateTime)dateCheckOutTemp;
            }
            this.pay=(string)r["THANHTOAN"];
            this.note = (string)r["GHICHU"];
        }
        public Rent(int idHD, int idPhong)
        {
            this.IDHD =idHD;
            this.IDPhong =idPhong;
        }
        public Rent(string pay)
        {
            this.pay=pay;
        }
    }
}
