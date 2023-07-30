using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 基本資料查詢.Comm;
using 基本資料查詢BLL;
using 基本資料查詢Models;

namespace 基本資料查詢.AdminForm
{
    /// <summary>
    /// 增加學生信息的窗體
    /// </summary>
    public partial class FrmAddStudent : Form
    {
        private GradeManage gradeManage = new GradeManage();
        #region 構造函數
        /// <summary>
        /// 構造函數
        /// </summary>
        public FrmAddStudent()
        {
            InitializeComponent();
        } 
        #endregion
        #region 選擇出生日期
        /// <summary>
        /// 選擇出生日期
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DtpBornDate_CloseUp(object sender, EventArgs e)
        {
            TxtBornDate.Text = DtpBornDate.Value.ToShortDateString();//把選擇的日期值給文本框
            DtpBornDate.Visible = false; //隱藏日期控件
        }
        #endregion
        #region 出生日期文本框點擊事件
        /// <summary>
        /// 出生日期文本框點擊事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtBornDate_Click(object sender, EventArgs e)
        {
            DtpBornDate.Visible = true;//點擊文本框讓日期控件顯示
            DtpBornDate.Focus();//焦點移到日期控件
        }
        #endregion
        #region 關閉窗體按鈕
        /// <summary>
        /// 關閉窗體按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
        #region 增加學生用戶信息
        /// <summary>
        /// 增加學生用戶信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckInput())//驗証輸入沒有通過
            {
                return;
            }
        }
        #endregion
        #region 驗証控件輸入的合法性
        /// <summary>
        /// 驗証控件輸入的合法性
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            if (TxtStudentNo.Text.Trim().Length==0)
            {
                MessageBox.Show(CommProperty.StudentNuInfo, CommProperty.InputCaption, MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                TxtStudentNo.Focus();
                return false;
            }
            if (TxtLoginPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show(CommProperty.InputPass, CommProperty.InputCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtLoginPwd.Focus();
                return false;
            }
            if (TxtLoginPwd.Text.Trim() != TxtReLoginPwd.Text.Trim())
            {
                MessageBox.Show(CommProperty.PasswordNotSame, CommProperty.InputCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtReLoginPwd.Focus();
                return false;
            }
            if (TxtStudentName.Text.Trim().Length == 0)
            {
                MessageBox.Show(CommProperty.StudentNameInfo, CommProperty.InputCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtStudentName.Focus();
                return false;
            }
            if (!RbGenderBoy.Checked && !RbGenderGirl.Checked)
            {
                MessageBox.Show(CommProperty.StudentGenderInfo, CommProperty.InputCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtStudentName.Focus();
                return false;
            }
            if (CbGradeId.Text.Trim().Length == 0)
            {
                MessageBox.Show(CommProperty.StudentCbGradeIdInfo, CommProperty.InputCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CbGradeId.Focus();
                return false;
            }
            if (TxtPhome.Text.Trim().Length == 0)
            {
                MessageBox.Show(CommProperty.PhomeInfo, CommProperty.InputCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPhome.Focus();
                return false;
            }
            if (TxtBornDate.Text.Trim().Length == 0)
            {
                MessageBox.Show(CommProperty.BornDateInfo, CommProperty.InputCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtBornDate.Focus();
                return false;
            }
            if (TxtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show(CommProperty.EmailInfo, CommProperty.InputCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtEmail.Focus();
                return false;
            }
            if (TxtIdentityCard.Text.Trim().Length == 0)
            {
                MessageBox.Show(CommProperty.IdentityCardInfo, CommProperty.InputCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtIdentityCard.Focus();
                return false;
            }

            return true;
        }
        #endregion
        #region 綁定年級
        /// <summary>
        /// 綁定年級
        /// </summary>
        private void GradeDataBind()
        {

            try
            {
                List<Grade> grades = gradeManage.GetGrades();
                CbGradeId.DataSource = grades;
                CbGradeId.DisplayMember = "GradeName";
                CbGradeId.ValueMember = "GradeId";
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message,CommProperty.InputCaption,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        #endregion
        #region 窗體加載
        /// <summary>
        /// 窗體加載
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAddStudent_Load(object sender, EventArgs e)
        {
            GradeDataBind();//窗體加載綁定年級信息
        }
        #endregion
        /// <summary>
        /// 把創建的實例存放到靜態變量frmAddStudent裡面了
        /// 如果有很多個類似他窗體，我們需要在每個窗體裡面寫這些代碼，那是非常不合適的
        /// 如果學到泛型類，可以解決問題。
        /// </summary>
        private static FrmAddStudent frmAddStudent = null; //定義窗體變量
        public static FrmAddStudent CreateInstance()
        {
            if (frmAddStudent == null || frmAddStudent.IsDisposed)
            {
                //創建實例
                 frmAddStudent = new FrmAddStudent();

            }
            return frmAddStudent;
        }

    }
}
