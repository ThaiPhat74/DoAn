using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Drawing;

namespace DAL_QLKS
{
    public class ServiceTypeDAL:DBConnect
    {
        private static ServiceTypeDAL instance;
        public static ServiceTypeDAL Instance
        {
            get { if (instance == null) instance = new ServiceTypeDAL(); return instance; }
            private set => instance = value;
        }
        public ServiceTypeDAL() { }

        public List<ServiceType> GetlistST()
        {
            List<ServiceType> list = new List<ServiceType>();

            string query = "SELECT * FROM dbo.LOAIDICHVU";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                ServiceType ST = new ServiceType(item);
                list.Add(ST);
            }
            return list;
        }
        public DataTable getLDV()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("EXEC USP_GetKindOfServiceList", _conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public bool themLoaiDichVu(ServiceType s)
        {
            try
            {
                _conn.Open();

                //string query = string.Format("EXEC dbo.ThemLoaiDichVu @Ten = {0}",s.Name);
                //SqlCommand cmd = new SqlCommand(query, _conn);

                //if (cmd.ExecuteNonQuery() > 0)
                //{
                //    return true;
                //}

                SqlCommand cmd = new SqlCommand("EXEC dbo.ThemLoaiDichVu @Ten  ", _conn);

                cmd.Parameters.AddWithValue("@Ten", s.Name);
                
                int result = cmd.ExecuteNonQuery(); _conn.Close();
                return result > 0;
            }
            catch (Exception ex) { }
            finally { _conn.Close(); }
            return false;
        }
        public bool suaLoaiDichVu(ServiceType s)
        {
            try
            {
                _conn.Open();
                //string SQL = string.Format("EXEC dbo.SuaLoaiDichVu @Ten = {0},@Ma={1} ", s.Name,s.Mldv);

                //SqlCommand cmd = new SqlCommand(SQL, _conn);
                //if (cmd.ExecuteNonQuery() > 0)
                //    return true;

                SqlCommand cmd = new SqlCommand("EXEC dbo.SuaLoaiDichVu @Ten ,@Ma ", _conn);

                cmd.Parameters.AddWithValue("@Ten", s.Name);
                cmd.Parameters.AddWithValue("@Ma", s.Mldv);
                int result = cmd.ExecuteNonQuery(); _conn.Close();
                return result > 0;
            }
            catch (Exception e) { }
            finally { _conn.Close(); }
            return false;
        }
        public bool XoaloaiDichVu(int KDv_ID)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("EXEC dbo.XoaLoaiDichVu @id = {0}", KDv_ID);

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
        public DataTable TimTheoTen(string Ten)
        {
            try
            {
                string SQL = string.Format("EXEC dbo.XemLoaiDV @Ten = {0}", Ten);
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
