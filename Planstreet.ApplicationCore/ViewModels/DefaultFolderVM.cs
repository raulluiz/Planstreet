using System;
using System.Collections.Generic;
using System.Text;

namespace Planstreet.ApplicationCore.ViewModels
{
    public class DefaultFolderVM
    {
        public int DefaultFolderId { get; set; }
        public string Caption { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? UpdationTime { get; set; }
        public int Creator { get; set; }
        public int Updater { get; set; }
        public string RemoteHost { get; set; }
        public byte Status { get; set; }
    }
}
