using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Planstreet.ApplicationCore.Entities
{
    public class DocumentFolder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FolderId { get; set; }

        [StringLength(100)]
        public string Caption { get; set; }

        public int? ParentFolderId { get; set; }

        public int? ResourceId { get; set; }

        public string Path { get; set; }

        public DateTime? CreationTime { get; set; }

        public DateTime? UpdationTime { get; set; }

        public int? Creator { get; set; }

        public int? Updater { get; set; }

        [StringLength(50)]
        public string RemoteHost { get; set; }

        public byte? Status { get; set; }

        [StringLength(50)]
        public string FolderSize { get; set; }

        [ForeignKey("DefaultFolder")]
        public int? DefaultFolderId { get; set; }
        public DefaultFolder DefaultFolder { get; set; }

        public ICollection<DocumentFiles> DocumentFileses { get; set; }
    }
}
