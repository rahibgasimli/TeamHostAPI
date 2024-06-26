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
    [Migration("20240526220237_mig16")]
    partial class mig16
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

            modelBuilder.Entity("AppUserFriendship", b =>
                {
                    b.Property<string>("FriendsId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("FriendshipsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FriendsId", "FriendshipsId");

                    b.HasIndex("FriendshipsId");

                    b.ToTable("AppUserFriendship");
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
                            Id = "971e3edc-1f29-4b95-b561-0fdb56826f38",
                            ConcurrencyStamp = "d3819e2f-c0b1-406b-bf75-60a4a7c5f50a",
                            Name = "None",
                            NormalizedName = "NONE"
                        },
                        new
                        {
                            Id = "c27465a9-260e-4a25-b857-e1f9aa859fc7",
                            ConcurrencyStamp = "449f0989-3ab7-4158-86f9-0839fc59a277",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2b6eb3d9-06a6-4b07-8cdc-58bed4219b17",
                            ConcurrencyStamp = "8d41dc81-6070-4eb0-b7f3-b100c5008fea",
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
                            Id = new Guid("28fec8af-1160-4c7d-a284-5a54de4cb25e"),
                            CreatedDate = new DateTime(2024, 5, 27, 1, 2, 36, 676, DateTimeKind.Local).AddTicks(3849),
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
                            Id = new Guid("e15be664-e98e-41ed-abe5-d21093c0b3c3"),
                            CreatedDate = new DateTime(2024, 5, 26, 22, 2, 36, 676, DateTimeKind.Utc).AddTicks(3797),
                            IsDeleted = false,
                            PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/t1.jpg"
                        },
                        new
                        {
                            Id = new Guid("7ce9e710-8c63-42d8-9d8e-99033d100a68"),
                            CreatedDate = new DateTime(2024, 5, 26, 22, 2, 36, 676, DateTimeKind.Utc).AddTicks(3809),
                            IsDeleted = false,
                            PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/t2.jpg"
                        });
                });

            modelBuilder.Entity("TeamHost.DAL.Entities.Friendship", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Friendships");
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
                            Id = new Guid("aa78b2f0-d0bf-4bbd-8ac8-786a7146ff10"),
                            CreatedDate = new DateTime(2024, 5, 26, 22, 2, 36, 676, DateTimeKind.Utc).AddTicks(3590),
                            Description = "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.",
                            IsDeleted = false,
                            Name = "Hunt of Duplicity",
                            PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/game-2.jpg",
                            Price = 9.9900000000000002,
                            Reviews = 4.5999999999999996
                        },
                        new
                        {
                            Id = new Guid("99616edf-3636-44ea-a2aa-06c3c945de71"),
                            CreatedDate = new DateTime(2024, 5, 26, 22, 2, 36, 676, DateTimeKind.Utc).AddTicks(3600),
                            Description = "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.",
                            IsDeleted = false,
                            Name = "Struggle of Rivalry",
                            PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/game-1.jpg",
                            Price = 4.9900000000000002,
                            Reviews = 4.7999999999999998
                        },
                        new
                        {
                            Id = new Guid("a44ce6c8-894c-44a1-89ee-9f55b29174f5"),
                            CreatedDate = new DateTime(2024, 5, 26, 22, 2, 36, 676, DateTimeKind.Utc).AddTicks(3604),
                            Description = "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.",
                            IsDeleted = false,
                            Name = "Journey and Dimension",
                            PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/game-3.jpg",
                            Price = 13.99,
                            Reviews = 4.7000000000000002
                        },
                        new
                        {
                            Id = new Guid("0cc10504-a53d-4b50-bc9d-49c3c9c11ceb"),
                            CreatedDate = new DateTime(2024, 5, 26, 22, 2, 36, 676, DateTimeKind.Utc).AddTicks(3606),
                            Description = "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.",
                            IsDeleted = false,
                            Name = "Reckoning and Freedom",
                            PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/game-4.jpg",
                            Price = 49.990000000000002,
                            Reviews = 4.0999999999999996
                        },
                        new
                        {
                            Id = new Guid("adb645ef-3855-4e9f-9b2f-f47413aff453"),
                            CreatedDate = new DateTime(2024, 5, 26, 22, 2, 36, 676, DateTimeKind.Utc).AddTicks(3609),
                            Description = "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.",
                            IsDeleted = false,
                            Name = "Pillage of Redemption",
                            PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/game-5.jpg",
                            Price = 13.99,
                            Reviews = 4.7000000000000002
                        },
                        new
                        {
                            Id = new Guid("e66dd685-60a2-4ac9-a7ee-bdebfd602d3f"),
                            CreatedDate = new DateTime(2024, 5, 26, 22, 2, 36, 676, DateTimeKind.Utc).AddTicks(3634),
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
                            Id = new Guid("50159767-975b-4e77-adce-fc86b278c115"),
                            CreatedDate = new DateTime(2024, 5, 26, 22, 2, 36, 676, DateTimeKind.Utc).AddTicks(3730),
                            IsDeleted = false,
                            Name = "Action"
                        },
                        new
                        {
                            Id = new Guid("72fecfdb-e9a8-4952-bda3-09f47f713dc5"),
                            CreatedDate = new DateTime(2024, 5, 26, 22, 2, 36, 676, DateTimeKind.Utc).AddTicks(3736),
                            IsDeleted = false,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = new Guid("0476c786-2467-4c01-b622-3bcc03ee4b64"),
                            CreatedDate = new DateTime(2024, 5, 26, 22, 2, 36, 676, DateTimeKind.Utc).AddTicks(3738),
                            IsDeleted = false,
                            Name = "Survival"
                        },
                        new
                        {
                            Id = new Guid("45905ed1-a10d-42c7-9053-c75b0dd25e48"),
                            CreatedDate = new DateTime(2024, 5, 26, 22, 2, 36, 676, DateTimeKind.Utc).AddTicks(3740),
                            IsDeleted = false,
                            Name = "Strategy"
                        },
                        new
                        {
                            Id = new Guid("4023d419-0f62-4ee9-87fb-76bf44a835a5"),
                            CreatedDate = new DateTime(2024, 5, 26, 22, 2, 36, 676, DateTimeKind.Utc).AddTicks(3743),
                            IsDeleted = false,
                            Name = "Shooter"
                        },
                        new
                        {
                            Id = new Guid("ee29d02e-49c5-4b5b-b9d6-643665ef8c13"),
                            CreatedDate = new DateTime(2024, 5, 26, 22, 2, 36, 676, DateTimeKind.Utc).AddTicks(3747),
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

            modelBuilder.Entity("AppUserFriendship", b =>
                {
                    b.HasOne("TeamHost.DAL.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("FriendsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamHost.DAL.Entities.Friendship", null)
                        .WithMany()
                        .HasForeignKey("FriendshipsId")
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
