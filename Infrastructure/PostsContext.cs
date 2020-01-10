using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Posts.API.Models;

namespace Posts.API.Infrastructure
{
    public class PostsContext : DbContext
    {
        public PostsContext(DbContextOptions<PostsContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
    }

    /*
    public class PostsContextDesignFactory : IDesignTimeDbContextFactory<PostsContext>
    {
        public PostsContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PostsContext>()
                .UseSqlServer(@"Server=localhost\SQLEXPRESS01;Database=master;Trusted_Connection=True;");

            return new PostsContext(optionsBuilder.Options);
        }
    }
    */
}
