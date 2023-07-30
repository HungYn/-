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

namespace 基本資料查詢.AdminForm
{
    /// <summary>
    /// 管理員主窗體界面
    /// </summary>
    public partial class FrmAdminMain : Form
    {
        #region 構造函數
        /// <summary>
        /// 構造函數
        /// </summary>
        public FrmAdminMain()
        {
            InitializeComponent();
        } 
        #endregion
        #region 退出系統
        /// <summary>
        /// 退出系統
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TmsiQuit_Click(object sender, EventArgs e)
        {
            QuitSystem();
        }
        #endregion

        #region 退出系統附程式
        /// <summary>
        /// 退出系統附程式
        /// </summary>
        private void QuitSystem()
        {
            DialogResult dR = MessageBox.Show(CommProperty.QuitSystemInfo, CommProperty.InputCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dR == DialogResult.OK)
            {
                Application.ExitThread();
            }
        }
        #endregion

        #region 關閉窗體
        /// <summary>
        /// 關閉窗體
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAdminMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dR = MessageBox.Show(CommProperty.QuitSystemInfo, CommProperty.InputCaption, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dR == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                Application.ExitThread();
            }
        }
        #endregion

        #region 新建學生用戶信息
        /// <summary>
        /// 新建學生用戶信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsbAddStudent_Click(object sender, EventArgs e)
        {
            ////if(FormIsOpen("FrmAddStudent")) return; //第一種寫法
            //if(FormIsOpen(typeof(FrmAddStudent).Name)) return; //第二種寫法
            //FrmAddStudent frmAddStudent = new FrmAddStudent();
            ////FrmAddStudent frmAddStudent =  FrmAddStudent.CreateInstance();//第三種寫法
            //frmAddStudent.MdiParent = this;  //設置父窗體為FrmAddStudent窗體的父親
            //frmAddStudent.Show();

            //if(FormIsOpen("FrmAddStudent")) return; //第一種寫法
            if (FormIsOpen(typeof(FrmAddStudent).Name)) return; //第二種寫法
            FrmAddStudent frmAddStudent = new FrmAddStudent
            {
                //FrmAddStudent frmAddStudent =  FrmAddStudent.CreateInstance();//第三種寫法
                MdiParent = this  //設置父窗體為FrmAddStudent窗體的父親
            };
            frmAddStudent.Show();

        }
        #endregion

        #region 第一種方法判斷已知窗體是否打開
        //原理就是判斷該窗體是否已經打開了，如果打開了，就不要在創建該窗體的實例
        /// <summary>
        /// 第一種方法判斷已知窗體是否打開
        /// </summary>
        /// <param name="frmName">窗體的名字</param>
        /// <returns>True:証明窗體已經打開,False:証明窗體還末創建過</returns>
        private bool FormIsOpen(string frmName)
        {
            bool bRet = false;
            foreach (Form frm in Application.OpenForms)
            {
                if (frmName == frm.Name)
                {
                    bRet = true; //找到了已經打開以frmName命名的窗體
                    break;
                }
            }
            return bRet;

        } 
        #endregion
    }
}
