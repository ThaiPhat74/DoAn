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
    public class UOServiceDAL:DBConnect
    {
        private static UOServiceDAL instance;
        public static UOServiceDAL Instance
        {
            get { if(instance == null) instance = new UOServiceDAL(); return instance; }
            set { instance = value; }
        }

        public UOServiceDAL() { }
        public DataTable getUOService()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("EXEC USP_GetUOServiceList", _conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public List<UOService> TimTheoSDDV(int ID)
        {
            try
            {
                List<UOService> list = new List<UOService>();
                DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.SUDUNGDICHVU WHERE MAHOADON = " + ID);
                foreach (DataRow dr in dt.Rows)
                {
                    UOService uo = new UOService(dr);
                    list.Add(uo);
                }
                return list;
            }
            catch (Exception e) { }
            finally { _conn.Close(); }
            return null;
        }

        public bool ThemUOS(UOService uos)
        {
            try
            {
                _conn.Open();

                string query = string.Format("EXEC dbo.ThemSDDV @idBill = {0} ,@idDV ={1}, @sl = {2}", uos.MaHD,uos.MaDV,uos.SoLuong);
                SqlCommand cmd = new SqlCommand(query, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex) { }
            finally { _conn.Close(); }
            return false;
        }
        public DataTable getUOSByName(string ten)
        {
            try
            {
                string SQL = string.Format("EXEC dbo.UOSByName @ten = {0}", ten);
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
        public DataTable getUOSByID(int id)
        {
            try
            {
                string SQL = string.Format("EXEC dbo.UOSByID @id = {0}", id);
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
    }
}
