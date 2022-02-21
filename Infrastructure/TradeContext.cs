using Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure
{
    public class TradeContext : DbContext
    {
        public TradeContext(DbContextOptions<TradeContext> options) : base(options)
        {
        }
        public DbSet<Trade> mt5_deals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trade>().HasKey(d => d.Deal);
            modelBuilder.Entity<Trade>().Property(d => d.Deal).ValueGeneratedOnAdd();
            modelBuilder.Entity<Trade>().Property(p => p.Price).HasConversion<decimal>();
            modelBuilder.Entity<Trade>().Property(p => p.Profit).HasConversion<decimal>();
        }
    }
}
