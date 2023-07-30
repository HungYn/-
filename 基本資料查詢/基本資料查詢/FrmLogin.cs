using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 基本資料查詢.AdminForm;
using 基本資料查詢.Comm;
using 基本資料查詢BLL;
using 基本資料查詢Models;

namespace 基本資料查詢
{
    public partial class FrmLogin : Form
    {
        #region 定義業務邏輯層變量
        /// <summary>
        /// 定義業務邏輯層變量
        /// </summary>
        private readonly AdminManage adminManage = new AdminManage();
        #endregion
        #region 構造函數
        /// <summary>
        /// 構造函數
        /// </summary>
        public FrmLogin()
        {
            InitializeComponent();
        }
        #endregion
        #region 取消事件
        /// <summary>
        ///  取消事件
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        private void BtnCancle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region 窗體加戴(讓下拉框的管理員選中)
        /// <summary>
        ///  窗體加戴(讓下拉框的管理員選中)
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            CboType.SelectedIndex = 0;
        }
        #endregion

        #region 輸入驗證
        /// <summary>
        ///  輸入驗證
        /// </summary>
        /// <param name="loginId">用戶名</param>
        /// <param name="loginPwd">用戶密碼</param>
        /// <returns>True:驗証通過,False:驗証不通過</returns>
        private bool CheckInput(string loginId,string loginPwd)
        {

            if(loginId.Length==0)
            {
                MessageBox.Show(CommProperty.InputName, CommProperty.InputCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtName.FindForm();
                return false;

            }
            if (loginPwd.Length == 0)
            {
                MessageBox.Show(CommProperty.InputPass, CommProperty.InputCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPwd.FindForm();
                return false;

            }
            return true;
        }
        #endregion

        #region 登入事件
        /// <summary>
        /// 登入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOK_Click(object sender, EventArgs e)
        {
            string sLoginId = TxtName.Text.Trim(); //得到用戶名
            string sLoginPwd = TxtPwd.Text.Trim(); //得到密碼
            if (!CheckInput(sLoginId, sLoginPwd)) //如果沒有通過驗証,程序短路
            {
                return;
            }
            if (CboType.SelectedIndex == 0) //管理員
            {
                //管理員驗証
                CheckAdmin(sLoginId, sLoginPwd);
            }
            else
            {
                //學生驗証
            }
        } 
        #endregion

        #region 管理員驗證
        /// <summary>
        ///  管理員驗證
        /// </summary>
        /// <param name="loginId">用戶名</param>
        /// <param name="loginPwd">用戶密碼</param>
        private void CheckAdmin(string loginId, string loginPwd)
        {
            if (adminManage.CheckAdminLogin(loginId, loginPwd))//如果登入成功
            {
                MessageBox.Show(CommProperty.AdminLoginSucess, CommProperty.InputCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //實體用戶信息
                UserInfo userInfo = new UserInfo
                {
                    LoginId = loginId,
                    LoginPwd = loginPwd,
                    LoginType = CboType.Text
                };

                FrmAdminMain frmAdminMain = new FrmAdminMain();//實例化主窗體
                frmAdminMain.Show();//打開管理員主界面窗體
                Hide();//隐藏登入界面
            }
            else
            {
                MessageBox.Show(CommProperty.AdminLoginFail, CommProperty.InputCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        } 
        #endregion
    }

}
