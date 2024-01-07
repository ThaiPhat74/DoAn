using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using NuGet.Common;

namespace DAL_QLKS
{
    public class CustomerDAL:DBConnect
    {
        private static CustomerDAL instance;
        Customer cus = new Customer();
        public static CustomerDAL Instance
        {
            get { if (instance == null) instance = new CustomerDAL(); return instance; }
            private set => instance = value;
        }
        public CustomerDAL() { }
        public DataTable getKhach()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("EXEC USP_GetCusList", _conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public bool themKhach(Customer c)
        {
            try
            {
                _conn.Open();

                ////string query = string.Format("INSERT INTO dbo.KHACH ( HOTEN, SDT, CMND, NGAYSINH)VALUES( {0}, {1}, {2},{3})",
                ////    c.Name, c.Sdt, c.Cmnd, c.Ns);
                //string query = string.Format("EXEC dbo.ThemKhach @HoTen = N'Nguyen Ngoc Đoan Trinh1',@SoDienThoai = '0335929189',@CMND = '225942301',@NS = '5-12-1995' -- datetime");
                //SqlCommand cmd = new SqlCommand(query, _conn);
                //if (cmd.ExecuteNonQuery() > 0)
                //    return true;

                SqlCommand cmd = new SqlCommand("EXEC ThemKhach @HoTen, @SDT , @CMND, @NS, @ST ", _conn);

                cmd.Parameters.AddWithValue("@HoTen",c.Name);
                cmd.Parameters.AddWithValue("@SDT", c.Sdt);
                cmd.Parameters.AddWithValue("@CMND",c.Cmnd );
                cmd.Parameters.AddWithValue("@NS",c.Ns);
                cmd.Parameters.AddWithValue("@ST", c.Status);
                int result = cmd.ExecuteNonQuery(); _conn.Close();
                return result > 0;
            }
            catch (Exception ex) { }
            finally { _conn.Close(); }
            return false;
        }
        public bool suaKhach(Customer c)
        {
            try
            {
                _conn.Open();
                //string SQL = string.Format("EXEC dbo.SuaKhach @HoTen = {0},@SoDienThoai = {1},@CMND = {2}, @NS = {3},@Ma = {4}",c.Name,c.Sdt,c.Cmnd,c.Ns,c.Id );

                //SqlCommand cmd = new SqlCommand(SQL, _conn);
                //if (cmd.ExecuteNonQuery() > 0)
                //    return true;
                SqlCommand cmd = new SqlCommand("EXEC dbo.SuaKhach @HoTen , @SoDienThoai , @CMND , @NS ,@ST , @Ma ", _conn);

                cmd.Parameters.AddWithValue("@HoTen", c.Name);
                cmd.Parameters.AddWithValue("@SoDienThoai", c.Sdt);
                cmd.Parameters.AddWithValue("@CMND", c.Cmnd);
                cmd.Parameters.AddWithValue("@NS", c.Ns);
                cmd.Parameters.AddWithValue("@ST", c.Status);
                cmd.Parameters.AddWithValue("@Ma", c.Id);
                int result = cmd.ExecuteNonQuery(); _conn.Close();
                return result > 0;
            }
            catch (Exception e) { }
            finally { _conn.Close(); }
            return false;
        }
        public bool xoaKhach(int KH_ID)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("EXEC dbo.XoaKhach @Ma ={0}", KH_ID);

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
        public DataTable TimKhach(string Ten)
        {
            try
            {
                string SQL = string.Format("EXEC dbo.TimKhach @Ten = {0}", Ten);
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
        public string idKhach(int ma)
        {
            try
            {
                _conn.Open();
                DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.KHACH WHERE STATUS = 1 AND MAKHACH =" + ma);
                if (data.Rows.Count > 0)
                {
                    Customer c = new Customer(data.Rows[0]);
                    return c.Name;
                }
            }
            catch (Exception e) { }
            finally { _conn.Close(); }
            return "";
        }
    }
}
