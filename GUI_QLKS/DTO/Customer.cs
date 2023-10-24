using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Customer
    {
        private int _id;
        private string _name;
        private string _sdt;
        private string _cmnd;
        private DateTime _ns;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Sdt { get => _sdt; set => _sdt = value; }
        public string Cmnd { get => _cmnd; set => _cmnd = value; }
        public DateTime Ns { get => _ns; set => _ns = value; }

        public Customer() { }
        public Customer(int id,string ten,string sdt,string cmnd,DateTime ns)
        {
            this.Id = id;
            this.Name = ten;
            this.Sdt = sdt;
            this.Cmnd = cmnd;
            this.Ns = ns;
        }
        public Customer( string ten, string sdt,  string cmnd,DateTime ns)
        {
            this.Name = ten;
            this.Sdt = sdt;
            this.Cmnd = cmnd;
            this.Ns=ns;
        }
        public Customer(DataRow row)
        {
            this.Id = (int)row["MAKHACH"];
            this.Name = (string)row["HOTEN"];
            this.Sdt = (string)row["SDT"];
            this.Cmnd = (string)row["CMND"];
            this.Ns = (DateTime)row["NGAYSINH"];

        }
    }
}
