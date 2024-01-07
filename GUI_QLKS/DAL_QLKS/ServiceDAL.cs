using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Web;

namespace DAL_QLKS
{
    public class ServiceDAL:DBConnect
    {
        private static ServiceDAL instance;
        public static ServiceDAL Instance
        {
            get { if (instance == null) instance = new ServiceDAL(); return instance; }
            private set { instance = value; }
        }

        public ServiceDAL() { }
        public List<Service> ListServiceByServiceType(int id)
        {
            List<Service> list = new List<Service> ();

            string query = "SELECT * FROM dbo.DICHVU WHERE  STATUS = 1 AND MALDV = " + id;

            DataTable dt = DataProvider.Instance.ExecuteQuery (query);
            foreach(DataRow item in dt.Rows)
            {
                Service service = new Service(item);   
                list.Add(service);
            }
            return list;
        }

        public DataTable getDV()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("EXEC dbo.USP_GetServiceList", _conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public bool themDichVu(Service s)
        {
            try
            {
                _conn.Open();

                //string query = string.Format("EXEC dbo.ThemDichVu @MLDV = {0}, @Ten = {1},@DonVi = {2}, @Tien = {3},@Status = {4}",s.Mldv,s.Ten,s.Donvitinh,s.ThanhTien,s.Status);
                //SqlCommand cmd = new SqlCommand(query, _conn);

                //if (cmd.ExecuteNonQuery() > 0)
                //{
                //    return true;
                //}

                SqlCommand cmd = new SqlCommand("EXEC dbo.ThemDichVu @MLDV , @Ten ,@DonVi , @Tien ,@Status ", _conn);

                cmd.Parameters.AddWithValue("@MLDV", s.Mldv);
                cmd.Parameters.AddWithValue("@Ten", s.Ten);
                cmd.Parameters.AddWithValue("@DonVi", s.Donvitinh);
                cmd.Parameters.AddWithValue("@Tien", s.ThanhTien);
                cmd.Parameters.AddWithValue("@Status", s.Status);

                int result = cmd.ExecuteNonQuery(); _conn.Close();
                return result > 0;
            }
            catch (Exception ex) { }
            finally { _conn.Close(); }
            return false;
        }
        public bool suaDichVu(Service s)
        {
            try
            {
                _conn.Open();
                //string SQL = string.Format("EXEC dbo.SuaDichVu @MLDV = {0}, @Ten = {1}, @DonVi = {2}, @Tien = {3}, @Status = {4}, @Ma = {5}", s.Mldv, s.Ten, s.Donvitinh, s.ThanhTien,s.Status,s.Mdv);

                //SqlCommand cmd = new SqlCommand(SQL, _conn);
                //if (cmd.ExecuteNonQuery() > 0)
                //    return true;

                SqlCommand cmd = new SqlCommand("EXEC dbo.SuaDichVu @MLDV , @Ten , @DonVi , @Tien , @Status , @Ma ", _conn);

                cmd.Parameters.AddWithValue("@MLDV", s.Mldv);
                cmd.Parameters.AddWithValue("@Ten", s.Ten);
                cmd.Parameters.AddWithValue("@DonVi", s.Donvitinh);
                cmd.Parameters.AddWithValue("@Tien", s.ThanhTien);
                cmd.Parameters.AddWithValue("@Status", s.Status);
                cmd.Parameters.AddWithValue("@Ma", s.Mdv);
                int result = cmd.ExecuteNonQuery(); _conn.Close();
                return result > 0;
            }
            catch (Exception e) { }
            finally { _conn.Close(); }
            return false;
        }
        public bool xoaDichVu(int Dv_ID)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("EXEC dbo.XoaDichVu @Ma ={0}", Dv_ID);

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
                string SQL = string.Format("EXEC dbo.TimDichVu @Ten = {0}", Ten);
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
        public DataTable TimTheoID(int id)
        {
            try
            {
                string SQL = string.Format("EXEC dbo.HienThiDSDV @Ma = {0}", id);
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
