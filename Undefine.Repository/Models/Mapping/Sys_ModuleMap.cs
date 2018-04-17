using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
//using System.Data.Entity.ModelConfiguration;
//using System.Data.Entity.ModelConfiguration.Configuration;
using System.Text;
using Undefine.Domain.Model;

namespace Undefine.Repository.Models.Mapping
{
   public partial class Sys_ModuleMap : IEntityTypeConfiguration<Sys_Module>
    { 
        public void Configure(EntityTypeBuilder<Sys_Module> builder)
        {
            builder.ToTable("Sys_Module");

            builder.HasKey(m => m.Id);

            builder.Property(t => t.Id)
             .HasColumnName("Id").HasMaxLength(100)
             .IsRequired();

            builder.Property(t => t.CreationUserId).HasColumnName("CreationUserId").HasMaxLength(100).IsRequired();

            builder.Property(t => t.CreationUserName).HasColumnName("CreationUserName").HasMaxLength(30).IsRequired();

            builder.Property(t => t.CreationTime).HasColumnName("CreationTime").IsRequired();

            builder.Property(t => t.ModifyUserId).HasColumnName("ModifyUserId").HasMaxLength(100).IsRequired();

            builder.Property(t => t.ModifyUserName).HasColumnName("ModifyUserName").HasMaxLength(30).IsRequired();

            builder.Property(t => t.ModifyTime).HasColumnName("ModifyTime");

            builder.Property(t => t.Name)
            .HasColumnName("Name").HasMaxLength(30).IsRequired();
            builder.Property(t => t.Url)
            .HasColumnName("Url").HasMaxLength(255).IsRequired();
            builder.Property(t => t.Icon)
            .HasColumnName("Icon").HasMaxLength(50).IsRequired();
            builder.Property(t => t.Sort)
            .HasColumnName("Sort")
            .IsRequired();
            builder.Property(t => t.IsAutoExpand)
            .HasColumnName("IsAutoExpand")
            .IsRequired();
            builder.Property(t => t.ParentId)
            .HasColumnName("ParentId").HasMaxLength(100)
            .IsRequired();
            builder.Property(t => t.ParentName)
            .HasColumnName("ParentName").HasMaxLength(30)
            .IsRequired();
            builder.Property(t => t.Enabled)
            .HasColumnName("Enabled")
            .IsRequired();
        } 
    }
}
