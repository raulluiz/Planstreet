using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Planstreet.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Planstreet.Infrastructure.EntityConfig
{
    public class DocumentFilesConfig : IEntityTypeConfiguration<DocumentFiles>
    {
        public void Configure(EntityTypeBuilder<DocumentFiles> builder)
        {
            builder.ToTable("DocumentFiles");
            builder.HasKey(c => c.FileId);
            builder.Property(c => c.FileId).ValueGeneratedOnAdd();
            builder.Property(c => c.FileName);
            builder.Property(c => c.FileNameOnDisk);
            builder.Property(c => c.FolderId);
            builder.Property(c => c.DefaultFolderId);
            builder.Property(c => c.ResourceId);
            builder.Property(c => c.ContentType);
            builder.Property(c => c.FilePath);
            builder.Property(c => c.CreationTime);
            builder.Property(c => c.UpdationTime);
            builder.Property(c => c.Creator);
            builder.Property(c => c.Updater);
            builder.Property(c => c.RemoteHost);
            builder.Property(c => c.Status);
        }
    }
}
