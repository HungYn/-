using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基本資料查詢Models
{
    /// <summary>
    /// 管理員和學生共有的屬性類
    /// </summary>
    public class UserInfo
    {
        #region 用戶名或學號
        /// <summary>
        /// 用戶名或學號
        /// </summary>
        public string LoginId { get; set; }
        #endregion
        #region 登入密碼
        /// <summary>
        /// 登入密碼
        /// </summary>
        public string LoginPwd { get; set; } 
        #endregion
        #region 登入類型
        /// <summary>
        /// 登入類型
        /// </summary>
        public string LoginType { get; set; } 
        #endregion

    }
}
