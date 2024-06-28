using AForge.Video.DirectShow;
using AForge.Video;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Controls;
using System.IO;
using System.Drawing.Imaging;

namespace Kivii.Client.SamplePhoto
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private FilterInfoCollection cameras;
        private VideoCaptureDevice videoSource;
        private int currentCameraIndex = 0;
        private List<Photo> photoCollection = new List<Photo>();
        private void TakeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (videoSource != null && videoSource.IsRunning)
                {
                    Bitmap bitmap = videoSourcePlayer1.GetCurrentVideoFrame();
                    displayPictureBox.Image = bitmap;

                    // 创建图片 PictureBox 控件
                    System.Windows.Forms.PictureBox pictureBox = new System.Windows.Forms.PictureBox();
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Dock = DockStyle.Fill;
                    pictureBox.Image = bitmap;

                    // 添加图片点击动作
                    pictureBox.Click += PictureBox_Click;

                    // 创建图片名称的 Label 控件
                    Label nameLabel = new Label();
                    String name = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
                    nameLabel.Text = name;
                    nameLabel.Dock = DockStyle.Fill;
                    nameLabel.TextAlign = ContentAlignment.MiddleCenter;

                    // 创建 SplitContainer 控件
                    SplitContainer splitContainer = new SplitContainer();
                    splitContainer.Size = new Size(220, 140);
                    splitContainer.BackColor = SystemColors.ControlLight;
                    splitContainer.Orientation = Orientation.Horizontal;
                    splitContainer.SplitterWidth = 1;
                    splitContainer.SplitterDistance = 90;
                    splitContainer.Panel1.Controls.Add(pictureBox);
                    splitContainer.Panel2.Controls.Add(nameLabel);

                    // 将 SplitContainer 添加到 FlowLayoutPanel 中
                    PhotoPanel.Controls.Add(splitContainer);

                    // 将拍摄的照片对象添加到集合中
                    photoCollection.Add(new Photo(bitmap, name));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("无法拍照" + ex.Message);
            }

        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            // 获取点击的 PictureBox 中的图片
            System.Windows.Forms.PictureBox pictureBox = (System.Windows.Forms.PictureBox)sender;

            // 在界面中的 PictureBox 中显示该图片
            displayPictureBox.Image = (Bitmap)pictureBox.Image;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // 初始化摄像头
                cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (cameras.Count > 0)
                {
                    // 默认使用第一个摄像头
                    videoSource = new VideoCaptureDevice(cameras[currentCameraIndex].MonikerString);
                    videoSourcePlayer1.VideoSource = videoSource;
                    videoSourcePlayer1.Start();
                    label6.Text = cameras[currentCameraIndex].Name;
                }
                else
                {
                    MessageBox.Show("未找到摄像头！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("无法初始化摄像头：" + ex.Message);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 关闭摄像头
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSourcePlayer1.SignalToStop();
                videoSourcePlayer1.WaitForStop();
            }
        }

        private void SwitchButton_Click(object sender, EventArgs e)
        {
            try
            {
                // 切换到下一个摄像头
                currentCameraIndex = (currentCameraIndex + 1) % cameras.Count;

                // 关闭当前摄像头
                if (videoSource != null && videoSource.IsRunning)
                {
                    videoSourcePlayer1.SignalToStop();
                    videoSourcePlayer1.WaitForStop();
                }

                // 启动下一个摄像头
                videoSource = new VideoCaptureDevice(cameras[currentCameraIndex].MonikerString);
                videoSourcePlayer1.VideoSource = videoSource;
                videoSourcePlayer1.Start();
                label6.Text = cameras[currentCameraIndex].Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show("无法切换摄像头：" + ex.Message);
            }
        }
        
        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSourcePlayer1.SignalToStop();
                videoSourcePlayer1.WaitForStop();
            }
            label6.Text = "_____________________";
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            try
            {
                // 创建一个文件夹用于保存导出的图片
                string exportFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "导出的图片");
                if (!Directory.Exists(exportFolderPath))
                {
                    Directory.CreateDirectory(exportFolderPath);
                }

                // 遍历照片集合，导出每张照片
                foreach (var photo in photoCollection)
                {
                    string exportFilePath = Path.Combine(exportFolderPath, $"{photo.Name}.jpg");

                    if (compressCheck.Checked)
                    {
                        // 压缩并保存图片
                        CompressAndSaveImage(photo.Image, exportFilePath, 50);
                    }
                    else
                    {
                        // 直接保存原始图片
                        photo.Image.Save(exportFilePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                }

                MessageBox.Show("导出成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("导出失败：" + ex.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            // 获取 displayPictureBox 中显示的图片
            Bitmap displayedImage = (Bitmap)displayPictureBox.Image;

            // 在 photoCollection 中查找并移除对应的照片对象
            Photo photoToRemove = null;
            foreach (var photo in photoCollection)
            {
                if (photo.Image == displayedImage)
                {
                    photoToRemove = photo;
                    break;
                }
            }
            if (photoToRemove != null)
            {
                photoCollection.Remove(photoToRemove);
            }

            // 查找并移除对应的 splitContainer
            foreach (Control control in PhotoPanel.Controls)
            {
                if (control is SplitContainer splitContainer)
                {
                    if (splitContainer.Panel1.Controls.Count > 0 && splitContainer.Panel1.Controls[0] is System.Windows.Forms.PictureBox pictureBox &&
                        pictureBox.Image == displayedImage)
                    {
                        PhotoPanel.Controls.Remove(splitContainer);
                        break;
                    }
                }
            }

            // 清空 displayPictureBox 中的图片
            displayPictureBox.Image = null;
        }

        private void CompressAndSaveImage(Bitmap image, string filePath, long quality)
        {
            // 创建 JPEG 压缩参数
            EncoderParameters encoderParameters = new EncoderParameters(1);
            encoderParameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);

            // 获取 JPEG 编码器
            ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

            // 保存图片
            image.Save(filePath, jpgEncoder, encoderParameters);
        }

        // 获取指定图像格式的编码器信息
        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }

            return null;
        }

        
    }
}
