using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLKS
{
    public class BillDAL:DBConnect
    {
        private static BillDAL instance;
        Bill bill = new Bill();
        public static BillDAL Instance 
        {
            get { if (instance == null) instance = new BillDAL();return instance; }
            private set => instance=value; 
        }
        public BillDAL() { }
        
        
        public DataTable getAllHoaDon()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("EXEC USP_GetBillList", _conn);
            DataTable dt = new DataTable();
            foreach (DataRow row in dt.Rows)
            {
                DateTime dateTimeValue = (DateTime)row["NGAYIN"];
                row["NGAYIN"] = dateTimeValue.ToString("dd/MM/yyyy HH:mm:ss");
            }
            adapter.Fill(dt);
            return dt;
        }
        public DataTable getHoaDonByID(int id)
        {
            try
            {
                string SQL = string.Format("EXEC dbo.GetBillByID @i = {0}", id);
                _conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                return dt;
            }
            catch (Exception e) { }
            finally { _conn.Close(); }
            return null;
        }
        public bool disCount(Bill b)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("EXEC dbo.UpdateDis @id = {0},@discount = {1}",b.IdBill,b.Discount);

                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e) { }
            finally { _conn.Close(); }
            return false;
        }
        public DataTable getHoaDonByID2(int id)
        {
            try
            {
                string SQL = string.Format("EXEC dbo.GetBillID @id = {0}", id);
                _conn.Open();
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                return dt;
            }
            catch (Exception e) { }
            finally { _conn.Close(); }
            return null;
        }
        public bool xoaHd(int id)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("EXEC dbo.XoaHoaDon @id = {0}", id);

                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e) { }
            finally { _conn.Close(); }

            return false;
        }
    }
}
