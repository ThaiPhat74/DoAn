using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLKS
{
    public class RoomDAL:DBConnect
    {
        private static RoomDAL instance;

        public static RoomDAL Instance 
        {
            get { if (instance == null) instance = new RoomDAL(); return instance; }
            private set {  instance=value; }
        }
        Room Room = new Room();
        public static int TableWidth = 115;
        public static int TableHeight = 125;  
        public RoomDAL() { }

        public List<Room> LoadRoomList()
        {
            List<Room> list = new List<Room>();

            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.HienPhong");

            foreach (DataRow item in data.Rows) 
            {
                Room room = new Room(item);
                list.Add(room);
            }
            return list;
        }
        public List<Room> LoadStatusRoom()
        {
            try
            {
                List<Room> list = new List<Room>();
                _conn.Open();
                string query = "EXEC dbo.LoadStatusRoom";
                using (SqlCommand command = new SqlCommand(query, _conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string data = reader["TRANGTHAI"].ToString();
                            Room r = new Room(data);
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
        public DataTable getPhong()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("EXEC USP_GetRoomList", _conn);
            DataTable dt = new DataTable();
            foreach (DataRow row in dt.Rows)
            {
                bool bitValue = (bool)row["TrangThaiPhong"];
                row["TrangThaiPhong"] = bitValue ? "True" : "False";
            }
            adapter.Fill(dt);
            return dt;
        }
        public bool themPhong(Room p)
        {
            try
            {
                _conn.Open();

                //string query = string.Format("EXEC dbo.ThemPhong @MaLoai = {0}, @Ten = {1} , @TrangThai = {2}, @TTP = {3}", p.IDLoai,p.Ten,p.TrangThai,p.Tinhtrang);
                //SqlCommand cmd = new SqlCommand(query, _conn);

                //if (cmd.ExecuteNonQuery() > 0)
                //{
                //    return true;
                //}

                SqlCommand cmd = new SqlCommand("EXEC dbo.ThemPhong @MaLoai , @Ten , @TrangThai , @TTP ", _conn);

                cmd.Parameters.AddWithValue("@MaLoai", p.IDLoai);
                cmd.Parameters.AddWithValue("@Ten", p.Ten);
                cmd.Parameters.AddWithValue("@TrangThai", p.TrangThai);
                cmd.Parameters.AddWithValue("@TTP", p.Tinhtrang);
                
                int result = cmd.ExecuteNonQuery(); _conn.Close();
                return result > 0;
            }
            catch (Exception ex) { }
            finally { _conn.Close(); }
            return false;
        }
        public bool suaPhong(Room phong)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("EXEC dbo.SuaPhong @MaLoai = {0}, @Ten = {1}, @TrangThai = {2},@TTP = {3}, @Ma ={4}",
                                            phong.IDLoai, phong.Ten, phong.TrangThai, phong.Tinhtrang, phong.ID);

                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

                //_conn.Open();
                //SqlCommand cmd = new SqlCommand("EXEC dbo.SuaPhong @MaLoai , @Ten , @TrangThai , @TTP , @Ma ", _conn);

                //cmd.Parameters.AddWithValue("@MaLoai", phong.IDLoai);
                //cmd.Parameters.AddWithValue("@Ten", phong.Ten);
                //cmd.Parameters.AddWithValue("@TrangThai", phong.TrangThai);
                //cmd.Parameters.AddWithValue("@TTP", phong.Tinhtrang);
                //cmd.Parameters.AddWithValue("@Ma", phong.ID);

                //int result = cmd.ExecuteNonQuery(); _conn.Close();
                //return result > 0;
            }
            catch (Exception e) { }
            finally { _conn.Close(); }
            return false;
        }
        public bool xoaPhong(int Ph_ID)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("EXEC dbo.XoaPhong @Ma ={0}", Ph_ID);

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
                string SQL = string.Format("EXEC dbo.TimPhongTheoTen @Ten = {0}", Ten);
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
        public void DoiPhong(int id1,int id2)
        {
            DataProvider.Instance.ExecuteQuery("EXEC dbo.ChuyenPhong @idPhong1 , @idPhong2", new object[] { id1, id2 });
        }
        public bool LayPhong(int id)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("EXEC dbo.LayPhong @id ", _conn);

                cmd.Parameters.AddWithValue("@id", id);
                int result = cmd.ExecuteNonQuery(); _conn.Close();
                return result > 0;
            }
            catch (Exception ex) { }
            finally { _conn.Close(); }
            return false;
        }
    }
}
