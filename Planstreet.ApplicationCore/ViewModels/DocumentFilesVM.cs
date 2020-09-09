using Planstreet.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Planstreet.ApplicationCore.ViewModels
{
    public class DocumentFilesVM
    {
        public int FileId { get; set; }

        public string FileName { get; set; }

        public string FileNameOnDisk { get; set; }

        public int? FolderId { get; set; }
        public DocumentFolder DocumentFolder { get; set; }

        public int? DefaultFolderId { get; set; }
        public DefaultFolder DefaultFolder { get; set; }

        public int? ResourceId { get; set; }

        public string ContentType { get; set; }

        public string FilePath { get; set; }

        public DateTime? CreationTime { get; set; }

        public DateTime? UpdationTime { get; set; }

        public int? Creator { get; set; }

        public int? Updater { get; set; }

        public string RemoteHost { get; set; }

        public byte Status { get; set; }
    }
}
