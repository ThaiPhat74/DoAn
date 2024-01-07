using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLKS
{
    public class AccountDAL:DBConnect
    {
        private static AccountDAL instance;
        public static AccountDAL Instance {
            get { if (instance == null) instance = new AccountDAL();return instance; }
            private set => instance=value;
        }
       public AccountDAL() { }

        public string HashPass(string text)
        {
            MD5 md5 = MD5.Create();
            byte[] temp = Encoding.ASCII.GetBytes(text);
            byte[] hashData = md5.ComputeHash(temp);
            string hashPass = "";
            foreach (var item in hashData)
            {
                hashPass += item.ToString("x2");
            }
            return hashPass;
        }
        public bool Login(string username, string password) 
        {
            string hashPass = HashPass(password);
            string query = "USP_Login @acc , @pass ";
            
            DataTable result = DataProvider.Instance.ExecuteQuery(query,new object[] {username,hashPass});
            return result.Rows.Count > 0;
        }
        public DataTable getTaiKhoan()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("EXEC USP_GetAccList", _conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public bool themTaiKhoan(Account account)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("EXEC dbo.ThemTaiKhoan @MaNV ,@TenDN, @MK, @PQ", _conn);

                string hashPass = HashPass(account.MatKhau);


                cmd.Parameters.AddWithValue("@MaNV", account.MaNhanVien);
                cmd.Parameters.AddWithValue("@TenDN", account.TenDangNhap);
                cmd.Parameters.AddWithValue("@MK", hashPass);
                cmd.Parameters.AddWithValue("@PQ", account.PhanQuyen);
                int result = cmd.ExecuteNonQuery(); _conn.Close();
                return result > 0;
            }
            catch (Exception ex) { }
            finally { _conn.Close(); }
            return false;
        }
        public bool suaTaiKhoan(Account account)
        {
            try
            {
                _conn.Open();
                //string SQL = string.Format("EXEC dbo.SuaKhach @HoTen = {0},@SoDienThoai = {1},@CMND = {2}, @NS = {3},@Ma = {4}",c.Name,c.Sdt,c.Cmnd,c.Ns,c.Id );

                //SqlCommand cmd = new SqlCommand(SQL, _conn);
                //if (cmd.ExecuteNonQuery() > 0)
                //    return true;
                SqlCommand cmd = new SqlCommand("EXEC dbo.SuaTaiKhoan @MaNV , @TenDN,@MK ,@PQ, @MaTK", _conn);

                string hashPass = HashPass(account.MatKhau);


                cmd.Parameters.AddWithValue("@MaNV", account.MaNhanVien);
                cmd.Parameters.AddWithValue("@TenDN", account.TenDangNhap);
                cmd.Parameters.AddWithValue("@MK", hashPass);
                cmd.Parameters.AddWithValue("@PQ", account.PhanQuyen);
                cmd.Parameters.AddWithValue("@MaTK", account.MaTaiKhoan);
                int result = cmd.ExecuteNonQuery(); _conn.Close();
                return result > 0;
            }
            catch (Exception e) { }
            finally { _conn.Close(); }
            return false;
        }
        public bool xoaTaiKhoan(int TK_ID)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("EXEC dbo.XoaTaiKhoa @MaTK ={0}", TK_ID);

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
        public DataTable TimTaiKhoan(string Ten)
        {
            try
            {
                string SQL = string.Format("EXEC dbo.TimTaiKhoan @Ten = {0}", Ten);
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
        public bool DoiMatKhau(Account a)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("UPDATE dbo.TAIKHOAN SET MATKHAU = {1} WHERE TENDANGNHAP = {0}",
                a.TenDangNhap, a.MatKhau);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                
                    if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e) { }
            finally { _conn.Close(); }
            return false;
        }
    }
}
