using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace WaterMark
{
    public partial class NetImage : Office2007Form
    {
        public NetImage()
        {
            InitializeComponent();
            this.EnableGlass = false;
        }

        private void btnSaveImg_Click(object sender, EventArgs e)
        {
            var imgUrl = txtImgUrl.Text.Trim();

            SaveFileFromUrl(@"d:\whatfuck\", "ceshi", imgUrl);
        }
        /// <summary>
        ///  从URL地址下载文件到本地磁盘
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="FileName"></param>
        /// <param name="Url"></param>
        /// <returns></returns>
        public long SaveFileFromUrl(string Path, string FileName, string Url)
        {
            long Value = 0;
            Bitmap img = null;
            WebResponse response = null;
            Stream stream = null;

            try
            {
                if (!Directory.Exists(Path))//加完水印后新建一个目标
                {
                    Directory.CreateDirectory(Path);
                }
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);

                response = request.GetResponse();
                stream = response.GetResponseStream();

                if (!response.ContentType.ToLower().StartsWith("text/"))
                {
                    string fileName1 = FileName + DateTime.Now.ToFileTime().ToString();
                    string savepath = Path + fileName1 + ".jpg";
                    img = new Bitmap(stream);//获取图片流                 
                    img.Save(savepath);//随机名

                    string logo = txtIconUrl.Text;
                    NetImgWaterMarkService.AddPicWatermarkAsJPG(savepath, logo);
                }
            }
            catch (Exception err)
            {
                Value = 0;
                string aa = err.ToString();
                return Value;
            }
            return Value;
        }


        private void SaveImgToDisk()
        {
            try
            {
                //img = new Bitmap(res.GetResponseStream());//获取图片流                 
                //img.Save(@"E:/" + DateTime.Now.ToFileTime().ToString() + ".png");//随机名
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void btnWaterIcon_Click(object sender, EventArgs e)
        {
            openfileDialog.InitialDirectory = @"c:\";

            openfileDialog.RestoreDirectory = true;//保存上一次记录
            openfileDialog.Filter = "jpg文件(*.jpg)|*.jpg|png文件(*.png)|*.png|tif文件(*.tif)|*.tif|gif文件(*.gif)|*.gif";
            openfileDialog.ShowDialog(this);
            txtIconUrl.Text = openfileDialog.FileName;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            openfileDialog.InitialDirectory = @"c:\";

            openfileDialog.RestoreDirectory = true;//保存上一次记录
            openfileDialog.Filter = "jpg文件(*.jpg)|*.jpg|png文件(*.png)|*.png|tif文件(*.tif)|*.tif|gif文件(*.gif)|*.gif";
            openfileDialog.ShowDialog(this);
            localImgUrl.Text = openfileDialog.FileName;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {
                string savePath = localImgUrl.Text;
                string logo = txtIconUrl.Text;
                NetImgWaterMarkService.AddPicWatermarkAsJPG(savePath, logo);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
