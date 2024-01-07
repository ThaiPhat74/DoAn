using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Service
    {
        private int _mdv;
        private int _mldv;
        private string _ten;
        private string _donvitinh;
        private float _thanhTien;
        private bool _status;
        public int Mdv { get => _mdv; set => _mdv = value; }
        public int Mldv { get => _mldv; set => _mldv = value; }
        public string Ten { get => _ten; set => _ten = value; }
        public string Donvitinh { get => _donvitinh; set => _donvitinh = value; }
        public float ThanhTien { get => _thanhTien; set => _thanhTien = value; }
        public bool Status { get => _status; set => _status = value; }

        public Service() { }
        public Service(int madv,int maldv,string t,string dvt,float tt,bool st)
        {
            this.Mdv = madv;
            this.Mldv = maldv;
            this.Ten = t;
            this.Donvitinh = dvt;
            this.ThanhTien = tt;
            this.Status = st;
        }
        public Service(DataRow r)
        {
            this.Mdv = (int)r["MADICHVU"];
            this.Mldv = (int)r["MALDV"];
            this.Ten = r["TEN"].ToString();
            this.Donvitinh = r["DONVITINH"].ToString();
            this.ThanhTien = (float)Convert.ToDouble(r["THANHTIEN"].ToString());
            this.Status = (bool)r["STATUS"];
        }
    }
}
