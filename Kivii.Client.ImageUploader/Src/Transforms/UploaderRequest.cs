using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivii.Imaging.Uploader.Transforms
{
    [Api(Description ="客户端高拍仪上传图片信息")]
    [Route(Configs.RouteUploadCamera, "Post,Get")]
    [Route(Configs.RouteUploadCamera2, "Post,Get")]
    public class CameraUploaderRequest: FileRequestBase,IReturn<UploadResponse>
    {
        [ApiMember(Description = "自动打开采集摄像头")]
        public bool AutoOpen { get; set; }

        [ApiMember(Description = "上传图片路径，绝对路径信息")]
        public string UploadUrl { get; set; }

        public string BearerToken { get; set; }


    }

    [Api(Description = "客户端本地文件上传图片信息")]
    [Route(Configs.RouteUploadLocal, "Post,Get")]
    public class LocalUploaderRequest : FileRequestBase, IReturn<UploadResponse>
    {
        [ApiMember(Description = "上传图片路径，绝对路径信息")]
        public string ServerUrl { get; set; }

    }

    [Api(Description = "客户端扫描仪上传图片信息")]
    [Route(Configs.RouteUploadScanner, "Post,Get")]
    public class ScannerUploaderRequest : FileRequestBase, IReturn<UploadResponse>
    {
        [ApiMember(Description = "上传图片路径，绝对路径信息")]
        public string ServerUrl { get; set; }

    }

    public class UploadResponse
    {
        public bool IsSucceed { get; set; }
    }
}
