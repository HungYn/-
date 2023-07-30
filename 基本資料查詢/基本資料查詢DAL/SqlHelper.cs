using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace 基本資料查詢DAL
{   
    /// <summary>
    /// SQL數據庫訪問類
    /// </summary>
    public class SqlHelper: CommStaticClass
    {
        #region 創建SqlConnection數據庫連接類
        /// <summary>
        /// 創建SqlConnection數據庫連接類
        /// </summary>
        /// <returns></returns>
        private SqlConnection CreateConn()
        {
            return new SqlConnection(ConnectionStrings);
        }
        #endregion

        // python語言裡面有可變參數，什麼意思呢?就是可以有,也可以沒有
        // 我們的C#也是有的
        #region 返回一個數據表
        /// <summary>
        /// 返回一個數據表
        /// </summary>
        /// <param name="cmdText">SQL語句</param>
        /// <param name="SqlParameter">可變參數</param>
        /// <returns>返回一個數據表的集合</returns>
        public DataTable ExecuteTable(string cmdText, params SqlParameter[] sqlParameters)
        {
            using (SqlConnection conn = CreateConn())
            {
                conn.Open(); //打開數據庫的連接
                SqlCommand cmd = new SqlCommand(cmdText, conn); //給cmd命令傳入參數
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);//數據源適配器
                DataSet dataSet = new DataSet();//創建數據集
                sqlDataAdapter.Fill(dataSet);//填充數據集
                return dataSet.Tables[0];//返回一個表格數據
            }
        } 
        #endregion
    }
}
