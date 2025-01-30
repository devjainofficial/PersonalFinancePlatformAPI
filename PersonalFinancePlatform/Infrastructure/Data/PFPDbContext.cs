using Microsoft.EntityFrameworkCore;
using PersonalFinancePlatformAPI.Entities;
using System.Collections.Generic;

namespace PersonalFinancePlatformAPI.Infrastructure.Data
{
    public class PFPDbContext : DbContext
    {
        public PFPDbContext(DbContextOptions<PFPDbContext> options)
        : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
