using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unicorn.Api.Models;

namespace Unicorn.Api.DAL
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var users = Enumerable.Range(1, 50).Select((index) => new User
            {
                Id = index,
                Address = $"Adress {index}",
                Email = $"someemail@for{index}.com",
                FirstName = $"First Name for {index}",
                LastName = $"Last Name for {index}",
                FacebookLink = index %2 == 0?  $"Facebook link {index}" : null,
                PhoneNumber = $"Phone Number for {index}",
                TwitterLink = $"Twitter link for {index}"
                
            });

            modelBuilder.Entity<User>().HasData(users);
        }
    }
}

