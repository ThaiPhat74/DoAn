using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_QLKS
{
    public class BillInfoDAL
    {
        private static BillInfoDAL instance;
        public static BillInfoDAL Instance
        {
            get { if (instance == null) instance = new BillInfoDAL(); return instance; }
            private set { instance = value; }
        }
        public BillInfoDAL() { }
        
        public List<BillInfo> getListBillInfoByBill(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            string query = "EXEC dbo.timBillInfoIDBill  @id = " + id;
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                BillInfo billInfo = new BillInfo(dr);
                listBillInfo.Add(billInfo);
            }
            return listBillInfo;
        }
    }
}
