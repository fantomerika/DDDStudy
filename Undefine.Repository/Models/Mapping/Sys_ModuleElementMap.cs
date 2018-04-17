using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Undefine.Domain.Model;

namespace Undefine.Repository.Models.Mapping
{
    public partial class Sys_ModuleElementMap : IEntityTypeConfiguration<Sys_ModuleElement>
    {
        public void Configure(EntityTypeBuilder<Sys_ModuleElement> builder)
        {
            builder.ToTable("Sys_ModuleElement");

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
            builder.Property(t => t.DomId)
            .HasColumnName("DomId").HasMaxLength(30).IsRequired();
            builder.Property(t => t.Icon)
            .HasColumnName("Icon").HasMaxLength(50).IsRequired();
            builder.Property(t => t.BgColor)
            .HasColumnName("BgColor").HasMaxLength(50)
            .IsRequired();
            builder.Property(t => t.Remark)
            .HasColumnName("Remark").HasMaxLength(255);
            builder.Property(t => t.Sort)
            .HasColumnName("Sort");
            builder.Property(t => t.ModuleId)
            .HasColumnName("ModuleId").HasMaxLength(100).IsRequired();
        }
    }
}
