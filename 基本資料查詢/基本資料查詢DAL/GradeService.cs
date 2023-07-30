using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 基本資料查詢Models;

namespace 基本資料查詢DAL
{

    /// <summary>
    /// 實體年級類
    /// </summary>
    public class GradeService
    {
        #region 定義SQLHelper類變量
        /// <summary>
        /// 定義SQLHelper類變量
        /// </summary>
        private readonly SqlHelper sqlHelper = new SqlHelper(); 
        #endregion

        #region 獲取所有年級的信息
        /// <summary>
        /// 獲取所有年級的信息
        /// </summary>
        /// <returns></returns>
        public List<Grade> GetGrades()
        {
            //創建年級對象集合
            List<Grade> grades = new List<Grade>();
            //構建SQL語句
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT GradeId,GradeName FROM Grade ORDER BY GradeId ASC"); //這裡沒有參數

            //創建連接對象
            //SqlConnection conn = new SqlConnection(ConnectionStrings);
            try
            {
                //但凡是 繼承IDisposable這個接口的，都可以通過using括號起來，那麼在此括號內定義的變量都會自動釋放
                DataTable Dt = sqlHelper.ExecuteTable(sb.ToString());
                for (int i = 0; i < Dt.DefaultView.Count ; i++)
                {
                    Grade grade = new Grade
                    {
                        GradeId = Convert.ToInt32(Dt.Rows[i]["GradeId"]),
                        GradeName = Convert.ToString(Dt.Rows[i]["GradeName"])
                    };
                    grades.Add(grade);
                }
                ////創建SqlCommand命令
                //SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                ////打開數據庫連接
                //conn.Open();
                ////執行查詢
                //SqlDataReader reader = cmd.ExecuteReader();
                ////循環取數據
                //while (reader.Read())
                //{
                //    Grade grade = new Grade
                //    {
                //        GradeId = Convert.ToInt32(reader["GradeId"]),
                //        GradeName = Convert.ToString(reader["GradeName"])
                //    };
                //    grades.Add(grade);
                //}
                //reader.Close();
            }
            catch (Exception Err)
            {

                throw Err;
            }
            //finally
            //{
            //    conn.Close();
            //}
            return grades;
        } 
        #endregion

    }
}
