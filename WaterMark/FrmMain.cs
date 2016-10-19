using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DevComponents.DotNetBar;

namespace WaterMark
{
    public partial class FrmMain : Office2007Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.EnableGlass = false;
        }

        private string fileName = string.Empty;//源文件包含路径
        private string logo = string.Empty;//图标水印文件
        private string[] files = null;//批量处理时文件组

        /// <summary>
        /// 窗体加载时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            cbPosition.SelectedItem = "中间";
        }

        /// <summary>
        /// 浏览图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowser_Click(object sender, EventArgs e)
        {
            openFileDlg.InitialDirectory = @"c:\";
            openFileDlg.Filter = "jpg文件(*.jpg)|*.jpg|png文件(*.png)|*.png|bmp文件(*.bmp)|*.bmp|gif文件(*.gif)|*.gif";
            openFileDlg.RestoreDirectory = true;//保存上一次记录
            openFileDlg.ShowDialog(this);
            setBatch();
        }

        /// <summary>
        /// 提交数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            string waterText = txtWaterText.Text;
            
            logo = txtWaterLogo.Text;
            if (!File.Exists(fileName))
            {
                MessageBox.Show(this, "原图片文件不存在!");
                txtFile.Focus();
                return;
            }

            if (rbWaterTextType.Checked && string.IsNullOrEmpty(waterText))
            {
                MessageBox.Show(this, "水印文字不能为空!");
                txtWaterText.Focus();
                return;
            }
            if (rbWaterPicType.Checked && string.IsNullOrEmpty(logo))
            {
                txtWaterLogo.Focus();
                MessageBox.Show(this, "选择图片水印类型，水印图不能为空！");
                return;
            }
            string savePath = string.Empty;
            string saveFold = string.Empty;
            string sFile = string.Empty; //openFileDlg.SafeFileName;//不带路径的文件名
            string newFold = "_AddWater";//新文件夹名称

            int len = fileName.Length;
            int index = fileName.LastIndexOf("\\");
            if (index > -1 && len > index)
            {
                sFile = fileName.Substring(index + 1, len - index-1);
            }
            string basePath = fileName.Substring(0, index);//基路径

            //选择位置
            ImageWater.MarkPosition position = ImageWater.MarkPosition.MP_Left_Bottom;
            position = (ImageWater.MarkPosition)(cbPosition.SelectedIndex + 1);
            try
            {
                saveFold = basePath + "\\" + newFold;
                if (!Directory.Exists(saveFold))//加完水印后新建一个目标
                {
                    Directory.CreateDirectory(saveFold);
                }
                if (chbIsBatch.Checked)//批量处理了
                {
                    foreach (string file in files)
                    {
                        len = file.Length;
                        sFile = file.Substring(index, len - index);
                        savePath = saveFold + sFile;//带\\sdd.jpg";

                        if (rbWaterPicType.Checked)//图片水印
                        {
                            ImageWater.AddPicWatermarkAsJPG(fileName, logo, savePath, position);
                        }
                        else
                        {
                            ImageWater.AddTextWatermarkAsJPG(fileName, waterText, savePath, position);
                        }
                    }
                }
                else
                {
                    savePath = saveFold + "\\" + sFile;
                    if (rbWaterPicType.Checked)//图片水印
                    {
                        ImageWater.AddPicWatermarkAsJPG(fileName, logo, savePath, position);
                    }
                    else
                    {
                        ImageWater.AddTextWatermarkAsJPG(fileName, waterText, savePath, position);
                    }
                }

                MessageBox.Show(this, "操作成功，保存在文件夹：" + saveFold);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "操作失败!" + ex.Message);
            }
        }
       
        /// <summary>
        /// 设置批量处理的时
        /// </summary>
        private void setBatch()
        {
            openFileDlg.Multiselect = chbIsBatch.Checked;
            txtFile.Text = fileName = openFileDlg.FileName;
            if (chbIsBatch.Checked)
            {
                files = openFileDlg.FileNames;
                string temp = string.Empty;
                foreach (string file in files)
                {
                    temp += file + "|";
                }
                if (temp.IndexOf("|") > 0)
                {
                    txtFile.Text = temp.TrimEnd('|');
                }
            }
        }

        /// <summary>
        /// 选择图片类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbWaterPicType_CheckedChanged(object sender, EventArgs e)
        {
            txtWaterText.Enabled = rbWaterTextType.Checked;
            lblWaterText.Enabled = rbWaterTextType.Checked;
            lblWaterPic.Enabled = rbWaterPicType.Checked;
            txtWaterLogo.Enabled = rbWaterPicType.Checked;
            btnAddLogo.Enabled = rbWaterPicType.Checked;
        }

        /// <summary>
        /// 浏览图片水印图片按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddLogo_Click(object sender, EventArgs e)
        {
            openFileDlg.InitialDirectory = @"c:\";

            openFileDlg.RestoreDirectory = true;//保存上一次记录
            openFileDlg.Filter = "jpg文件(*.jpg)|*.jpg|png文件(*.png)|*.png|tif文件(*.tif)|*.tif|gif文件(*.gif)|*.gif";
            openFileDlg.ShowDialog(this);
            logo = txtWaterLogo.Text = openFileDlg.FileName;
        }

        /// <summary>
        /// 是否点击批量处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chbIsBatch_CheckedChanged(object sender, EventArgs e)
        {
            setBatch();
        }


        /// <summary>
        /// 关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            WinClose();
        }
        /// <summary>
        /// 关闭事件
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosing(CancelEventArgs e)
        {
            WinClose();
        }
        private void WinClose()
        {
            this.Dispose();
            Application.Exit();
        }

        private void btnNetImg_Click(object sender, EventArgs e)
        {
            NetImage netImage=new NetImage();
            netImage.Show();
        }

    }
}
