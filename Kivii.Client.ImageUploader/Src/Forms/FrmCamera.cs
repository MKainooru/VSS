using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kivii.Imaging.Uploader.Transforms;
using Kivii.Video.DirectShow;
using Kivii.Video;
using Kivii.Imaging.Uploader.Features;
using Kivii.Imaging.Uploader.Controls;
using System.IO;
using Kivii.Imaging.Filters;
using Kivii.Math.Geometry;

namespace Kivii.Imaging.Uploader.Forms
{
    public partial class FrmCamera : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoDevice;
        private VideoCapabilities[] videoCapabilities;
        private VideoCapabilities[] snapshotCapabilities;

        private CameraUploaderRequest _uploaderRequest = null;
        public FrmCamera()
        {
            InitializeComponent();
        }

        internal void Request(CameraUploaderRequest request)
        {
            _uploaderRequest = request;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count != 0)
            {
                // add all devices to combo
                foreach (FilterInfo device in videoDevices)
                {
                    cbxCameras.Items.Add(device.Name);
                }
            }
            else
            {
                cbxCameras.Items.Add("没有找到视频采集设备");
            }
            cbxCameras.SelectedIndex = 0;

            enableConnectionControls(videoDevices.Count != 0);

        }
        private void enableConnectionControls(bool enable)
        {
            cbxCameras.Enabled = enable;
            cbxCameraResolutions.Enabled = enable;
            cbxSnapResolutions.Enabled = enable;
            btnOpenCamera.Enabled = enable;
            btnCloseCamera.Enabled = !enable;
            btnSnap.Enabled = !enable;//(!enable) && (snapshotCapabilities?.Length != 0);
        }

        private void cbxCameras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (videoDevices.Count != 0)
            {
                videoDevice = new VideoCaptureDevice(videoDevices[cbxCameras.SelectedIndex].MonikerString);
                //enumeratedSupportedFrameSizes(videoDevice);
            }
        }

        private void enumeratedSupportedFrameSizes(VideoCaptureDevice videoDevice)
        {
            this.Cursor = Cursors.WaitCursor;

            cbxCameraResolutions.Items.Clear();
            cbxSnapResolutions.Items.Clear();

            try
            {
                //videoCapabilities = videoDevice.VideoCapabilities;
                snapshotCapabilities = videoDevice.SnapshotCapabilities;
                List<VideoCapabilities> tmpVideoCapalilities = new List<VideoCapabilities>();
                foreach (VideoCapabilities capabilty in videoDevice.VideoCapabilities)
                {
                    if (capabilty.FrameSize.Width > 1024) continue;
                    tmpVideoCapalilities.Add(capabilty);
                    cbxCameraResolutions.Items.Add(string.Format("{0} x {1}",
                        capabilty.FrameSize.Width, capabilty.FrameSize.Height));
                }
                videoCapabilities = tmpVideoCapalilities.ToArray();
                foreach (VideoCapabilities capabilty in snapshotCapabilities)
                {
                    cbxSnapResolutions.Items.Add(string.Format("{0} x {1}",
                        capabilty.FrameSize.Width, capabilty.FrameSize.Height));
                }

                if (videoCapabilities.Length == 0)
                {
                    cbxCameraResolutions.Items.Add("Not supported");
                }
                if (snapshotCapabilities.Length == 0)
                {
                    cbxSnapResolutions.Items.Add("Not supported");
                }

                cbxCameraResolutions.SelectedIndex = 0;
                cbxSnapResolutions.SelectedIndex = 0;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        #region 高拍仪操作

        private void Disconnect()
        {
            if (videoSourcePlayer.VideoSource != null)
            {
                // stop video device
                videoSourcePlayer.SignalToStop();
                videoSourcePlayer.WaitForStop();
                videoSourcePlayer.VideoSource = null;

                if (videoDevice.ProvideSnapshots)
                {
                    videoDevice.SnapshotFrame -= new NewFrameEventHandler(videoDevice_SnapshotFrame);
                }

                enableConnectionControls(true);
            }
        }

        private void btnOpenCamera_Click(object sender, EventArgs e)
        {
            if (videoDevice == null) return;
            //if ((videoCapabilities != null) && (videoCapabilities.Length != 0))
            //{
            //    videoDevice.VideoResolution = videoCapabilities[cbxCameraResolutions.SelectedIndex];
            //}

            //if ((snapshotCapabilities != null) && (snapshotCapabilities.Length != 0))
            //{
            //    videoDevice.ProvideSnapshots = true;
            //    videoDevice.SnapshotResolution = snapshotCapabilities[cbxSnapResolutions.SelectedIndex];
            //    videoDevice.SnapshotFrame += new NewFrameEventHandler(videoDevice_SnapshotFrame);
            //}

            //enableConnectionControls(false);

            videoSourcePlayer.VideoSource = videoDevice;
            videoSourcePlayer.Start();

        }

        private void btnCloseCamera_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void btnCameraProperty_Click(object sender, EventArgs e)
        {
            if (videoDevice== null) return;
            try
            {
                videoDevice.DisplayPropertyPage(this.Handle);
            }
            catch (NotSupportedException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion



        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
            UploaderFeature.SingletonFormCamera = null;

        }

        #region Snap
        private void btnSnap_Click(object sender, EventArgs e)
        {
            ShowSnapshot((Bitmap)videoSourcePlayer.GetCurrentVideoFrame().Clone());
            return;
            //if (snapshotCapabilities?.Length == 0)
            //{
            //}
            //if ((videoDevice != null) && (videoDevice.ProvideSnapshots))
            //{
            //    videoDevice.SimulateTrigger();
            //}
        }
        private void videoDevice_SnapshotFrame(object sender, NewFrameEventArgs eventArgs)
        {
            ShowSnapshot((Bitmap)eventArgs.Frame.Clone());
        }
        private int _tabIndex = 1;
        private void ShowSnapshot(Bitmap snapshot)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<Bitmap>(ShowSnapshot), snapshot);
            }
            else
            {
                if (ChbRectify.Checked)
                {
                    Bitmap temp = snapshot.Clone() as Bitmap;
                    var _counter = new BlobCounter();
                    _counter.FilterBlobs = true;
                    _counter.MinWidth = snapshot.Width / 4;
                    _counter.MinHeight = snapshot.Height / 4;

                    FiltersSequence seq = new FiltersSequence();
                    seq.Add(Grayscale.CommonAlgorithms.BT709);  //First add  grayScaling filter
                    seq.Add(new OtsuThreshold()); //Then add binarization(thresholding) filter
                    temp = seq.Apply(temp);
                    _counter.ProcessImage(temp);
                    temp.Dispose();
                    var blobs = _counter.GetObjectsInformation();
                    if (blobs != null && blobs.Length > 0)
                    {
                        var corners = PointsCloud.FindQuadrilateralCorners(_counter.GetBlobsEdgePoints(blobs[0]));
                        var rect = blobs[0].Rectangle;
                        QuadrilateralTransformation quadTransformer = new QuadrilateralTransformation();
                        quadTransformer.SourceQuadrilateral = corners; //Set corners for transforming card 
                        quadTransformer.AutomaticSizeCalculaton = true;
                        snapshot=quadTransformer.Apply(snapshot);
                        //ResizeBilinear resizer = new ResizeBilinear(rect.Width, rect.Height);
                    }
                }
                PictureBoxEx pic = new Uploader.Controls.PictureBoxEx();
                pic.Dock = DockStyle.Left;
                pic.Margin = new Padding(5);
                pic.Image = snapshot;
                pic.TabIndex = _tabIndex++;
                pnlImages.Controls.Add(pic);
            }
        }
        #endregion

        private void btnUpload_Click(object sender, EventArgs e)
        {
            btnUpload.Enabled = false;
            var count = pnlImages.Controls.Count;
            if (count == 0) return;
            var request = new FileRequest();
            request.PopulateWith(_uploaderRequest);
            if (count > 1) request.Name = string.Empty;
            JsonHttpClient client = new JsonHttpClient(_uploaderRequest.UploadUrl);
            var path = Path.Combine(Path.GetTempPath(), "Kivii", "Client", "Caches", "Uploader", "Images");
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);


            for (var i = count - 1; i >= 0; i--)
            {
                var pic = pnlImages.Controls[i] as PictureBoxEx;
                string filename = Path.Combine(path, DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".jpg");
                try
                {
                    if (pic.Image == null)
                    {
                        pnlImages.Controls.Remove(pic);
                        continue;
                    }

                    pic.Image.Save(filename);
                    if (!File.Exists(filename)) continue;
                    var response = client.PostFileWithRequest<FileResponse>(new FileInfo(filename), request);
                    if (response.Results != null && response.Results.Count >= 1)
                    {
                        pnlImages.Controls.Remove(pic);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    File.Delete(filename);
                }
            }
            btnUpload.Enabled = true;

        }

        private void ChbRectify_CheckedChanged(object sender, EventArgs e)
        {
            videoSourcePlayer.EnableRectify = ChbRectify.Checked;
        }

    }
}
