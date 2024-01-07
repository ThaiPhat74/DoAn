
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_QLKS
{
    public class ThuePhongDAL:DBConnect
    {
        private static ThuePhongDAL instance;

        public static ThuePhongDAL Instance 
        {
            get { if (instance == null) instance = new ThuePhongDAL();return instance; } 
            private set => instance=value; 
        }
        public ThuePhongDAL() { }

        public List<Rent> LoadRentList()
        {
            try
            {
                List<Rent> list = new List<Rent>();
                _conn.Open();
                string query = "SELECT DISTINCT THANHTOAN FROM dbo.THUEPHONG";
                using (SqlCommand command = new SqlCommand(query, _conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string data = reader["THANHTOAN"].ToString();
                            Rent r = new Rent(data);
                            list.Add(r);
                        }
                    }
                    return list;
                }
            }
            catch (Exception e) { }
            finally { _conn.Close(); }
            return null;
        }
        public DataTable getTongBillTheoPhong(int id)
        {
            try
            {
                string SQL = string.Format("EXEC dbo.GetListTongBill @idPhong = {0}", id);
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
        public DataTable TimTheoTen(string Ten)
        {
            try
            {
                string SQL = string.Format("EXEC dbo.getThue @id = {0}", Ten);
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
        public DataTable getRent()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("EXEC USP_GetRentList", _conn);
            DataTable dt = new DataTable();
            foreach (DataRow row in dt.Rows)
            {
                DateTime dateTimeValue = (DateTime)row["CHECK_IN"];
                row["CHECK_IN"] = dateTimeValue.ToString("dd/MM/yyyy hh:mm:ss");
                DateTime dateTimeValue1 = (DateTime)row["CHECK_OUT"];
                row["CHECK_OUT"] = dateTimeValue1.ToString("dd/MM/yyyy hh:mm:ss");
            }
            adapter.Fill(dt);
            return dt;
        }
        public DataTable TimTheoID(int ID)
        {
            try
            {
                string SQL = string.Format("EXEC dbo.getThue @id = {0}", ID);
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
        public bool thuePhong(Rent r)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("EXEC dbo.ThemThuePhong @MaKhach,@MaPhong,@CI,@CO,@TT,@Note", _conn);

                cmd.Parameters.AddWithValue("@MaKhach", r.IDKhach);
                cmd.Parameters.AddWithValue("@MaPhong", r.IDPhong);
                cmd.Parameters.AddWithValue("@CI", r.CI);
                cmd.Parameters.AddWithValue("@CO", r.CO);
                cmd.Parameters.AddWithValue("@TT", r.Pay);
                cmd.Parameters.AddWithValue("@Note", r.Note);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex) { }
            finally { _conn.Close(); }
            return false;
        }
        public bool thuePhongKhongThongTin(Rent r)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("EXEC dbo.ThemThuePhongKhongThongTin @MaPhong,@CI,@CO,@TT,@Note", _conn);

                cmd.Parameters.AddWithValue("@MaPhong", r.IDPhong);
                cmd.Parameters.AddWithValue("@CI", r.CI);
                cmd.Parameters.AddWithValue("@CO", r.CO);
                cmd.Parameters.AddWithValue("@TT", r.Pay);
                cmd.Parameters.AddWithValue("@Note", r.Note);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex) { }
            finally { _conn.Close(); }
            return false;
        }

        public bool bookPhong(Rent r)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("EXEC dbo.BookRoom @MaKhach,@MaPhong,@CI,@CO,@TT,@Note", _conn);

                cmd.Parameters.AddWithValue("@MaKhach", r.IDKhach);
                cmd.Parameters.AddWithValue("@MaPhong", r.IDPhong);
                cmd.Parameters.AddWithValue("@CI", r.CI);
                cmd.Parameters.AddWithValue("@CO", r.CO);
                cmd.Parameters.AddWithValue("@TT", r.Pay);
                cmd.Parameters.AddWithValue("@Note", r.Note);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex) { }
            finally { _conn.Close(); }
            return false;
        }

        public bool ThanhToan(Rent r)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("EXEC dbo.ThanhToan @idPhong = {0}, @idHoaDon = {1}",r.IDPhong,r.IDHD);

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
        public bool CancelBook(int id)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("EXEC dbo.CancelBook @id = {0}", id);

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
        public bool checkOut(Rent r)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("EXEC CheckOUT @id = {0}, @idPhong = {1}", r.IDHD,r.IDPhong);

                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e) { }
            finally { _conn.Close(); }
            return false;
        }
        public bool checkOutByBill(Rent r)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("EXEC dbo.CheckOUTByBill @id = {0}, @idPhong = {1}", r.IDHD, r.IDPhong);

                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e) { }
            finally { _conn.Close(); }
            return false;
        }
        public DataTable TimTheoTen2(string Ten)
        {
            try
            {
                string SQL = string.Format("EXEC dbo.RentByNameRoom @ten = {0}", Ten);
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
        public DataTable TimTheoIdBill(int id)
        {
            try
            {
                string SQL = string.Format("EXEC dbo.RentByIDBill @id = {0}", id);
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
        public bool UpdatebookPhong(Rent r)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("EXEC dbo.UpdateBookPhong @makhach ,@maphong ,@ci ,@co , @tt , @note , @mahd ", _conn);

                cmd.Parameters.AddWithValue("@makhach", r.IDKhach);
                cmd.Parameters.AddWithValue("@maphong", r.IDPhong);
                cmd.Parameters.AddWithValue("@ci", r.CI);
                cmd.Parameters.AddWithValue("@co", r.CO);
                cmd.Parameters.AddWithValue("@tt", r.Pay);
                cmd.Parameters.AddWithValue("@note", r.Note);
                cmd.Parameters.AddWithValue("@mahd", r.IDHD);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex) { }
            finally { _conn.Close(); }
            return false;
        }
    }
    }
