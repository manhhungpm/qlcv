using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCV.DataAccess
{
    class Xuly
    {
        public static SqlDataAdapter dap;
        public static SqlCommand cmd;
        public static SqlConnection conn = new SqlConnection(ConfigurationSettings.AppSettings["StringConn"]);

        public static DataTable table_Select(String sql) //lấy toàn bộ bảng dl vào trong csdl
        {
            // SqlConnection conn;
            dap = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            dap.Fill(table); //đổ dữ liệu vào table
            return table;
        }

        public static void table_Command(String sql) //thực thi các lệnh SQL
        {

            conn.Open();
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
    }
}
