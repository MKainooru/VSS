using Kivii.Imaging.Uploader.Forms;
using Kivii.Imaging.Uploader.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivii.Imaging.Uploader.Features
{
    public class UploaderFeature : IPlugin
    {
        internal static FrmCamera SingletonFormCamera = null;
        internal static FrmLocal SingletonFormLocal = null;
        internal static FrmScanner SingletonFormScanner = null;

        public void Register(IAppHost appHost)
        {
            appHost.RegisterService<UploaderService>();
        }
    }
}
