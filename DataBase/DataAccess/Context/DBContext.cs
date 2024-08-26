using BusinessLogic.Services.NewsFolder.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataBase.DataAccess.Context
{
    public sealed class DBContext : DbContext
    {
        private DbSet<News> News { get; set; }
        private DbSet<NewsContent> NewsContents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>()
                .HasMany(n => n.Content)
                .WithOne(nc => nc.News)
                .HasForeignKey(nc => nc.NewsId);
        }

        public DBContext(DbContextOptions options) : base(options)
        {
        }
    }   
}