using System;
using System.Collections.Generic;
using System.Linq;
using SimpleSongs.Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace SimpleSongs.Data.Context
{
    public class SongsContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=SimpleSongs;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.SeedDatabase();
        }
    }
}
