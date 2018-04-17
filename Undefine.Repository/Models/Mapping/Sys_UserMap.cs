using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; 
using Undefine.Domain.Model;

namespace Undefine.Repository.Models.Mapping
{
    public partial class Sys_UserMap : IEntityTypeConfiguration<Sys_User>
    { 
        public void Configure(EntityTypeBuilder<Sys_User> builder)
        {
            builder.ToTable("Sys_User");

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

            builder.Property(t => t.UserName)
            .HasColumnName("UserName").HasMaxLength(30).IsRequired();
            builder.Property(t => t.Account)
            .HasColumnName("Account").HasMaxLength(30).IsRequired();
            builder.Property(t => t.PassWord)
            .HasColumnName("PassWord").HasMaxLength(255).IsRequired();
            builder.Property(t => t.Sex)
            .HasColumnName("Sex")
            .IsRequired();
            builder.Property(t => t.Status)
            .HasColumnName("Status")
            .IsRequired();
            builder.Property(t => t.LastLoginIp)
            .HasColumnName("LastLoginIp").HasMaxLength(30)
            .IsRequired();
            builder.Property(t => t.LastLoginTime)
            .HasColumnName("LastLoginTime")
            .IsRequired();
        } 
    }
}
