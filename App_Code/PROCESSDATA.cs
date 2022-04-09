using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for PROCESSDATA
/// </summary>
namespace QUANLYBANHANG.App_Code
{
    public class PROCESSDATA
    {
        SqlConnection con;
        public PROCESSDATA(String strpath)
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" 
                + strpath + ";Integrated Security=True";
        }
        
        public void openConnect()
        {
            if (this.con.State == ConnectionState.Closed)
                this.con.Open();
        }
        public void closeConnect()
        {
            if (this.con.State == ConnectionState.Open)
                this.con.Close();
        }
        /// <summary>
        /// Phương thức getDataTable (...) thực thi câu lệnh SQL
        /// trả về dữ liệu kiểu DataTable
        /// </summary>
        /// <param name="SQL">Select * from .../param>
        /// <returns>DataTable</returns>
        public DataTable getDataTable(String sql)
        {
            DataTable tb = new DataTable();
            try
            {
                this.openConnect();
                SqlDataAdapter adp = new SqlDataAdapter(sql, this.con);
                adp.Fill(tb);
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                this.closeConnect();
            }
            return tb;
        }
        /// <summary>
        /// Phương thức exeSQL(...), thực thi SQL bằng phương thức ExecuteNonQuery() 
        /// trả về kết quả (k<>0 thành công, k=0 không thành công)
        /// </summary>
        /// <param name="sql">Insert into..., Delete...., Update....</param>
        /// <returns>int</returns>
        public int exeSQL(String sql)
        {
            int k = 0;
            try
            {
                this.openConnect();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                k = cmd.ExecuteNonQuery();//thi thi SQL
            }
            catch (SqlException ex)
            { }
            finally
            {
                this.closeConnect();
            }
            return k;
        }

    }// PROCESSDATA
} // namespace QUANLYBANHANG.App_Code
