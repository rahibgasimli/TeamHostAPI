using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TeamHost.DAL.Entities;
using TeamHost.DAL.Extensions;

namespace TeamHost.DAL.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {}

        public DbSet<Game> Games { get; set; }
        public DbSet<GameTag> GameTags { get; set; }
        public DbSet<BannerPhoto> BannerPhotos { get; set; }
        public DbSet<GroupsEntity> GroupsTables { get; set; }
        public DbSet<MarketCard> MarketCards { get; set; }
        //public DbSet<Friend> Friends { get; set; }
        public DbSet<Friendship> Friendships { get; set; }
        public DbSet<Activities> Activities { get; set; }
        public DbSet<UserComment> UserComments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>()
                .HasIndex(g => g.Name)
                .IsUnique(true);

            modelBuilder.SeedGames();
            modelBuilder.SeedGameTags();
            modelBuilder.SeedBannerPhotos();
            modelBuilder.SeedActivities();
            modelBuilder.SeedRoles();

            base.OnModelCreating(modelBuilder);
        }

    }
}
