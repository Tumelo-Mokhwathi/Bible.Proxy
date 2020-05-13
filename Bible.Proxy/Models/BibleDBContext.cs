using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Bible.Proxy.Models
{
    public class BibleDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration["ConnectionStrings:ApplicationConnection"]);
        }
        public DbSet<AmericanStandardVersion> AmericanStandardVersion { get; set; }
        public DbSet<EnglishStandardVersion> EnglishStandardVersion { get; set; } 
        public DbSet<KingJamesVersion> KingJamesVersion { get; set; }
    }
}
