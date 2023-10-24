using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL_QLKS
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection("Data Source=MAYTPHAT;Initial Catalog=HOTELDB;User ID=sa;Password=123");
    }
    public class DataProvider
    {
        private static DataProvider instance;//Ctr +R + E
        public static DataProvider Instance {
            get { if (instance == null) instance = new DataProvider();return DataProvider.instance; }
            private set => instance=value; //chỉ có nội bộ mới có thể thay đổi,bên ngoài kh được đụng vào
        }
        private DataProvider() { }


        private string connectionstr = "Data Source=MAYTPHAT;Initial Catalog=HOTELDB;User ID=sa;Password=123";
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionstr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dt);
                connection.Close();
                return dt;
            }
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionstr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();
                connection.Close();
                return data;
            }
        }
        public object ExecScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionstr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteScalar();
                connection.Close();
                return data;
            }
        }
    }
}
