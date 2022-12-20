﻿// <auto-generated />
using LotoCharts.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LotoCharts.Infra.Migrations
{
    [DbContext(typeof(LotoChartsContext))]
    partial class LotoChartsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LotoCharts.Domain.Entities.Models.Sorteio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Casa_01")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<int>("Casa_02")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<int>("Casa_03")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<int>("Casa_04")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<int>("Casa_05")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<int>("Casa_06")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<int>("Casa_07")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<int>("Casa_08")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<int>("Casa_09")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<int>("Casa_10")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<int>("Casa_11")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<int>("Casa_12")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<int>("Casa_13")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<int>("Casa_14")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<int>("Casa_15")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<int>("Concurso")
                        .HasColumnType("int");

                    b.Property<string>("Data")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("LotoFacil", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
