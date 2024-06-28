using Kivii.Client.Finances.Icbc;
using Kivii.Linq;
using Kivii.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace Kivii.Client.CameraApp
{
    public partial class MainForm : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoDevice;
        private int currentCameraIndex = 0;
        private List<Photo> photoCollection = new List<Photo>();
        private JsonServiceClient _client = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void initK5FormCtl(bool notLogin)
        {
            btnSwitch.Enabled = notLogin;
            btnClose.Enabled = notLogin;
            cmbResolution.Enabled = notLogin;
            btnConfirm.Enabled = notLogin;
            btnTake.Enabled = notLogin;
            btnDelete.Enabled = notLogin;
            btnUpload.Enabled = notLogin;
            chkCompress.Enabled = notLogin;
            tbxSampleCode.Enabled = notLogin;
            vspPreview.Enabled = notLogin;
        }

        private void setDefault(params Control[] ctls)
        {
            using (var conn = KiviiContext.GetOpenedDbConnection<UiSetting>())
            {
                foreach (var ctl in ctls)
                {
                    var setting = conn.Select<UiSetting>(o => o.FormName == this.Name && o.ControlName == ctl.Name).FirstOrDefault();
                    if (setting == null)
                    {
                        setting = new UiSetting();
                        setting.FormName = this.Name;
                        setting.ControlName = ctl.Name;
                        setting.ControlValue = ctl.Text;
                        conn.Insert(setting);
                    }
                    else
                    {
                        setting.ControlValue = ctl.Text;
                        conn.Update(setting);
                    }
                }
            }
        }

        private void loadDefault(params Control[] ctls)
        {
            using (var conn = KiviiContext.GetOpenedDbConnection<UiSetting>())
            {
                foreach (var ctl in ctls)
                {
                    var setting = conn.Select<UiSetting>(o => o.FormName == this.Name && o.ControlName == ctl.Name).FirstOrDefault();
                    if (setting == null) continue;
                    ctl.Text = setting.ControlValue;
                }
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            initK5FormCtl(false);
            loadDefault(tbxServiceUrl, tbxUserName, tbxPassword);
        }

        private void ShowPreviewWindow()
        {
            try
            {
                // 初始化摄像头
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (videoDevices.Count > 0)
                {
                    // 默认使用第一个摄像头
                    videoDevice = new VideoCaptureDevice(videoDevices[currentCameraIndex].MonikerString);
                    vspPreview.VideoSource = videoDevice;
                    vspPreview.Start();
                    lblCameraNameShow.Text = videoDevices[currentCameraIndex].Name;

                    // 调用方法来枚举支持的分辨率并设置默认值
                    enumerateSupportedResolutions(videoDevice);

                    // 添加 SelectedIndexChanged 事件处理程序
                    cmbResolution.SelectedIndexChanged += cmbResolution_SelectedIndexChanged;
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 关闭摄像头
            if (videoDevice != null && videoDevice.IsRunning)
            {
                vspPreview.Stop();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_client != null)
            {
                MessageBox.Show("登陆前先退出原连接");
                return;
            }

            _client = new JsonServiceClient(tbxServiceUrl.Text);
            var auth = new Authenticate { UserName = tbxUserName.Text, Password = tbxPassword.Text, provider = "Kivii" };
            var task = _client.PostAsync(auth);
            task.Success(resp =>
            {
                ShowPreviewWindow();
                initK5FormCtl(true);
                setDefault(tbxServiceUrl, tbxUserName, tbxPassword);
                Thread.Sleep(100);
            }, true);
            task.Error(err =>
            {
                initK5FormCtl(false);
                _client.Dispose();
                _client = null;
                MessageBox.Show(err.Message, "登陆失败");
            }, true);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (_client == null)
            {
                MessageBox.Show("未连接");
                return;
            }

            var auth = new Authenticate { provider = "Logout" };
            var task = _client.PostAsync(auth);
            task.Success(resp =>
            {
                _client.Dispose();
                _client = null;
                Thread.Sleep(100);
                initK5FormCtl(false);
                vspPreview.Stop();
            });
            task.Error(err =>
            {
                btnLogout.Enabled = true;
                MessageBox.Show(err.Message, "退出错误");
            });
        }

        private void butSwitch_Click(object sender, EventArgs e)
        {
            try
            {
                // 切换到下一个摄像头
                currentCameraIndex = (currentCameraIndex + 1) % videoDevices.Count;
                // 关闭当前摄像头
                if (videoDevice != null && videoDevice.IsRunning)
                {
                    vspPreview.Stop();
                }

                // 启动下一个摄像头
                videoDevice = new VideoCaptureDevice(videoDevices[currentCameraIndex].MonikerString);
                vspPreview.VideoSource = videoDevice;
                vspPreview.Start();
                lblCameraNameShow.Text = videoDevices[currentCameraIndex].Name;
                // 调用方法来枚举支持的分辨率并设置默认值
                enumerateSupportedResolutions(videoDevice);

                // 添加 SelectedIndexChanged 事件处理程序
                cmbResolution.SelectedIndexChanged += cmbResolution_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("无法切换摄像头：" + ex.Message);
            }
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            // 关闭摄像头
            if (videoDevice != null && videoDevice.IsRunning)
            {
                vspPreview.Stop();
            }
            lblCameraNameShow.Text = "_____________________";
        }

        private void butTake_Click(object sender, EventArgs e)
        {
            try
            {
                if (videoDevice != null && vspPreview.IsRunning)
                {
                    // 捕获当前帧
                    Bitmap bitmap = vspPreview.GetCurrentVideoFrame();
                    ptbPhotoDisplay.Image = bitmap;

                    // 创建图片 PictureBox 控件
                    PictureBox pictureBox = new PictureBox();
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
                    splitContainer.Size = new Size(210, 140);
                    splitContainer.Orientation = Orientation.Horizontal;
                    splitContainer.SplitterWidth = 1;
                    splitContainer.SplitterDistance = 100;
                    splitContainer.Panel1.Padding = new Padding(0, 10, 0, 0);
                    splitContainer.Panel1.Controls.Add(pictureBox);
                    splitContainer.Panel2.Controls.Add(nameLabel);

                    // 将 SplitContainer 添加到 flpPhotosTaken 中
                    flpPhotosTaken.Controls.Add(splitContainer);
                    // 改变排序，将新增的添加到顶部
                    flpPhotosTaken.Controls.SetChildIndex(splitContainer, 0);

                    // 将拍摄的照片对象添加到集合中
                    photoCollection.Add(new Photo(bitmap, name));

                    // 遍历 flpPhotosTaken 中的控件，将之前选中的 SplitContainer 边框改为默认
                    foreach (Control control in flpPhotosTaken.Controls)
                    {
                        if (control is SplitContainer controlContainer)
                        {
                            controlContainer.BorderStyle = BorderStyle.None;
                        }
                    }
                    // 为新添加的 SplitContainer 添加边框
                    splitContainer.BorderStyle = BorderStyle.FixedSingle;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("无法拍照" + ex.Message);
            }
        }

        public class Photo
        {
            public Bitmap Image { get; set; }
            public string Name { get; set; }

            public Photo(Bitmap image, string name)
            {
                Image = image;
                Name = name;
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            // 获取点击的 PictureBox 中的图片
            PictureBox pictureBox = (PictureBox)sender;

            // 遍历 flpPhotosTaken 中的控件，找到对应的 SplitContainer，并为其设置边框样式
            foreach (Control control in flpPhotosTaken.Controls)
            {
                if (control is SplitContainer splitContainer)
                {
                    // 如果 SplitContainer 包含点击的 PictureBox，则设置其边框,否则设置为默认
                    if (splitContainer.Panel1.Controls.Count > 0 && splitContainer.Panel1.Controls[0] == pictureBox)
                    {
                        splitContainer.BorderStyle = BorderStyle.FixedSingle;
                    }
                    else
                    {
                        splitContainer.BorderStyle = BorderStyle.None;
                    }
                }
            }
            // 在界面中的 PictureBox 中显示该图片
            ptbPhotoDisplay.Image = (Bitmap)pictureBox.Image;
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            // 获取 displayPictureBox 中显示的图片
            Bitmap displayedImage = (Bitmap)ptbPhotoDisplay.Image;

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
                // 获取要移除的图片在集合中的索引
                int removeIndex = photoCollection.IndexOf(photoToRemove);
                // 删除当前显示的图片
                photoCollection.Remove(photoToRemove);
                // 查找并移除对应的 splitContainer
                foreach (Control control in flpPhotosTaken.Controls)
                {
                    if (control is SplitContainer splitContainer)
                    {
                        if (splitContainer.Panel1.Controls.Count > 0 && splitContainer.Panel1.Controls[0] is PictureBox pictureBox &&
                            pictureBox.Image == displayedImage)
                        {
                            flpPhotosTaken.Controls.Remove(splitContainer);
                            break;
                        }
                    }
                }
                // 显示下一张图片
                if (photoCollection.Count > 0)
                {
                    // 计算下一张图片的索引（循环显示）
                    int nextIndex = photoCollection.Count - 1;
                    // 显示下一张图片
                    ptbPhotoDisplay.Image = photoCollection[nextIndex].Image;
                    // 更新边框以指示当前显示的图片
                    foreach (Control control in flpPhotosTaken.Controls)
                    {
                        if (control is SplitContainer splitContainer)
                        {
                            PictureBox pictureBox = (PictureBox)splitContainer.Panel1.Controls[0];
                            if (pictureBox.Image == ptbPhotoDisplay.Image)
                            {
                                // 将对应的 SplitContainer 加上边框
                                splitContainer.BorderStyle = BorderStyle.FixedSingle;
                            }
                            else
                            {
                                // 其他 SplitContainer 去除边框
                                splitContainer.BorderStyle = BorderStyle.None;
                            }
                        }
                    }
                }
                else
                {
                    // 清空 ptbPhotoDisplay 中的图片
                    ptbPhotoDisplay.Image = null;
                }
            }

        }

        private void butUpload_Click(object sender, EventArgs e)
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

                    if (chkCompress.Checked)
                    {
                        // 压缩并保存图片
                        CompressAndSaveImage(photo.Image, exportFilePath, 50);
                    }
                    else
                    {
                        // 直接保存原始图片
                        photo.Image.Save(exportFilePath, ImageFormat.Jpeg);
                    }
                }

                MessageBox.Show("导出成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("导出失败：" + ex.Message);
            }
        }
        /// <summary>
        /// 压缩并保存图片
        /// </summary>
        /// <param name="image">要保存的图片</param>
        /// <param name="filePath">保存地址</param>
        /// <param name="quality">压缩比例</param>
        private void CompressAndSaveImage(Bitmap image, string filePath, long quality)
        {
            // 创建 JPEG 压缩参数
            EncoderParameters encoderParameters = new EncoderParameters(1);
            encoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, quality);

            // 获取 JPEG 编码器
            ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

            // 保存图片
            image.Save(filePath, jpgEncoder, encoderParameters);
        }

        /// <summary>
        /// 获取指定图像格式的编码器信息
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 列出摄像头支持的分辨率
        /// </summary>
        /// <param name="videoDevice"></param>
        private void enumerateSupportedResolutions(VideoCaptureDevice videoDevice)
        {
            this.Cursor = Cursors.WaitCursor;
            cmbResolution.Items.Clear();

            try
            {
                // 获取摄像头支持的分辨率列表
                VideoCapabilities[] capabilities = videoDevice.VideoCapabilities;

                // 遍历分辨率列表，并添加到下拉框中
                foreach (VideoCapabilities capability in capabilities)
                {
                    cmbResolution.Items.Add(string.Format("{0} x {1}",
                        capability.FrameSize.Width, capability.FrameSize.Height));
                }
                // 如果没有支持的分辨率，则添加 "Not supported"
                if (cmbResolution.Items.Count == 0)
                {
                    cmbResolution.Items.Add("Not supported");
                }
                // 默认选择第一个分辨率
                cmbResolution.SelectedIndex = 0;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        /// <summary>
        /// 分辨率调整
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // 获取用户选择的分辨率索引
                int selectedIndex = cmbResolution.SelectedIndex;
                // 设置摄像头分辨率为用户选择的分辨率
                if (selectedIndex != -1)
                {
                    VideoCapabilities[] capabilities = videoDevice.VideoCapabilities;
                    if (capabilities.Length > selectedIndex)
                    {
                        vspPreview.Stop();
                        videoDevice.VideoResolution = capabilities[selectedIndex];
                        vspPreview.Start();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("无法设置摄像头分辨率：" + ex.Message);
            }
        }

        
    }
}
