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
    [Migration("20240526205434_mig14")]
    partial class mig14
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ActivitiesAppUser", b =>
                {
                    b.Property<Guid>("ActivitiesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ActivitiesId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("ActivitiesAppUser");
                });

            modelBuilder.Entity("AppUserFriend", b =>
                {
                    b.Property<Guid>("FriendsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UsersId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("FriendsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("AppUserFriend");
                });

            modelBuilder.Entity("AppUserGroupsEntity", b =>
                {
                    b.Property<Guid>("GroupsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MembersId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("GroupsId", "MembersId");

                    b.HasIndex("MembersId");

                    b.ToTable("AppUserGroupsEntity");
                });

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "abc804e5-bc7c-42d8-b52b-abc22305fd70",
                            ConcurrencyStamp = "c09295d9-522e-4d0e-a07a-bc6f3a7bfb51",
                            Name = "None",
                            NormalizedName = "NONE"
                        },
                        new
                        {
                            Id = "93592c5c-4fbf-42b5-94b0-9a52987a37fc",
                            ConcurrencyStamp = "e6d5483e-c268-4a95-a65d-0370a2d850ad",
                            Name = "Admin",
                            NormalizedName = "ADMİN"
                        },
                        new
                        {
                            Id = "b6f67aa3-aa50-4c7a-8b32-3df0fc25e8bb",
                            ConcurrencyStamp = "c2bd4672-1325-41ee-a6d5-59c95d4baafc",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TeamHost.DAL.Entities.Activities", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Activities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0610ead0-1fce-48b2-8bf9-2a77e34fd8f1"),
                            CreatedDate = new DateTime(2024, 5, 26, 23, 54, 33, 828, DateTimeKind.Local).AddTicks(7010),
                            IsDeleted = false,
                            ItemName = "CS:GO",
                            PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/game-1.jpg",
                            Price = 15.0
                        });
                });

            modelBuilder.Entity("TeamHost.DAL.Entities.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Followers")
                        .HasColumnType("tinyint");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<byte>("Posts")
                        .HasColumnType("tinyint");

                    b.Property<string>("ProfilePhoto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<double>("Wallet")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("TeamHost.DAL.Entities.BannerPhoto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("BannerPhotos");

                    b.HasData(
                        new
                        {
                            Id = new Guid("18f7250a-778b-454e-b7ec-d6a9329b9ad2"),
                            CreatedDate = new DateTime(2024, 5, 26, 20, 54, 33, 828, DateTimeKind.Utc).AddTicks(6970),
                            IsDeleted = false,
                            PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/t1.jpg"
                        },
                        new
                        {
                            Id = new Guid("9611b72d-09f7-41b0-a303-766f9640ad63"),
                            CreatedDate = new DateTime(2024, 5, 26, 20, 54, 33, 828, DateTimeKind.Utc).AddTicks(6978),
                            IsDeleted = false,
                            PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/t2.jpg"
                        });
                });

            modelBuilder.Entity("TeamHost.DAL.Entities.Friend", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pending")
                        .HasColumnType("int");

                    b.Property<string>("ProfilePhoto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Friends");
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
                            Id = new Guid("cec08206-7ae6-4504-a7d8-70fa03104b2d"),
                            CreatedDate = new DateTime(2024, 5, 26, 20, 54, 33, 828, DateTimeKind.Utc).AddTicks(6686),
                            Description = "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.",
                            IsDeleted = false,
                            Name = "Hunt of Duplicity",
                            PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/game-2.jpg",
                            Price = 9.9900000000000002,
                            Reviews = 4.5999999999999996
                        },
                        new
                        {
                            Id = new Guid("ae773116-cd89-400e-a26b-266ea564bfc7"),
                            CreatedDate = new DateTime(2024, 5, 26, 20, 54, 33, 828, DateTimeKind.Utc).AddTicks(6696),
                            Description = "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.",
                            IsDeleted = false,
                            Name = "Struggle of Rivalry",
                            PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/game-1.jpg",
                            Price = 4.9900000000000002,
                            Reviews = 4.7999999999999998
                        },
                        new
                        {
                            Id = new Guid("b1dd2aa5-ed29-4fce-8580-5147ef48c4a3"),
                            CreatedDate = new DateTime(2024, 5, 26, 20, 54, 33, 828, DateTimeKind.Utc).AddTicks(6715),
                            Description = "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.",
                            IsDeleted = false,
                            Name = "Journey and Dimension",
                            PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/game-3.jpg",
                            Price = 13.99,
                            Reviews = 4.7000000000000002
                        },
                        new
                        {
                            Id = new Guid("13510435-a7da-4a77-97a5-e49634773c3e"),
                            CreatedDate = new DateTime(2024, 5, 26, 20, 54, 33, 828, DateTimeKind.Utc).AddTicks(6718),
                            Description = "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.",
                            IsDeleted = false,
                            Name = "Reckoning and Freedom",
                            PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/game-4.jpg",
                            Price = 49.990000000000002,
                            Reviews = 4.0999999999999996
                        },
                        new
                        {
                            Id = new Guid("c2614590-fc37-4523-b629-06f5dbb248fd"),
                            CreatedDate = new DateTime(2024, 5, 26, 20, 54, 33, 828, DateTimeKind.Utc).AddTicks(6721),
                            Description = "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.",
                            IsDeleted = false,
                            Name = "Pillage of Redemption",
                            PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/game-5.jpg",
                            Price = 13.99,
                            Reviews = 4.7000000000000002
                        },
                        new
                        {
                            Id = new Guid("54d3bf9c-2a5d-44bd-9653-37b2a5902748"),
                            CreatedDate = new DateTime(2024, 5, 26, 20, 54, 33, 828, DateTimeKind.Utc).AddTicks(6728),
                            Description = "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.",
                            IsDeleted = false,
                            Name = "CS:GO",
                            PhotoPath = "https://www.shutterstock.com/image-vector/counter-strike-cs-shooting-game-600nw-2340252603.jpg",
                            Price = 12.99,
                            Reviews = 4.7999999999999998
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
                            Id = new Guid("b47c0136-6be2-4ea8-9785-4dfea14c4f19"),
                            CreatedDate = new DateTime(2024, 5, 26, 20, 54, 33, 828, DateTimeKind.Utc).AddTicks(6896),
                            IsDeleted = false,
                            Name = "Action"
                        },
                        new
                        {
                            Id = new Guid("a1defbf6-5e84-4fd2-9997-968da45dea49"),
                            CreatedDate = new DateTime(2024, 5, 26, 20, 54, 33, 828, DateTimeKind.Utc).AddTicks(6901),
                            IsDeleted = false,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = new Guid("a28b8358-02b6-4c3e-902b-2f935aa6817e"),
                            CreatedDate = new DateTime(2024, 5, 26, 20, 54, 33, 828, DateTimeKind.Utc).AddTicks(6904),
                            IsDeleted = false,
                            Name = "Survival"
                        },
                        new
                        {
                            Id = new Guid("c0db0f93-0eb2-45c2-8fcd-7df7db222537"),
                            CreatedDate = new DateTime(2024, 5, 26, 20, 54, 33, 828, DateTimeKind.Utc).AddTicks(6906),
                            IsDeleted = false,
                            Name = "Strategy"
                        },
                        new
                        {
                            Id = new Guid("27221d89-73bb-47ca-bea5-731f088d11a3"),
                            CreatedDate = new DateTime(2024, 5, 26, 20, 54, 33, 828, DateTimeKind.Utc).AddTicks(6914),
                            IsDeleted = false,
                            Name = "Shooter"
                        },
                        new
                        {
                            Id = new Guid("57397a05-4e13-4f56-9d6f-368272a847fb"),
                            CreatedDate = new DateTime(2024, 5, 26, 20, 54, 33, 828, DateTimeKind.Utc).AddTicks(6918),
                            IsDeleted = false,
                            Name = "Platformer "
                        });
                });

            modelBuilder.Entity("TeamHost.DAL.Entities.GroupsEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("GroupStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Post")
                        .HasColumnType("tinyint");

                    b.Property<string>("ProfilePhoto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("GroupsTables");
                });

            modelBuilder.Entity("TeamHost.DAL.Entities.MarketCard", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("GameName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<double>("StartingPrice")
                        .HasColumnType("float");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("MarketCards");
                });

            modelBuilder.Entity("TeamHost.DAL.Entities.UserComment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("UserComments");
                });

            modelBuilder.Entity("ActivitiesAppUser", b =>
                {
                    b.HasOne("TeamHost.DAL.Entities.Activities", null)
                        .WithMany()
                        .HasForeignKey("ActivitiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamHost.DAL.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppUserFriend", b =>
                {
                    b.HasOne("TeamHost.DAL.Entities.Friend", null)
                        .WithMany()
                        .HasForeignKey("FriendsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamHost.DAL.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppUserGroupsEntity", b =>
                {
                    b.HasOne("TeamHost.DAL.Entities.GroupsEntity", null)
                        .WithMany()
                        .HasForeignKey("GroupsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamHost.DAL.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("MembersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TeamHost.DAL.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TeamHost.DAL.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamHost.DAL.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TeamHost.DAL.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TeamHost.DAL.Entities.UserComment", b =>
                {
                    b.HasOne("TeamHost.DAL.Entities.AppUser", "AppUser")
                        .WithMany("Comments")
                        .HasForeignKey("AppUserId");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("TeamHost.DAL.Entities.AppUser", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}