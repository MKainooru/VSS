using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivii.Imaging.Uploader
{
    internal class Configs
    {
        public const string RouteFilesUploadAndDownload = "/"; //+ KiviiContext.StoragesPrefix;

        public const string RouteDeviceCameraSupport = "/Client/Device/Support/Camera";
        public const string RouteDeviceScannerSupport = "/Client/Device/Support/Scanner";
        public const string RouteDeviceLocalSupport = "/Client/Device/Support/Scanner";
        public const string RouteDeviceSnapshootSupport = "/Client/Device/Support/Scanner";

        public const string RouteUploadCamera = "/Client/Uploader/Camera";
        public const string RouteUploadCamera2 = "/Client/Imaging/Uploader/Camera";
        public const string RouteUploadLocal = "/Client/Imaging/Uploader/Local";
        public const string RouteUploadScanner = "/Client/Imaging/Uploader/Scanner";
        public const string RouteUploadSnapshoot = "/Client/Imaging/Uploader/Snapshoot";
    }
}
