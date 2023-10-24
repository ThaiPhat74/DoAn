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
    public class StaffDAL:DBConnect
    {
        public DataTable getStaff()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("EXEC USP_GetStaffList", _conn);
            DataTable dt = new DataTable();
            foreach (DataRow row in dt.Rows)
            {
                DateTime dateTimeValue = (DateTime)row["NGAYSINH"];
                row["NGAYSINH"] = dateTimeValue.ToString("dd/MM/yyyy");
            }
            adapter.Fill(dt);
            return dt;
        }
        public bool themNhanVien(Staff s)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("EXEC dbo.ThemNhanVien @MaNV ,@HT ,@dc ,@sdt ,@ns ,@cmnd ,@cv ", _conn);

                cmd.Parameters.AddWithValue("@MaNV",s.MaNV);
                //cmd.Parameters.AddWithValue("@MaTK",s.MaTK);
                cmd.Parameters.AddWithValue("@HT", s.HoTen);
                cmd.Parameters.AddWithValue("@dc",s.DiaChi);
                cmd.Parameters.AddWithValue("@sdt", s.Sdt);
                cmd.Parameters.AddWithValue("@ns", s.Ns);
                cmd.Parameters.AddWithValue("@cmnd", s.Cmnd);
                cmd.Parameters.AddWithValue("@cv", s.ChucVu);
                int result = cmd.ExecuteNonQuery(); _conn.Close();
                return result > 0;
            }
            catch (Exception ex) { }
            finally { _conn.Close(); }
            return false;
        }
        public bool suaNhanVien(Staff s)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("EXEC dbo.SuaNhanVien @MaNV ,@MaTK ,@HT ,@dc ,@sdt ,@ns ,@cmnd ,@cv ", _conn);

                cmd.Parameters.AddWithValue("@MaNV", s.MaNV);
                cmd.Parameters.AddWithValue("@MaTK", s.MaTK);
                cmd.Parameters.AddWithValue("@HT", s.HoTen);
                cmd.Parameters.AddWithValue("@dc", s.DiaChi);
                cmd.Parameters.AddWithValue("@sdt", s.Sdt);
                cmd.Parameters.AddWithValue("@ns", s.Ns);
                cmd.Parameters.AddWithValue("@cmnd", s.Cmnd);
                cmd.Parameters.AddWithValue("@cv", s.ChucVu);
                int result = cmd.ExecuteNonQuery(); _conn.Close();
                return result > 0;
            }
            catch (Exception e) { }
            finally { _conn.Close(); }
            return false;
        }
        public bool xoaNhanVien(string NV_ID)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("EXEC dbo.XoaNhanVien @MaNV  ={0}", NV_ID);

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
        public DataTable TimNhanVien(string Ten)
        {
            try
            {
                string SQL = string.Format("EXEC dbo.TimNhanVien @Ten = {0}", Ten);
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
