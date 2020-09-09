using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Planstreet.ApplicationCore.Entities
{
    public class DocumentFiles
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FileId { get; set; }

        [StringLength(100)]
        public string FileName { get; set; }

        [StringLength(100)]
        public string FileNameOnDisk { get; set; }

        [ForeignKey("DocumentFolder")]
        public int? FolderId { get; set; }
        public DocumentFolder DocumentFolder { get; set; }

        [ForeignKey("DefaultFolder")]
        public int? DefaultFolderId { get; set; }
        public DefaultFolder DefaultFolder { get; set; }

        public int? ResourceId { get; set; }

        [StringLength(500)]
        public string ContentType { get; set; }

        [StringLength(500)]
        public string FilePath { get; set; }

        public DateTime? CreationTime { get; set; }

        public DateTime? UpdationTime { get; set; }

        public int? Creator { get; set; }

        public int? Updater { get; set; }

        [StringLength(50)]
        public string RemoteHost { get; set; }

        public byte Status { get; set; }
    }
}
