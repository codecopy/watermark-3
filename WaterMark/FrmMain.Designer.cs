namespace WaterMark
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbWaterPicType = new System.Windows.Forms.RadioButton();
            this.rbWaterTextType = new System.Windows.Forms.RadioButton();
            this.lblWaterPic = new System.Windows.Forms.Label();
            this.txtWaterLogo = new System.Windows.Forms.TextBox();
            this.btnAddLogo = new System.Windows.Forms.Button();
            this.chbIsBatch = new System.Windows.Forms.CheckBox();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblWaterText = new System.Windows.Forms.Label();
            this.txtWaterText = new System.Windows.Forms.TextBox();
            this.btnNetImg = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(485, 90);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(99, 23);
            this.btnBrowser.TabIndex = 0;
            this.btnBrowser.Text = "浏览原始图";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(97, 91);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(372, 21);
            this.txtFile.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(202, 268);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "提交处理";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "原图片路径";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "水印位置";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "水印类型";
            // 
            // rbWaterPicType
            // 
            this.rbWaterPicType.AutoSize = true;
            this.rbWaterPicType.Location = new System.Drawing.Point(175, 12);
            this.rbWaterPicType.Name = "rbWaterPicType";
            this.rbWaterPicType.Size = new System.Drawing.Size(71, 16);
            this.rbWaterPicType.TabIndex = 13;
            this.rbWaterPicType.Text = "图片水印";
            this.rbWaterPicType.UseVisualStyleBackColor = true;
            this.rbWaterPicType.CheckedChanged += new System.EventHandler(this.rbWaterPicType_CheckedChanged);
            // 
            // rbWaterTextType
            // 
            this.rbWaterTextType.AutoSize = true;
            this.rbWaterTextType.Checked = true;
            this.rbWaterTextType.Location = new System.Drawing.Point(99, 12);
            this.rbWaterTextType.Name = "rbWaterTextType";
            this.rbWaterTextType.Size = new System.Drawing.Size(71, 16);
            this.rbWaterTextType.TabIndex = 12;
            this.rbWaterTextType.TabStop = true;
            this.rbWaterTextType.Text = "文本水印";
            this.rbWaterTextType.UseVisualStyleBackColor = true;
            this.rbWaterTextType.CheckedChanged += new System.EventHandler(this.rbWaterPicType_CheckedChanged);
            // 
            // lblWaterPic
            // 
            this.lblWaterPic.AutoSize = true;
            this.lblWaterPic.Enabled = false;
            this.lblWaterPic.Location = new System.Drawing.Point(42, 153);
            this.lblWaterPic.Name = "lblWaterPic";
            this.lblWaterPic.Size = new System.Drawing.Size(53, 12);
            this.lblWaterPic.TabIndex = 16;
            this.lblWaterPic.Text = "水印图片";
            // 
            // txtWaterLogo
            // 
            this.txtWaterLogo.Enabled = false;
            this.txtWaterLogo.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.txtWaterLogo.Location = new System.Drawing.Point(97, 148);
            this.txtWaterLogo.Name = "txtWaterLogo";
            this.txtWaterLogo.Size = new System.Drawing.Size(372, 21);
            this.txtWaterLogo.TabIndex = 15;
            // 
            // btnAddLogo
            // 
            this.btnAddLogo.Enabled = false;
            this.btnAddLogo.Location = new System.Drawing.Point(485, 146);
            this.btnAddLogo.Name = "btnAddLogo";
            this.btnAddLogo.Size = new System.Drawing.Size(99, 23);
            this.btnAddLogo.TabIndex = 17;
            this.btnAddLogo.Text = "浏览水印图片";
            this.btnAddLogo.UseVisualStyleBackColor = true;
            this.btnAddLogo.Click += new System.EventHandler(this.btnAddLogo_Click);
            // 
            // chbIsBatch
            // 
            this.chbIsBatch.AutoSize = true;
            this.chbIsBatch.Location = new System.Drawing.Point(248, 49);
            this.chbIsBatch.Name = "chbIsBatch";
            this.chbIsBatch.Size = new System.Drawing.Size(96, 16);
            this.chbIsBatch.TabIndex = 18;
            this.chbIsBatch.Text = "是否批量处理";
            this.chbIsBatch.UseVisualStyleBackColor = true;
            this.chbIsBatch.CheckedChanged += new System.EventHandler(this.chbIsBatch_CheckedChanged);
            // 
            // cbPosition
            // 
            this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "左上角",
            "左下角",
            "右上角",
            "右下角",
            "中间"});
            this.cbPosition.Location = new System.Drawing.Point(99, 45);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(94, 20);
            this.cbPosition.TabIndex = 19;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(336, 268);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "关闭退出";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblWaterText
            // 
            this.lblWaterText.AutoSize = true;
            this.lblWaterText.Location = new System.Drawing.Point(42, 202);
            this.lblWaterText.Name = "lblWaterText";
            this.lblWaterText.Size = new System.Drawing.Size(53, 12);
            this.lblWaterText.TabIndex = 22;
            this.lblWaterText.Text = "水印文字";
            // 
            // txtWaterText
            // 
            this.txtWaterText.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.txtWaterText.Location = new System.Drawing.Point(97, 198);
            this.txtWaterText.Name = "txtWaterText";
            this.txtWaterText.Size = new System.Drawing.Size(267, 21);
            this.txtWaterText.TabIndex = 21;
            // 
            // btnNetImg
            // 
            this.btnNetImg.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNetImg.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNetImg.Location = new System.Drawing.Point(485, 267);
            this.btnNetImg.Name = "btnNetImg";
            this.btnNetImg.Size = new System.Drawing.Size(75, 23);
            this.btnNetImg.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNetImg.TabIndex = 23;
            this.btnNetImg.Text = "网络图片";
            this.btnNetImg.Click += new System.EventHandler(this.btnNetImg_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 339);
            this.Controls.Add(this.btnNetImg);
            this.Controls.Add(this.lblWaterText);
            this.Controls.Add(this.txtWaterText);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.chbIsBatch);
            this.Controls.Add(this.btnAddLogo);
            this.Controls.Add(this.lblWaterPic);
            this.Controls.Add(this.txtWaterLogo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbWaterPicType);
            this.Controls.Add(this.rbWaterTextType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnBrowser);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图片加水印功能";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbWaterPicType;
        private System.Windows.Forms.RadioButton rbWaterTextType;
        private System.Windows.Forms.Label lblWaterPic;
        private System.Windows.Forms.TextBox txtWaterLogo;
        private System.Windows.Forms.Button btnAddLogo;
        private System.Windows.Forms.CheckBox chbIsBatch;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblWaterText;
        private System.Windows.Forms.TextBox txtWaterText;
        private DevComponents.DotNetBar.ButtonX btnNetImg;
    }
}

