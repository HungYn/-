using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 基本資料查詢DAL;
using 基本資料查詢Models;

namespace 基本資料查詢BLL
{
    /// <summary>
    /// 業務邏輯層類(三層架構中的業務邏輯層)
    /// </summary>
    public class GradeManage
    {
        #region 定義年級數據訪問層變量
        /// <summary>
        /// 定義年級數據訪問層變量
        /// </summary>
        private readonly GradeService gradeService = new GradeService();
        #endregion

        #region 獲取所有年級的信息
        /// <summary>
        /// 獲取所有年級的信息　
        /// </summary>
        /// <returns></returns>
        public List<Grade> GetGrades()
        {
            try
            {
                return gradeService.GetGrades();
            }
            catch (Exception Err)
            {

                throw Err;
            }
        } 
        #endregion
    }
}
