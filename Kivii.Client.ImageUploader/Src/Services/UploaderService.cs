using Kivii.Imaging.Uploader.Features;
using Kivii.Imaging.Uploader.Forms;
using Kivii.Imaging.Uploader.Transforms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kivii.Imaging.Uploader.Services
{
    public class UploaderService:Service
    {
        public object Any(CameraUploaderRequest request)
        {
            UploadResponse rtns = new Transforms.UploadResponse();
            if (UploaderFeature.SingletonFormCamera != null)
            {
                MessageBox.Show("高拍仪采集应用只能单例运行！");
                return rtns;
            }

            var _mainForm = TryResolve<IWindowForm>();
            if (_mainForm == null)
            {
                throw new Exception("系统配置错误！");
            }
            _mainForm.Invoke(new Action(() =>
            {
                UploaderFeature.SingletonFormCamera = new FrmCamera();
                UploaderFeature.SingletonFormCamera.Request(request);
                UploaderFeature.SingletonFormCamera.Show();
                UploaderFeature.SingletonFormCamera.BringToFront();
            }));
            return rtns;
        }
    }
}
