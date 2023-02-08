using External.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace External.Infra.Mapping
{
    public class LotoFacilMapping : IEntityTypeConfiguration<LotoFacil>
    {
        public void Configure(EntityTypeBuilder<LotoFacil> builder)
        {
            builder.ToTable("LotoFacil");
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
            builder.Property(L => L.Casa_06)
                   .HasMaxLength(2)
                   .HasColumnType("int");
            builder.Property(L => L.Casa_07)
                   .HasMaxLength(2)
                   .HasColumnType("int");
            builder.Property(L => L.Casa_08)
                   .HasMaxLength(2)
                   .HasColumnType("int");
            builder.Property(L => L.Casa_09)
                   .HasMaxLength(2)
                   .HasColumnType("int");
            builder.Property(L => L.Casa_10)
                   .HasMaxLength(2)
                   .HasColumnType("int");
            builder.Property(L => L.Casa_11)
                   .HasMaxLength(2)
                   .HasColumnType("int");
            builder.Property(L => L.Casa_12)
                   .HasMaxLength(2)
                   .HasColumnType("int");
            builder.Property(L => L.Casa_13)
                   .HasMaxLength(2)
                   .HasColumnType("int");
            builder.Property(L => L.Casa_14)
                   .HasMaxLength(2)
                   .HasColumnType("int");
            builder.Property(L => L.Casa_15)
                    .HasMaxLength(2)
                   .HasColumnType("int");
        }
    }
}