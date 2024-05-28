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
    [Migration("20240518102230_mig09")]
    partial class mig09
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
                            Id = new Guid("a8767d9d-45e3-4f88-b7e3-7456ac142c2c"),
                            CreatedDate = new DateTime(2024, 5, 18, 10, 22, 28, 962, DateTimeKind.Utc).AddTicks(4385),
                            IsDeleted = false,
                            PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/t1.jpg"
                        },
                        new
                        {
                            Id = new Guid("a661d1d9-658d-4fca-8f16-0447927d5e47"),
                            CreatedDate = new DateTime(2024, 5, 18, 10, 22, 28, 962, DateTimeKind.Utc).AddTicks(4390),
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

                    b.Property<bool>("Request")
                        .HasColumnType("bit");

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
                            Id = new Guid("7d9175ad-5118-4e5f-adbc-d4ed3efbf195"),
                            CreatedDate = new DateTime(2024, 5, 18, 10, 22, 28, 962, DateTimeKind.Utc).AddTicks(4165),
                            Description = "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.",
                            IsDeleted = false,
                            Name = "Hunt of Duplicity",
                            PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/game-2.jpg",
                            Price = 9.9900000000000002,
                            Reviews = 4.5999999999999996
                        },
                        new
                        {
                            Id = new Guid("3bc2b4b6-58f4-42fd-8050-893ef723a8eb"),
                            CreatedDate = new DateTime(2024, 5, 18, 10, 22, 28, 962, DateTimeKind.Utc).AddTicks(4176),
                            Description = "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.",
                            IsDeleted = false,
                            Name = "Struggle of Rivalry",
                            PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/game-1.jpg",
                            Price = 4.9900000000000002,
                            Reviews = 4.7999999999999998
                        },
                        new
                        {
                            Id = new Guid("71bbfd4e-5a62-429c-a87b-ee887bac118c"),
                            CreatedDate = new DateTime(2024, 5, 18, 10, 22, 28, 962, DateTimeKind.Utc).AddTicks(4179),
                            Description = "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.",
                            IsDeleted = false,
                            Name = "Journey and Dimension",
                            PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/game-3.jpg",
                            Price = 13.99,
                            Reviews = 4.7000000000000002
                        },
                        new
                        {
                            Id = new Guid("1dfdbbad-7fd6-469c-9930-febd92fe0e7a"),
                            CreatedDate = new DateTime(2024, 5, 18, 10, 22, 28, 962, DateTimeKind.Utc).AddTicks(4198),
                            Description = "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.",
                            IsDeleted = false,
                            Name = "Reckoning and Freedom",
                            PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/game-4.jpg",
                            Price = 49.990000000000002,
                            Reviews = 4.0999999999999996
                        },
                        new
                        {
                            Id = new Guid("0bb48944-23ef-437e-90d5-d552b3158dc9"),
                            CreatedDate = new DateTime(2024, 5, 18, 10, 22, 28, 962, DateTimeKind.Utc).AddTicks(4201),
                            Description = "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.",
                            IsDeleted = false,
                            Name = "Pillage of Redemption",
                            PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/game-5.jpg",
                            Price = 13.99,
                            Reviews = 4.7000000000000002
                        },
                        new
                        {
                            Id = new Guid("378fae46-31aa-429d-99cc-790a96d16089"),
                            CreatedDate = new DateTime(2024, 5, 18, 10, 22, 28, 962, DateTimeKind.Utc).AddTicks(4208),
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
                            Id = new Guid("8552c009-cdc0-48bb-9877-a42ffe6133a0"),
                            CreatedDate = new DateTime(2024, 5, 18, 10, 22, 28, 962, DateTimeKind.Utc).AddTicks(4304),
                            IsDeleted = false,
                            Name = "Action"
                        },
                        new
                        {
                            Id = new Guid("26aca6c4-65ed-470f-bf00-89e90ecaffbb"),
                            CreatedDate = new DateTime(2024, 5, 18, 10, 22, 28, 962, DateTimeKind.Utc).AddTicks(4310),
                            IsDeleted = false,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = new Guid("3217dd6b-d147-4eac-af23-cf7e17fe1956"),
                            CreatedDate = new DateTime(2024, 5, 18, 10, 22, 28, 962, DateTimeKind.Utc).AddTicks(4313),
                            IsDeleted = false,
                            Name = "Survival"
                        },
                        new
                        {
                            Id = new Guid("ad586c63-54e2-411b-8179-567e49c48580"),
                            CreatedDate = new DateTime(2024, 5, 18, 10, 22, 28, 962, DateTimeKind.Utc).AddTicks(4315),
                            IsDeleted = false,
                            Name = "Strategy"
                        },
                        new
                        {
                            Id = new Guid("4546fe39-55ac-4452-a0a2-dd0fffc392d5"),
                            CreatedDate = new DateTime(2024, 5, 18, 10, 22, 28, 962, DateTimeKind.Utc).AddTicks(4317),
                            IsDeleted = false,
                            Name = "Shooter"
                        },
                        new
                        {
                            Id = new Guid("52f19da0-d9a9-4822-a31b-1e0283d6a4c2"),
                            CreatedDate = new DateTime(2024, 5, 18, 10, 22, 28, 962, DateTimeKind.Utc).AddTicks(4328),
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
#pragma warning restore 612, 618
        }
    }
}