using Microsoft.EntityFrameworkCore;
using PersonalFinancePlatformAPI.Models;
using System.Collections.Generic;

namespace PersonalFinancePlatformAPI.Data
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
