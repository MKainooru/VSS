using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivii.Imaging.Uploader.Transforms
{
    public class FileRequestBase
    {
        public bool Override { get; set; }
        public string Description { get; set; }
        public Guid OwnerKvid { get; set; }
        public string OwnerName { get; set; }
        public string Name { get; set; }
        public string Folder { get; set; }
        public string Tags { get; set; }
    }

    [Route(Configs.RouteFilesUploadAndDownload, "Get,Post")]
    public class FileRequest : FileRequestBase, IReturn<FileResponse>
    {
    }


    public class FileResponse : RestfulCreateResponse<DbFile>
    {
        public bool success
        {
            get
            {
                return ResponseStatus == null;
            }
        }
    }
    public class DbFile : Entity
    {
        public string Name { get; set; }
        public string Extension { get; set; }
        public long Length { get; set; }
        public DateTime PublishTime { get; set; }
        public string RemoteUrl { get; set; }
        public decimal Version { get; set; }
        public string Folder { get; set; }
        public string VirtualPath { get; set; }
        public string OwnerName { get; set; }
        public Guid OwnerKvid { get; set; }
        public string Tags { get; set; }
        public Guid CreatorKvid { get; set; }
        public string CreatorName { get; set; }
    }
}
