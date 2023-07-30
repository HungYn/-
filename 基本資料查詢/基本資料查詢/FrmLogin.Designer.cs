
namespace 基本資料查詢
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCancle = new System.Windows.Forms.Button();
            this.BtnOK = new System.Windows.Forms.Button();
            this.CboType = new System.Windows.Forms.ComboBox();
            this.TxtPwd = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PlTitle = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::基本資料查詢.Properties.Resources.未命名設計;
            this.panel1.Controls.Add(this.BtnCancle);
            this.panel1.Controls.Add(this.BtnOK);
            this.panel1.Controls.Add(this.CboType);
            this.panel1.Controls.Add(this.TxtPwd);
            this.panel1.Controls.Add(this.TxtName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 159);
            this.panel1.TabIndex = 1;
            // 
            // BtnCancle
            // 
            this.BtnCancle.Location = new System.Drawing.Point(183, 124);
            this.BtnCancle.Name = "BtnCancle";
            this.BtnCancle.Size = new System.Drawing.Size(75, 23);
            this.BtnCancle.TabIndex = 6;
            this.BtnCancle.Text = "取消";
            this.BtnCancle.UseVisualStyleBackColor = true;
            this.BtnCancle.Click += new System.EventHandler(this.BtnCancle_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(102, 124);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 5;
            this.BtnOK.Text = "確定";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // CboType
            // 
            this.CboType.FormattingEnabled = true;
            this.CboType.Items.AddRange(new object[] {
            "管理員",
            "學生"});
            this.CboType.Location = new System.Drawing.Point(107, 84);
            this.CboType.Name = "CboType";
            this.CboType.Size = new System.Drawing.Size(151, 20);
            this.CboType.TabIndex = 4;
            // 
            // TxtPwd
            // 
            this.TxtPwd.Location = new System.Drawing.Point(107, 55);
            this.TxtPwd.Name = "TxtPwd";
            this.TxtPwd.PasswordChar = '*';
            this.TxtPwd.Size = new System.Drawing.Size(151, 22);
            this.TxtPwd.TabIndex = 3;
            this.TxtPwd.Text = "123456";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(107, 22);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(151, 22);
            this.TxtName.TabIndex = 2;
            this.TxtName.Text = "admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(45, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "密   碼";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(44, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "用戶名";
            // 
            // PlTitle
            // 
            this.PlTitle.BackgroundImage = global::基本資料查詢.Properties.Resources.未命名_1;
            this.PlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlTitle.Location = new System.Drawing.Point(0, 0);
            this.PlTitle.Name = "PlTitle";
            this.PlTitle.Size = new System.Drawing.Size(320, 23);
            this.PlTitle.TabIndex = 0;
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 182);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用戶登入";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PlTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCancle;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.ComboBox CboType;
        private System.Windows.Forms.TextBox TxtPwd;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}