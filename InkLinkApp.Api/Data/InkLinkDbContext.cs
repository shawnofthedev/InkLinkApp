using Microsoft.EntityFrameworkCore;
using InkLink.Server.Models;

namespace InkLink.Server.Data
{
    public class InkLinkDbContext : DbContext
    {
        public InkLinkDbContext(DbContextOptions<InkLinkDbContext> options) : base(options)
        {
        }

        public DbSet<StoryRoom> StoryRooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed sample room (optional, for quick testing)
            modelBuilder.Entity<StoryRoom>().HasData(new StoryRoom
            {
                Id = Guid.NewGuid(),
                Name = "Test Room",
                Description = "seed",
                RoomType = "Prompt Playground",
                CreatedAt = DateTime.UtcNow,
            });
        }
    }
}
