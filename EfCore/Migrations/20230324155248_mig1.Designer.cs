﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfCore.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230324155248_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Biografi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("HayatHikayesi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YazarId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("YazarId")
                        .IsUnique();

                    b.ToTable("Biografiler");
                });

            modelBuilder.Entity("Yazar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("YazarAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Yazarlar");
                });

            modelBuilder.Entity("Biografi", b =>
                {
                    b.HasOne("Yazar", "Yazar")
                        .WithOne("Biografi")
                        .HasForeignKey("Biografi", "YazarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Yazar");
                });

            modelBuilder.Entity("Yazar", b =>
                {
                    b.Navigation("Biografi")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}