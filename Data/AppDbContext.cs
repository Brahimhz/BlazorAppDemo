using Microsoft.EntityFrameworkCore;

namespace BlazorAppDemo.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            Post[] postsToSeed = new Post[10];

            for (int i = 1; i < 11; i++)
                postsToSeed[i - 1] = new Post
                {
                    Id = i,
                    Title = "Post" + i,
                    Content = " this post number " + i
                };

            modelBuilder.Entity<Post>().HasData(postsToSeed);
        }
    }
}
