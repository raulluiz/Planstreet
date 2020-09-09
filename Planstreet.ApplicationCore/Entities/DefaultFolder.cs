using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Planstreet.ApplicationCore.Entities
{
    public class DefaultFolder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DefaultFolderId { get; set; }

        [StringLength(100)]
        public string Caption { get; set; }

        public DateTime? CreationTime { get; set; }

        public DateTime? UpdationTime { get; set; }

        public int? Creator { get; set; }

        public int? Updater { get; set; }

        [StringLength(50)]
        public string RemoteHost { get; set; }

        public byte? Status { get; set; }

        public ICollection<DocumentFolder> DocumentFolders { get; set; }
        public ICollection<DocumentFiles> DocumentFileses { get; set; }
    }
}
