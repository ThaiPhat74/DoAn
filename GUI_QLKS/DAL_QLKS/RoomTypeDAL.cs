using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLKS
{
    public class RoomTypeDAL:DBConnect
    {
        public DataTable getLoaiPhong()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("EXEC USP_GetKindOfRoomList ", _conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public bool themLoaiPhong(RoomType rt)
        {
            try
            {
                _conn.Open();

                string query = string.Format("EXEC dbo.ThemLoaiPhong @TenLoai = {0},@MoTa = {1},@SoGiuong = {2},@TienTheoGio = {3},@TienTheoNgay = {4}  ",
                    rt.Ten,rt.Mota,rt.Sogiuong,rt.Gio,rt.Ngay);
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
        public bool suaLoaiPhong(RoomType rt)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("EXEC dbo.SuaLoaiPhong @TenLoai = {0},@MoTa = {1},@SoGiuong = {2}, @TienTheoGio = {3}, @TienTheoNgay = {4}, @Ma = {5} ",
                                            rt.Ten, rt.Mota, rt.Sogiuong, rt.Gio, rt.Ngay, rt.Id);

                SqlCommand cmd = new SqlCommand(SQL, _conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e) { }
            finally { _conn.Close(); }
            return false;
        }
        public bool xoaLoaiPhong(int LP_ID)
        {
            try
            {
                _conn.Open();
                string SQL = string.Format("EXEC dbo.XoaLoaiPhong @MaLoai ={0}", LP_ID);

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
                string SQL = string.Format("EXEC dbo.XemLoaiPhong @Ten = {0}", Ten);
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
