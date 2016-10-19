namespace WaterMark
{
    partial class NetImage
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
            this.txtImgUrl = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSaveImg = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnWaterIcon = new DevComponents.DotNetBar.ButtonX();
            this.txtIconUrl = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.openfileDialog = new System.Windows.Forms.OpenFileDialog();
            this.localImgUrl = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // txtImgUrl
            // 
            // 
            // 
            // 
            this.txtImgUrl.Border.Class = "TextBoxBorder";
            this.txtImgUrl.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtImgUrl.Location = new System.Drawing.Point(137, 12);
            this.txtImgUrl.Name = "txtImgUrl";
            this.txtImgUrl.PreventEnterBeep = true;
            this.txtImgUrl.Size = new System.Drawing.Size(659, 21);
            this.txtImgUrl.TabIndex = 0;
            this.txtImgUrl.Text = "http://img2.3lian.com/2014/f7/5/d/23.jpg";
            // 
            // btnSaveImg
            // 
            this.btnSaveImg.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveImg.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSaveImg.Location = new System.Drawing.Point(88, 152);
            this.btnSaveImg.Name = "btnSaveImg";
            this.btnSaveImg.Size = new System.Drawing.Size(190, 23);
            this.btnSaveImg.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSaveImg.TabIndex = 1;
            this.btnSaveImg.Text = "保存网络图片";
            this.btnSaveImg.Click += new System.EventHandler(this.btnSaveImg_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(3, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(98, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "图片网络地址：";
            // 
            // btnWaterIcon
            // 
            this.btnWaterIcon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnWaterIcon.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnWaterIcon.Location = new System.Drawing.Point(3, 67);
            this.btnWaterIcon.Name = "btnWaterIcon";
            this.btnWaterIcon.Size = new System.Drawing.Size(75, 23);
            this.btnWaterIcon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnWaterIcon.TabIndex = 3;
            this.btnWaterIcon.Text = "浏览水印";
            this.btnWaterIcon.Click += new System.EventHandler(this.btnWaterIcon_Click);
            // 
            // txtIconUrl
            // 
            // 
            // 
            // 
            this.txtIconUrl.Border.Class = "TextBoxBorder";
            this.txtIconUrl.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIconUrl.Location = new System.Drawing.Point(137, 68);
            this.txtIconUrl.Name = "txtIconUrl";
            this.txtIconUrl.PreventEnterBeep = true;
            this.txtIconUrl.Size = new System.Drawing.Size(603, 21);
            this.txtIconUrl.TabIndex = 4;
            // 
            // openfileDialog
            // 
            this.openfileDialog.FileName = "openFileDialog1";
            // 
            // localImgUrl
            // 
            // 
            // 
            // 
            this.localImgUrl.Border.Class = "TextBoxBorder";
            this.localImgUrl.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.localImgUrl.Location = new System.Drawing.Point(137, 118);
            this.localImgUrl.Name = "localImgUrl";
            this.localImgUrl.PreventEnterBeep = true;
            this.localImgUrl.Size = new System.Drawing.Size(603, 21);
            this.localImgUrl.TabIndex = 6;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(3, 115);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(98, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 7;
            this.buttonX1.Text = "浏览本地图片";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(371, 151);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(187, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 8;
            this.buttonX2.Text = "修改本地图片";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // NetImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 287);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.localImgUrl);
            this.Controls.Add(this.txtIconUrl);
            this.Controls.Add(this.btnWaterIcon);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnSaveImg);
            this.Controls.Add(this.txtImgUrl);
            this.DoubleBuffered = true;
            this.Name = "NetImage";
            this.Text = "NetImage";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtImgUrl;
        private DevComponents.DotNetBar.ButtonX btnSaveImg;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnWaterIcon;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIconUrl;
        private System.Windows.Forms.OpenFileDialog openfileDialog;
        private DevComponents.DotNetBar.Controls.TextBoxX localImgUrl;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;

    }
}