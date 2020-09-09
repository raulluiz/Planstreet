using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Planstreet.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Planstreet.Infrastructure.EntityConfig
{
    public class DocumentFolderConfig : IEntityTypeConfiguration<DocumentFolder>
    {
        public void Configure(EntityTypeBuilder<DocumentFolder> builder)
        {
            builder.ToTable("DocumentFolder");
            builder.HasKey(c => c.FolderId);
            builder.Property(c => c.FolderId).ValueGeneratedOnAdd();
            builder.Property(c => c.Caption);
            builder.Property(c => c.CreationTime);
            builder.Property(c => c.UpdationTime);
            builder.Property(c => c.Creator);
            builder.Property(c => c.Updater);
            builder.Property(c => c.RemoteHost);
            builder.Property(c => c.Status);
            builder.Property(c => c.ParentFolderId);
            builder.Property(c => c.ResourceId);
            builder.Property(c => c.Path);
            builder.Property(c => c.FolderSize);
            builder.Property(c => c.DefaultFolderId);
        }
    }
}
