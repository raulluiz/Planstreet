using Planstreet.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Planstreet.ApplicationCore.ViewModels
{
    public class DocumentFolderVM
    {
        public int FolderId { get; set; }

        public string Caption { get; set; }

        public int? ParentFolderId { get; set; }

        public int? ResourceId { get; set; }

        public string Path { get; set; }

        public DateTime? CreationTime { get; set; }

        public DateTime? UpdationTime { get; set; }

        public int? Creator { get; set; }

        public int? Updater { get; set; }

        public string RemoteHost { get; set; }

        public byte? Status { get; set; }

        public string FolderSize { get; set; }

        public int? DefaultFolderId { get; set; }
        public DefaultFolder DefaultFolder { get; set; }
    }
}
