using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Undefine.Domain.Model;

namespace Undefine.Repository.Models.Mapping
{
    public partial class Sys_RoleMap : IEntityTypeConfiguration<Sys_Role>
    {
        public void Configure(EntityTypeBuilder<Sys_Role> builder)
        {
            builder.ToTable("Sys_Role");

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
        }
    }
}
