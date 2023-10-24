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

                string query = string.Format("EXEC dbo.ThemPhong @MaLoai = {0}, @Ten = {1} , @TrangThai = {2}, @TTP = {3}", p.IDLoai,p.Ten,p.TrangThai,p.Tinhtrang);
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
        public bool suaPhong(Room phong)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("EXEC dbo.SuaPhong @MaLoai = {0}, @Ten = {1}, @TrangThai = {2},@TTP = {3}, @Ma ={4}",
                                            phong.IDLoai, phong.Ten, phong.TrangThai,phong.Tinhtrang, phong.ID);

                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
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
    }
}
