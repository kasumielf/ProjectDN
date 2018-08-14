using Microsoft.EntityFrameworkCore;
using ProjectDNCommon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDNMain.Context
{
    public class SqlServerUserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(u => new { u.UserId, u.Email });

            modelBuilder.Entity<UserRole>()
                .HasOne(r => r.User)
                .WithMany(u => u.Roles)
                .HasForeignKey(r => new { r.UserId, r.Email })
                .HasConstraintName("ForeignKey_User_UserRole");

            modelBuilder.Entity<UserRole>()
                .HasKey(r => new { r.UserId, r.Email });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string cn = "Server=localhost;User Id=SA;Database=dn;Password=pokemaster1@;";
            optionsBuilder.UseSqlServer(cn);
        }
    }
}
