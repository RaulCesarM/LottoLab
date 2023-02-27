

using LotoCharts.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LotoCharts.Infra.Data.Mapping
{
    public class LotoFacilMapping: IEntityTypeConfiguration<LotoFacil>
    {
        public void Configure(EntityTypeBuilder<LotoFacil> builder)
        {
            builder.ToTable("LotoFacil");
            builder.HasKey(L => L.Id);
            builder.Property(L => L.Concurso)
                   .HasColumnType("int");
            builder.Property(L => L.Data)
                   .HasMaxLength(20);
            builder.Property(L => L.Casa_1)
                   .HasMaxLength(2)
                   .HasColumnType("int");
            builder.Property(L => L.Casa_2)
                   .HasMaxLength(2)
                   .HasColumnType("int");
            builder.Property(L => L.Casa_3)
                   .HasMaxLength(2)
                   .HasColumnType("int");
            builder.Property(L => L.Casa_4)
                   .HasMaxLength(2)
                   .HasColumnType("int");
            builder.Property(L => L.Casa_5)
                   .HasMaxLength(2)
                   .HasColumnType("int");
            builder.Property(L => L.Casa_6)
                   .HasMaxLength(2)
                   .HasColumnType("int");
            builder.Property(L => L.Casa_7)
                   .HasMaxLength(2)
                   .HasColumnType("int");
            builder.Property(L => L.Casa_8)
                   .HasMaxLength(2)
                   .HasColumnType("int");
            builder.Property(L => L.Casa_9)
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