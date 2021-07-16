using Bambo.Core.Entites;
using Bambo.Infrastrcuture.Sql.Config;
using Microsoft.EntityFrameworkCore;
using System;

namespace Bambo.Infrastrcuture.Sql
{
    public class DemoContext:DbContext
    {
        public DemoContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfig());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Media> Medias { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
