using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Room
    {
        private int iD;
        private int iDLoai;
        private string ten;
        private string trangThai;
        private bool tinhtrang;

        public Room(int id,int idLoai,string name,string tt,bool ttp)
        {
            this.iD = id;
            this.iDLoai = idLoai;
            this.ten = name;
            this.trangThai = tt;
            this.tinhtrang = ttp;
        }
        public Room() { }   

        public Room(DataRow row)
        {
            this.ID = (int)row["MAPHONG"];
            this.IDLoai = (int)row["MALOAIPHONG"];
            this.ten = row["ten"].ToString() ;
            this.trangThai = row["TRANGTHAI"].ToString();
            this.tinhtrang = (bool)row["TINHTRANGPHONG"];
        }
        public Room(string trangThai)
        {
            this.trangThai=trangThai;
        }
        public Room(int id)
        {
            this.ID = id;
        }

        public int ID { get => iD; set => iD=value; }
        public int IDLoai { get => iDLoai; set => iDLoai=value; }
        public string Ten { get => ten; set => ten=value; }
        public string TrangThai { get => trangThai; set => trangThai=value; }
        public bool Tinhtrang { get => tinhtrang; set => tinhtrang = value; }
    }
}
