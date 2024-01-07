using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLKS
{
    public class CusRentInfoDAL
    {
        private static CusRentInfoDAL instance;
        public static CusRentInfoDAL Instance
        {
            get { if (instance == null) instance = new CusRentInfoDAL(); return instance; }
            private set { instance = value; }
        }
        public CusRentInfoDAL() { }

        public List<Cus_rent> getListCusRentByBill(int id)
        {
            List<Cus_rent> RentList  = new List<Cus_rent>();
            string query = "EXEC dbo.TimThuePhongById @id = " + id;
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                Cus_rent cusRentInfo = new Cus_rent(dr);
                RentList.Add(cusRentInfo);
            }
            return RentList;
        }
    }
}
