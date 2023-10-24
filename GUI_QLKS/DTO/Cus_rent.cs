using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class Cus_rent
    {
        private int _mhd;
        private int _mp;
        private string _nameCus;
        private DateTime _ci;
        private DateTime _co;
        private string _pay;
        private string _note;

        public int Mhd { get => _mhd; set => _mhd = value; }
        public int Mp { get => _mp; set => _mp = value; }
        public string NameCus { get => _nameCus; set => _nameCus = value; }
        public DateTime Ci { get => _ci; set => _ci = value; }
        public DateTime Co { get => _co; set => _co = value; }
        public string Pay { get => _pay; set => _pay = value; }
        public string Note { get => _note; set => _note = value; }
    }
}
