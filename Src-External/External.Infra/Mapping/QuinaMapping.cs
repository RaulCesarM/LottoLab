
using External.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace External.Infra.Mapping
{
    public class QuinaMapping : IEntityTypeConfiguration<Quina>
    {
        public void Configure(EntityTypeBuilder<Quina> builder)
        {
            builder.ToTable("Quina");
            builder.HasKey(L => L.Id);
            builder.Property(L => L.Concurso)
                   .HasColumnType("int");
            builder.Property(L => L.Data)
                   .HasMaxLength(20);
            builder.Property(L => L.Casa_01)
                   .HasMaxLength(2)
                   .HasColumnType("int");
            builder.Property(L => L.Casa_02)
                   .HasMaxLength(2)
                   .HasColumnType("int");
            builder.Property(L => L.Casa_03)
                   .HasMaxLength(2)
                   .HasColumnType("int");
            builder.Property(L => L.Casa_04)
                   .HasMaxLength(2)
                   .HasColumnType("int");
            builder.Property(L => L.Casa_05)
                   .HasMaxLength(2)
                   .HasColumnType("int");
        }
    }
}