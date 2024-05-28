using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TeamHost.DAL.Entities;
using TeamHost.DAL.Enums;

namespace TeamHost.DAL.Extensions
{
    public static class EFCoreExtensions
    {
        public static void SeedGames(this ModelBuilder builder)
        {
            List<Game> seedData = new List<Game>()
            {
                new Game()
                {
                    Id = Guid.NewGuid(),
                    Name = "Hunt of Duplicity",
                    Description = "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.",
                    PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/game-2.jpg",
                    Price = 9.99,
                    Reviews = 4.6,
                    CreatedDate = DateTime.UtcNow,
                },
                new Game()
                {
                    Id = Guid.NewGuid(),
                    Name = "Struggle of Rivalry",
                    Description = "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.",
                    PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/game-1.jpg",
                    Price = 4.99,
                    Reviews = 4.8,
                    CreatedDate = DateTime.UtcNow,
                },
                new Game()
                {
                    Id = Guid.NewGuid(),
                    Name = "Journey and Dimension",
                    Description = "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.",
                    PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/game-3.jpg",
                    Price = 13.99,
                    Reviews = 4.7,
                    CreatedDate = DateTime.UtcNow,
                },
                new Game()
                {
                    Id = Guid.NewGuid(),
                    Name = "Reckoning and Freedom",
                    Description = "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.",
                    PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/game-4.jpg",
                    Price = 49.99,
                    Reviews = 4.1,
                    CreatedDate = DateTime.UtcNow,
                },
                new Game()
                {
                    Id = Guid.NewGuid(),
                    Name = "Pillage of Redemption",
                    Description = "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.",
                    PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/game-5.jpg",
                    Price = 13.99,
                    Reviews = 4.7,
                    CreatedDate = DateTime.UtcNow,
                },
                new Game()
                {
                    Id = Guid.NewGuid(),
                    Name = "CS:GO",
                    Description = "TeamHost is a simulation and strategy game of managing a city struggling to survive after apocalyptic global cooling.",
                    PhotoPath = "https://www.shutterstock.com/image-vector/counter-strike-cs-shooting-game-600nw-2340252603.jpg",
                    Price = 12.99,
                    Reviews = 4.8,
                    CreatedDate = DateTime.UtcNow,
                }
            };

            builder.Entity<Game>()
                .HasData(seedData);

        }

        public static void SeedGameTags(this ModelBuilder builder)
        {
            List<GameTag> seedData = new List<GameTag>()
            {
                new GameTag()
                {
                    Id = Guid.NewGuid(),
                    Name = "Action",
                    CreatedDate = DateTime.UtcNow
                },
                new GameTag()
                {
                    Id = Guid.NewGuid(),
                    Name = "Adventure",
                    CreatedDate = DateTime.UtcNow
                },
                new GameTag()
                {
                    Id = Guid.NewGuid(),
                    Name = "Survival",
                    CreatedDate = DateTime.UtcNow
                },
                new GameTag()
                {
                    Id = Guid.NewGuid(),
                    Name = "Strategy",
                    CreatedDate = DateTime.UtcNow
                },
                new GameTag()
                {
                    Id = Guid.NewGuid(),
                    Name = "Shooter",
                    CreatedDate = DateTime.UtcNow
                },
                new GameTag()
                {
                    Id = Guid.NewGuid(),
                    Name = "Platformer ",
                    CreatedDate = DateTime.UtcNow
                },
            };

            builder.Entity<GameTag>()
                .HasData(seedData);

        }
        public static void SeedRoles(this ModelBuilder builder)
        {
            var roles = Enum.GetNames(typeof(RoleTypes));
            var identityRoles = new List<IdentityRole>();

            foreach (var role in roles)
            {
                identityRoles.Add(new IdentityRole()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = role,
                    NormalizedName = role.ToUpper().Replace("İ", "I")
                });
            }

            builder.Entity<IdentityRole>()
                .HasData(identityRoles);
        }

        public static void SeedBannerPhotos(this ModelBuilder builder)
        {
            List<BannerPhoto> seedData = new List<BannerPhoto>()
            {

                new BannerPhoto()
                {
                    Id = Guid.NewGuid(),
                    PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/t1.jpg",
                    CreatedDate = DateTime.UtcNow
                },
                new BannerPhoto()
                {
                    Id = Guid.NewGuid(),
                    PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/t2.jpg",
                    CreatedDate = DateTime.UtcNow
                }
            };

            builder.Entity<BannerPhoto>()
                .HasData(seedData);
        }

        // WALLET

        public static void SeedActivities(this ModelBuilder builder)
        {
            List<Activities> seedData = new List<Activities>()
            {
                new Activities()
                {
                    Id= Guid.NewGuid(),
                    ItemName = "CS:GO",
                    CreatedDate = DateTime.Now,
                    PhotoPath = "https://pro-theme.com/html/teamhost/assets/img/game-1.jpg",
                    Price = 15,
                }
            };

            builder.Entity<Activities>()
                .HasData(seedData);
        }


    }
}
