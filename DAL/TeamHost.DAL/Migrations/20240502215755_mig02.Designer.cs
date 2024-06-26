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
    [Migration("20240502215755_mig02")]
    partial class mig02
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("c83714f5-09c1-4788-a0a3-52b7c3a6ce05"),
                            CreatedDate = new DateTime(2024, 5, 2, 21, 57, 54, 943, DateTimeKind.Utc).AddTicks(8246),
                            Description = "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.",
                            IsDeleted = false,
                            Name = "Hunt of Duplicity",
                            PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/game-2.jpg",
                            Price = 9.9900000000000002,
                            Reviews = 4.5999999999999996
                        },
                        new
                        {
                            Id = new Guid("848f4ea1-2dbe-41aa-a318-8b880e017df5"),
                            CreatedDate = new DateTime(2024, 5, 2, 21, 57, 54, 943, DateTimeKind.Utc).AddTicks(8376),
                            Description = "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.",
                            IsDeleted = false,
                            Name = "Struggle of Rivalry",
                            PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/game-1.jpg",
                            Price = 4.9900000000000002,
                            Reviews = 4.7999999999999998
                        },
                        new
                        {
                            Id = new Guid("49d19064-87d4-475c-8646-0ccba58a93f2"),
                            CreatedDate = new DateTime(2024, 5, 2, 21, 57, 54, 943, DateTimeKind.Utc).AddTicks(8397),
                            Description = "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.",
                            IsDeleted = false,
                            Name = "Journey and Dimension",
                            PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/game-3.jpg",
                            Price = 13.99,
                            Reviews = 4.7000000000000002
                        },
                        new
                        {
                            Id = new Guid("4781b2ce-885a-45cc-b9c9-6d3eabda79e7"),
                            CreatedDate = new DateTime(2024, 5, 2, 21, 57, 54, 943, DateTimeKind.Utc).AddTicks(8400),
                            Description = "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.",
                            IsDeleted = false,
                            Name = "Reckoning and Freedom",
                            PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/game-4.jpg",
                            Price = 49.990000000000002,
                            Reviews = 4.0999999999999996
                        },
                        new
                        {
                            Id = new Guid("d577b81f-ef99-4780-9696-bc5664270096"),
                            CreatedDate = new DateTime(2024, 5, 2, 21, 57, 54, 943, DateTimeKind.Utc).AddTicks(8403),
                            Description = "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.",
                            IsDeleted = false,
                            Name = "Pillage of Redemption",
                            PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/game-5.jpg",
                            Price = 13.99,
                            Reviews = 4.7000000000000002
                        });
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("fc235475-fb4a-4621-87dd-0d3a1a3c7d73"),
                            CreatedDate = new DateTime(2024, 5, 2, 21, 57, 54, 943, DateTimeKind.Utc).AddTicks(8493),
                            IsDeleted = false,
                            Name = "Action"
                        },
                        new
                        {
                            Id = new Guid("9975d7da-5b13-4b04-9e16-71786f1d853d"),
                            CreatedDate = new DateTime(2024, 5, 2, 21, 57, 54, 943, DateTimeKind.Utc).AddTicks(8498),
                            IsDeleted = false,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = new Guid("51b302cb-b2e1-42c7-87ea-3723291b88fa"),
                            CreatedDate = new DateTime(2024, 5, 2, 21, 57, 54, 943, DateTimeKind.Utc).AddTicks(8501),
                            IsDeleted = false,
                            Name = "Survival"
                        },
                        new
                        {
                            Id = new Guid("6c9c5007-e3df-4db2-8b6d-d04f9861d979"),
                            CreatedDate = new DateTime(2024, 5, 2, 21, 57, 54, 943, DateTimeKind.Utc).AddTicks(8504),
                            IsDeleted = false,
                            Name = "Strategy"
                        },
                        new
                        {
                            Id = new Guid("536fcf2e-f2c1-4edd-9764-624813b15a34"),
                            CreatedDate = new DateTime(2024, 5, 2, 21, 57, 54, 943, DateTimeKind.Utc).AddTicks(8506),
                            IsDeleted = false,
                            Name = "Shooter"
                        },
                        new
                        {
                            Id = new Guid("1d2dcf3c-f2ed-40c8-a224-f20e5ed2e88c"),
                            CreatedDate = new DateTime(2024, 5, 2, 21, 57, 54, 943, DateTimeKind.Utc).AddTicks(8515),
                            IsDeleted = false,
                            Name = "Platformer "
                        });
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
