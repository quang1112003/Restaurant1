using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using RestaurantWebsite.Models;
using System.Collections.Generic;

namespace RestaurantWebsite.Data
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options){ }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Menu> Menus { get; set; }

    }
}
