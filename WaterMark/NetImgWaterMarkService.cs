using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterMark
{
    public class NetImgWaterMarkService
    {
        /// <summary>
        /// 给图片添加图片水印
        /// </summary>
        /// <param name="sourcePath">源图片的存储地址</param>
        /// <param name="watermarkPath">水印图片的物理地址</param>
        /// <param name="saveFilePath">目标图片的存储地址</param>
        /// <param name="mp">水印位置</param>
        public static void AddPicWatermarkAsJPG(string sourcePath, string watermarkPath)
        {
            if (File.Exists(sourcePath))
            {
                //实例化一个文件流 
                FileStream fs = new FileStream(sourcePath, FileMode.Open);
                //把文件读取到字节数组 
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, data.Length);
                fs.Close();

                //实例化一个内存流--->把从文件流中读取的内容[字节数组]放到内存流中去 
                MemoryStream ms = new MemoryStream(data);
                AddPicWatermarkAsJPG(ms, watermarkPath, sourcePath);
                //using (StreamReader sr = new StreamReader(sourcePath))
                //{
                //    AddPicWatermarkAsJPG(sr.BaseStream, watermarkPath, sourcePath);
                //}
            }
        }

        /// <summary>
        /// 给图片添加图片水印
        /// </summary>
        /// <param name="inputStream">包含要源图片的流</param>
        /// <param name="watermarkPath">水印图片的物理地址</param>
        /// <param name="sourcePath">目标图片的存储地址</param>
        /// <param name="mp">水印位置</param>
        public static void AddPicWatermarkAsJPG(Stream inputStream, string watermarkPath, string sourcePath)
        {

            Image image = Image.FromStream(inputStream);
            Bitmap b = new Bitmap(image.Width, image.Height, PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(b);
            //g.Clear(Color.White);
            g.Clear(Color.Transparent);
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.High;
            g.DrawImage(image, 0, 0, image.Width, image.Height);

            AddWatermarkImage(g, watermarkPath,image.Width, image.Height);

            try
            {
                //string savefolderPath = Path.GetDirectoryName(sourcePath);
                //string fileName = Path.GetFileNameWithoutExtension(sourcePath);
                
             //   string newWaterMarkImgPath = savefolderPath +"/" +fileName + "-w" + ".jpg";
                //CompressAsJPG(b, newWaterMarkImgPath, 80);
                //b.Save(newWaterMarkImgPath, ImageFormat.Jpeg);
                b.Save(sourcePath, ImageFormat.Jpeg);
            }
            catch
            {
                throw new Exception("图片压缩数据有问题");
            }
            finally
            {
                b.Dispose();
                image.Dispose();
            }
        }

        /// <summary>
        /// 将Bitmap对象压缩为JPG图片类型
        /// </summary>
        /// </summary>
        /// <param name="bmp">源bitmap对象</param>
        /// <param name="saveFilePath">目标图片的存储地址</param>
        /// <param name="quality">压缩质量，越大照片越清晰，推荐80</param>
        public static void CompressAsJPG(Bitmap bmp, string saveFilePath, int quality)
        {
            //EncoderParameter p = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality); ;
            //EncoderParameters ps = new EncoderParameters(1);
            //ps.Param[0] = p;
           
            bmp.Save(saveFilePath,ImageFormat.Jpeg);
            bmp.Dispose();
        }

        /// <summary>
        /// 获取指定mimeType的ImageCodecInfo
        /// </summary>
        private static ImageCodecInfo GetImageCodecInfo(string mimeType)
        {
            ImageCodecInfo[] CodecInfo = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo ici in CodecInfo)
            {
                if (ici.MimeType == mimeType) return ici;
            }
            return null;
        }
        /// <summary>
        /// 添加图片水印
        /// </summary>
        /// <param name="picture">要加水印的原图像</param>
        /// <param name="waterMarkPath">水印文件的物理地址</param>
        /// <param name="mp">添加的位置</param>
        /// <param name="width">原图像的宽度</param>
        /// <param name="height">原图像的高度</param>
        private static void AddWatermarkImage(Graphics picture, string waterMarkPath,int width, int height)
        {
            Image watermark = new Bitmap(waterMarkPath);

            ImageAttributes imageAttributes = new ImageAttributes();
            ColorMap colorMap = new ColorMap();

            colorMap.OldColor = Color.FromArgb(255, 0, 255, 0);
            colorMap.NewColor = Color.FromArgb(0, 0, 0, 0);
            ColorMap[] remapTable = { colorMap };

            imageAttributes.SetRemapTable(remapTable, ColorAdjustType.Bitmap);

            //float[][] colorMatrixElements = {
            //                                     new float[] {1.0f,  0.0f,  0.0f,  0.0f, 0.0f},
            //                                     new float[] {0.0f,  1.0f,  0.0f,  0.0f, 0.0f},
            //                                     new float[] {0.0f,  0.0f,  1.0f,  0.0f, 0.0f},
            //                                     new float[] {0.0f,  0.0f,  0.0f,  0.3f, 0.0f},
            //                                     new float[] {0.0f,  0.0f,  0.0f,  0.0f, 1.0f}
            //                                };
            float[][] matrixItems =  
           {  
               new float[]{1,0,0,0,0},  
               new float[]{0,1,0,0,0},  
               new float[]{0,0,1,0,0},  
               new float[]{0,0,0,255f,0},  
               new float[]{0,0,0,0,1}  
           };
            ColorMatrix colorMatrix = new ColorMatrix(matrixItems);

            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            int xpos = 0;
            int ypos = 0;
            int markWidth = 0;
            int markHeight = 0;
            double bl = 1d;

            //水印按照原始图片比例添加
            //if ((width > watermark.Width * 4) && (height > watermark.Height * 4))
            //{
            //    bl = 1;
            //}
            //else if ((width > watermark.Width * 4) && (height < watermark.Height * 4))
            //{
            //    bl = Convert.ToDouble(height / 4) / Convert.ToDouble(watermark.Height);

            //}
            //else

            //    if ((width < watermark.Width * 4) && (height > watermark.Height * 4))
            //    {
            //        bl = Convert.ToDouble(width / 4) / Convert.ToDouble(watermark.Width);
            //    }
            //    else
            //    {
            //        if ((width * watermark.Height) > (height * watermark.Width))
            //        {
            //            bl = Convert.ToDouble(height / 4) / Convert.ToDouble(watermark.Height);

            //        }
            //        else
            //        {
            //            bl = Convert.ToDouble(width / 4) / Convert.ToDouble(watermark.Width);

            //        }

            //    }

            markWidth = Convert.ToInt32(watermark.Width * bl);
            markHeight = Convert.ToInt32(watermark.Height * bl);

            xpos = width - markWidth - 10;
            ypos = height - markHeight - 10;
      
            picture.DrawImage(watermark, new Rectangle(xpos, ypos, markWidth, markHeight), 0, 0, watermark.Width, watermark.Height, GraphicsUnit.Pixel, imageAttributes);
            watermark.Dispose();
            imageAttributes.Dispose();
        }
    }
}
