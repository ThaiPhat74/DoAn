using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL_QLKS
{
    public class SaleDAL:DBConnect
    {
        private static SaleDAL instance;
        Sale sale = new Sale();
        public static SaleDAL Instance
        {
            get { if (instance == null) instance = new SaleDAL(); return instance; }
            private set => instance = value;
        }
        public SaleDAL() { }
        public DataTable getDoanhThu()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("EXEC USP_GetSalesList", _conn);
            DataTable dt = new DataTable();
            foreach (DataRow row in dt.Rows)
            {
                DateTime dateTimeValue = (DateTime)row["NGAY"];
                row["NGAY"] = dateTimeValue.ToString("dd/MM/yyyy");
            }
            adapter.Fill(dt);
            return dt;
        }
        public DataTable ThongKeAdenB(DateTime ci, DateTime co)
        {
            try
            {
                string SQL = string.Format("EXEC ThongKeTheoNgayAdenB @ci , @co ");
                _conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@ci", ci);
                cmd.Parameters.AddWithValue("co", co);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                return dt;
            }
            catch (Exception e) { }
            finally { _conn.Close(); }
            return null;
        }
    }
}
