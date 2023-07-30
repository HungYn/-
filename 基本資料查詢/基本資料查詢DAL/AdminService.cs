using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基本資料查詢DAL
{
    /// <summary>
    /// 管理員數據訪問類(三層架構裡面的數據方問層)
    /// </summary>
    //public class AdminService : CommStaticClass //類的繼承,CommStaticClass是父親,也叫基類,AdminService是兒子,派生類，類的繼承是單一的
    public class AdminService
    {
        #region 定義SQLHelper類變量
        /// <summary>
        /// 定義SQLHelper類變量
        /// </summary>
        private readonly SqlHelper sqlHelper = new SqlHelper();
        #endregion

        #region 执行管理員登入檢查
        /// <summary>
        /// 执行管理員登入檢查
        /// </summary>
        /// <param name="sLoginId">用戶名稱</param>
        /// <param name="sLoginPwd">密碼</param>
        /// <returns>True:登入成功,False:登入失敗</returns>

        public bool CheckAdminLogin(string sLoginId, string sLoginPwd)
        {
            bool bFlag ;
            //構建SQL語句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT LoginId,LoginPwd FROM Admin");
            sb.AppendLine("WHERE LoginId = @LoginId AND LoginPwd = @LoginPwd");

            //設置參數
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@LoginId",sLoginId),
                new SqlParameter("@LoginPwd",sLoginPwd)
            };

            //創建數據庫連接對象
            //SqlConnection conn = new SqlConnection(ConnectionStrings);
            try
            {
                DataTable Dt = sqlHelper.ExecuteTable(sb.ToString(), sqlParameters);
                return bFlag = Convert.ToBoolean(Dt.DefaultView.Count);

                ////創建执行工具SqlCommand命令
                //SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                ////設置执行命名參數
                //cmd.Parameters.AddRange(sqlParameters);
                //conn.Open();
                //SqlDataReader reader = cmd.ExecuteReader();
                //bFlag = reader.Read();

            }
            catch (Exception Err)
            {
                throw Err;
            }
            //finally
            //{
            //    conn.Close(); //關閉數據庫連接
            //}
            //return bFlag;
        } 
        #endregion
    }
}
