using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Undefine.Domain.Model;

namespace Undefine.Repository.Models.Mapping
{
    public partial class Sys_RelevanceMap : IEntityTypeConfiguration<Sys_Relevance>
    {
        public void Configure(EntityTypeBuilder<Sys_Relevance> builder)
        {
            builder.ToTable("Sys_Relevance");

            builder.HasKey(m => m.Id);

            builder.Property(t => t.Id)
             .HasColumnName("Id").HasMaxLength(100)
             .IsRequired();

            builder.Property(t => t.FirstId)
            .HasColumnName("FirstId").HasMaxLength(100).IsRequired();

            builder.Property(t => t.SecondId)
            .HasColumnName("SecondId").HasMaxLength(100).IsRequired();

            builder.Property(t => t.Key)
            .HasColumnName("Key").HasMaxLength(30).IsRequired();
        }
    }
}
