
namespace 基本資料查詢.AdminForm
{
    partial class FrmAdminMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminMain));
            this.MsMenu = new System.Windows.Forms.MenuStrip();
            this.TsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.TmsiQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.TsMenu = new System.Windows.Forms.ToolStrip();
            this.TsbAddStudent = new System.Windows.Forms.ToolStripButton();
            this.TsbManageStudent = new System.Windows.Forms.ToolStripButton();
            this.TsbSearchStudent = new System.Windows.Forms.ToolStripButton();
            this.TsbResultSearchStudent = new System.Windows.Forms.ToolStripButton();
            this.TsbManageTeacher = new System.Windows.Forms.ToolStripButton();
            this.MsMenu.SuspendLayout();
            this.TsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MsMenu
            // 
            this.MsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiHelp,
            this.TmsiQuit});
            this.MsMenu.Location = new System.Drawing.Point(0, 0);
            this.MsMenu.Name = "MsMenu";
            this.MsMenu.Size = new System.Drawing.Size(800, 24);
            this.MsMenu.TabIndex = 0;
            this.MsMenu.Text = "menuStrip1";
            // 
            // TsmiHelp
            // 
            this.TsmiHelp.Name = "TsmiHelp";
            this.TsmiHelp.Size = new System.Drawing.Size(43, 20);
            this.TsmiHelp.Text = "幫助";
            // 
            // TmsiQuit
            // 
            this.TmsiQuit.Name = "TmsiQuit";
            this.TmsiQuit.Size = new System.Drawing.Size(43, 20);
            this.TmsiQuit.Text = "退出";
            this.TmsiQuit.Click += new System.EventHandler(this.TmsiQuit_Click);
            // 
            // TsMenu
            // 
            this.TsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbAddStudent,
            this.TsbManageStudent,
            this.TsbSearchStudent,
            this.TsbResultSearchStudent,
            this.TsbManageTeacher});
            this.TsMenu.Location = new System.Drawing.Point(0, 24);
            this.TsMenu.Name = "TsMenu";
            this.TsMenu.Size = new System.Drawing.Size(800, 25);
            this.TsMenu.TabIndex = 1;
            this.TsMenu.Text = "toolStrip1";
            // 
            // TsbAddStudent
            // 
            this.TsbAddStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsbAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("TsbAddStudent.Image")));
            this.TsbAddStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbAddStudent.Name = "TsbAddStudent";
            this.TsbAddStudent.Size = new System.Drawing.Size(83, 22);
            this.TsbAddStudent.Text = "新建學生用戶";
            this.TsbAddStudent.Click += new System.EventHandler(this.TsbAddStudent_Click);
            // 
            // TsbManageStudent
            // 
            this.TsbManageStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsbManageStudent.Image = ((System.Drawing.Image)(resources.GetObject("TsbManageStudent.Image")));
            this.TsbManageStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbManageStudent.Name = "TsbManageStudent";
            this.TsbManageStudent.Size = new System.Drawing.Size(83, 22);
            this.TsbManageStudent.Text = "學生信息管理";
            // 
            // TsbSearchStudent
            // 
            this.TsbSearchStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsbSearchStudent.Image = ((System.Drawing.Image)(resources.GetObject("TsbSearchStudent.Image")));
            this.TsbSearchStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbSearchStudent.Name = "TsbSearchStudent";
            this.TsbSearchStudent.Size = new System.Drawing.Size(83, 22);
            this.TsbSearchStudent.Text = "查詢學生信息";
            // 
            // TsbResultSearchStudent
            // 
            this.TsbResultSearchStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsbResultSearchStudent.Image = ((System.Drawing.Image)(resources.GetObject("TsbResultSearchStudent.Image")));
            this.TsbResultSearchStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbResultSearchStudent.Name = "TsbResultSearchStudent";
            this.TsbResultSearchStudent.Size = new System.Drawing.Size(83, 22);
            this.TsbResultSearchStudent.Text = "查詢學生成績";
            // 
            // TsbManageTeacher
            // 
            this.TsbManageTeacher.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsbManageTeacher.Image = ((System.Drawing.Image)(resources.GetObject("TsbManageTeacher.Image")));
            this.TsbManageTeacher.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbManageTeacher.Name = "TsbManageTeacher";
            this.TsbManageTeacher.Size = new System.Drawing.Size(83, 22);
            this.TsbManageTeacher.Text = "教師信息管理";
            // 
            // FrmAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TsMenu);
            this.Controls.Add(this.MsMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MsMenu;
            this.Name = "FrmAdminMain";
            this.Text = "管理員窗體主界面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAdminMain_FormClosing);
            this.MsMenu.ResumeLayout(false);
            this.MsMenu.PerformLayout();
            this.TsMenu.ResumeLayout(false);
            this.TsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MsMenu;
        private System.Windows.Forms.ToolStripMenuItem TsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem TmsiQuit;
        private System.Windows.Forms.ToolStrip TsMenu;
        private System.Windows.Forms.ToolStripButton TsbAddStudent;
        private System.Windows.Forms.ToolStripButton TsbManageStudent;
        private System.Windows.Forms.ToolStripButton TsbSearchStudent;
        private System.Windows.Forms.ToolStripButton TsbResultSearchStudent;
        private System.Windows.Forms.ToolStripButton TsbManageTeacher;
    }
}