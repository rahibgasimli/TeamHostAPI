﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeamHost.DAL.Data;

#nullable disable

namespace TeamHost.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240502212017_mig01")]
    partial class mig01
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GameGameTag", b =>
                {
                    b.Property<Guid>("GameTagsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GamesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("GameTagsId", "GamesId");

                    b.HasIndex("GamesId");

                    b.ToTable("GameGameTag");
                });

            modelBuilder.Entity("TeamHost.DAL.Entities.Game", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Reviews")
                        .HasColumnType("float");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Games");
                });

            modelBuilder.Entity("TeamHost.DAL.Entities.GameTag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("GameTags");
                });

            modelBuilder.Entity("GameGameTag", b =>
                {
                    b.HasOne("TeamHost.DAL.Entities.GameTag", null)
                        .WithMany()
                        .HasForeignKey("GameTagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamHost.DAL.Entities.Game", null)
                        .WithMany()
                        .HasForeignKey("GamesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}