using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Planstreet.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Planstreet.Infrastructure.EntityConfig
{
    public class DefaultFolderConfig : IEntityTypeConfiguration<DefaultFolder>
    {
        public void Configure(EntityTypeBuilder<DefaultFolder> builder)
        {
            builder.ToTable("DefaultFolder");
            builder.HasKey(c => c.DefaultFolderId);
            builder.Property(c => c.DefaultFolderId).ValueGeneratedOnAdd();
            builder.Property(c => c.Caption);
            builder.Property(c => c.CreationTime);
            builder.Property(c => c.UpdationTime);
            builder.Property(c => c.Creator);
            builder.Property(c => c.Updater);
            builder.Property(c => c.RemoteHost);
            builder.Property(c => c.Status);
        }
    }
}
