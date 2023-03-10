
using LottoLab.Domain.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LottoLab.Infra.DataBase.Mappings
{
    public class LotoFacilDelayMapping : IEntityTypeConfiguration<LotoFacilDelay>
    {

        public void Configure(EntityTypeBuilder<LotoFacilDelay> builder)
        {
            builder.ToTable("Delay");
            builder.HasKey(L => L.Id);
            builder.Property(L => L.Concurso).HasColumnType("int");
            builder.Property(L => L.Data).HasMaxLength(20);
            builder.Property(L => L.N1).HasMaxLength(2).HasColumnType("int");
            builder.Property(L => L.N2).HasMaxLength(2).HasColumnType("int");
            builder.Property(L => L.N3).HasMaxLength(2).HasColumnType("int");
            builder.Property(L => L.N4).HasMaxLength(2).HasColumnType("int");
            builder.Property(L => L.N5).HasMaxLength(2).HasColumnType("int");
            builder.Property(L => L.N6).HasMaxLength(2).HasColumnType("int");
            builder.Property(L => L.N7).HasMaxLength(2).HasColumnType("int");
            builder.Property(L => L.N8).HasMaxLength(2).HasColumnType("int");
            builder.Property(L => L.N9).HasMaxLength(2).HasColumnType("int");
            builder.Property(L => L.N10).HasMaxLength(2).HasColumnType("int");
            builder.Property(L => L.N11).HasMaxLength(2).HasColumnType("int");
            builder.Property(L => L.N12).HasMaxLength(2).HasColumnType("int");
            builder.Property(L => L.N13).HasMaxLength(2).HasColumnType("int");
            builder.Property(L => L.N14).HasMaxLength(2).HasColumnType("int");
            builder.Property(L => L.N15).HasMaxLength(2).HasColumnType("int");
            builder.Property(L => L.N16).HasMaxLength(2).HasColumnType("int");
            builder.Property(L => L.N17).HasMaxLength(2).HasColumnType("int");
            builder.Property(L => L.N18).HasMaxLength(2).HasColumnType("int");
            builder.Property(L => L.N19).HasMaxLength(2).HasColumnType("int");
            builder.Property(L => L.N20).HasMaxLength(2).HasColumnType("int");
            builder.Property(L => L.N21).HasMaxLength(2).HasColumnType("int");
            builder.Property(L => L.N22).HasMaxLength(2).HasColumnType("int");
            builder.Property(L => L.N23).HasMaxLength(2).HasColumnType("int");
            builder.Property(L => L.N24).HasMaxLength(2).HasColumnType("int");
            builder.Property(L => L.N25).HasMaxLength(2).HasColumnType("int");


        }

    }
}

/*

 public class LotoFacilMapping : IEntityTypeConfiguration<LotoFacilDelay>
    {
        public void Configure(EntityTypeBuilder<LotoFacilDelay> builder)
        {
           
            builder.ToTable("Delay");

           
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Concurso).IsRequired();
            builder.Property(e => e.Data).IsRequired();
            builder.Property(e => e.Numeros).IsRequired().HasMaxLength(25);

           

        }
    }





*/