using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 基本資料查詢DAL;


namespace 基本資料查詢BLL
{
    /// <summary>
    /// 業務邏輯層類(三層架構中的業務邏輯層)
    /// </summary>
    public class AdminManage
    {
        #region 定義管理員數據訪問層變量
        /// <summary>
        /// 定義管理員數據訪問層變量
        /// </summary>
        private readonly AdminService AdminService = new AdminService();
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
            try
            {
                return AdminService.CheckAdminLogin(sLoginId, sLoginPwd);
            }
            catch (Exception Err)
            {
                
                throw Err;
                
            }

        }
        #endregion
    }
}
