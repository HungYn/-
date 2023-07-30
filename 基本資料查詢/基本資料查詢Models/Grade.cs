using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基本資料查詢Models
{
    /// <summary>
    /// 年級實體屬性
    /// </summary>
    public class Grade
    {
        #region 年級自動編號
        /// <summary>
        /// 年級自動編號
        /// </summary>
        public int GradeId { get; set; } = 0;
        #endregion
        #region 年級名稱
        /// <summary>
        /// 年級名稱
        /// </summary>
        public string GradeName { get; set; } = string.Empty;
        #endregion
    }
}
