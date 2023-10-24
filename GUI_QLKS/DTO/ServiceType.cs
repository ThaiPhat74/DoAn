using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ServiceType
    {
        private int _mldv;
        private string _name;

        public int Mldv { get => _mldv; set => _mldv = value; }
        public string Name { get => _name; set => _name = value; }

        public ServiceType() { }    
        public ServiceType(int mldv, string name)
        {
            this.Mldv = mldv;
            this.Name = name;
        }
        public ServiceType(string name)
        {
            this.Name = name;
        }
        public ServiceType(DataRow r)
        {
            this.Mldv = (int)r["MALDV"];
            this.Name = r["TEN"].ToString();
        }
    }
}
